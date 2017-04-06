using AnalyseEtControleFEC.Controller;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyseEtControleFEC.Model
{
    /// <summary>
    /// this class can be used to check the validity of an Accounting Entry File and produce an error log for it.
    /// it should be instancied once for each verification
    /// </summary>
    class ErrorLogger
    {
        /// <summary>
        /// the configuration that this logger must use
        /// </summary>
        private Configuration configuration;
        /// <summary>
        /// the dataBase access for the Accounting Entry File informations
        /// </summary>
        private DataBaseController dataBaseAccess;
        /// <summary>
        /// the regime of the Accounting Entry File
        /// </summary>
        private String regime;
        /// <summary>
        /// the plan of the Accounting Entry File
        /// </summary>
        private String plan;

        /// <summary>
        /// boolean that must become false if an error is detected
        /// </summary>
        private bool isFileCorrect;
        /// <summary>
        /// boolean that must become false if a name error is detected
        /// </summary>
        private bool isNameCorrect;
        /// <summary>
        /// boolean that must become false if the columns are not one of the possible columns sets
        /// </summary>
        private bool AreColumnsCorrect;
        /// <summary>
        /// a list of Tuple each containing a column name and a list of line number where an error has been found for it
        /// </summary>
        public List<Tuple<String, List<int>>> lineRegexErrors { get; }

        /// <summary>
        /// Constructor for the ErrorLogger
        /// </summary>
        /// <param name="configuration">the configuration for this logger</param>
        /// <param name="dataBaseAccess">the database access for this logger</param>
        /// <param name="regime">the regime of the Checked AEF</param>
        /// <param name="plan">the plan of the Checked AEF</param>
        public ErrorLogger(Configuration configuration, DataBaseController dataBaseAccess, String regime, String plan)
        {
            this.configuration = configuration;
            this.dataBaseAccess = dataBaseAccess;
            this.regime = regime;
            this.plan = plan;
            isFileCorrect = true;
            isNameCorrect = true;
            AreColumnsCorrect = true;
            lineRegexErrors = new List<Tuple<String, List<int>>>();
        }

        /// <summary>
        /// Check if a name is correct for the regex in configuration 
        /// </summary>
        /// <param name="name">the name that we want to check</param>
        /// <returns>true if the name is correct or false if it's not</returns>
        public bool checkName(String name)
        {
            Regex nameRegex = new Regex(configuration.nameRegex);
            if (!nameRegex.IsMatch(name))
            {
                isFileCorrect = false;
                isNameCorrect = false;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check if the columns names correspond to one of the columns sets in configuration for specified regime and plan
        /// </summary>
        /// <returns>true if the column set exists and false if it's not</returns>
        public bool checkColumns()
        {
            String[] columns = dataBaseAccess.getColumnNames();
            bool check = false;
            foreach(List<String> set in configuration.getColumnSets(regime,plan))
            {
                bool found = true;
                for(int i=0; i<columns.Length; i++)
                {
                    if (!set[i].Equals(columns[i]))
                    {
                        found = false;
                    }
                }
                if (found)
                {
                    AreColumnsCorrect = true;
                    return true;
                }
            }
            isFileCorrect = false;
            AreColumnsCorrect = false;
            return false;
        }

        /// <summary>
        /// Check if each line in the file verify the regex in the configuration
        /// </summary>
        /// <returns>false if at least one content is not correct or true if not</returns>
        public bool checkLines()
        {
            bool valid = true;
            String[] columnsRegex = configuration.getColumnsRegex(dataBaseAccess.getColumnNames());
            int nbLines = dataBaseAccess.getNumberOfLines();
            String[] lineContent;
            for(int line=0; line<nbLines; line++)
            {
                lineContent = dataBaseAccess.getLine(line);
                for(int column=0; column<lineContent.Length; column++)
                {
                    if(!(new Regex(columnsRegex[column]).IsMatch(lineContent[column])))
                    {
                        valid = false;
                        isFileCorrect = false;
                        bool found = false;
                        foreach(Tuple<String, List<int>> col in lineRegexErrors)
                        {
                            if(col.Item1 == lineContent[column])
                            {
                                found = true;
                                col.Item2.Add(line);
                            }
                        }
                        if (!found)
                        {
                            List<int> lineList = new List<int>();
                            lineList.Add(line);
                            lineRegexErrors.Add(new Tuple<String, List<int>>(dataBaseAccess.getColumnNames()[column], lineList));
                        }
                    }
                }
            }
            return valid;
        }

        public bool checkLinesWithAll()
        {
            bool valid = true;
            String[] columnsRegex = configuration.getColumnsRegex(dataBaseAccess.getColumnNames());
            int nbLines = dataBaseAccess.getNumberOfLines();
            String[][] content=  dataBaseAccess.getAllLines();
            String[] lineContent;
            for (int line = 0; line < nbLines; line++)
            {
                lineContent = content[line];
                for (int column = 0; column < lineContent.Length; column++)
                {
                    if (!(new Regex(columnsRegex[column]).IsMatch(lineContent[column])))
                    {
                        valid = false;
                        isFileCorrect = false;
                        bool found = false;
                        foreach (Tuple<String, List<int>> col in lineRegexErrors)
                        {
                            if (col.Item1 == lineContent[column])
                            {
                                found = true;
                                col.Item2.Add(line);
                            }
                        }
                        if (!found)
                        {
                            List<int> lineList = new List<int>();
                            lineList.Add(line);
                            lineRegexErrors.Add(new Tuple<String, List<int>>(dataBaseAccess.getColumnNames()[column], lineList));
                        }
                    }
                }
            }
            return valid;
        }

        /// <summary>
        /// Check if each line in the file verify the regex in the configuration
        /// </summary>
        /// <returns>false if at least one content is not correct or true if not</returns>
        public bool checkLinesInDatabase()
        {
            bool valid = true;
            String[] columns = dataBaseAccess.getColumnNames();
            String[] columnsRegex = configuration.getColumnsRegex(columns);
            for(int i=0; i<columns.Length; i++)
            {
                List<int> errors = dataBaseAccess.checkRegexColumn(i, columnsRegex[i]);
                if(errors.Count > 0)
                {
                    valid = false;
                    isFileCorrect = false;
                    lineRegexErrors.Add(new Tuple<String, List<int>>(columns[i], errors));
                }
            }
            return valid;
        }

        /// <summary>
        /// Create a String that log the encountered errors
        /// </summary>
        /// <returns>the log as a String</returns>
        public String createLog()
        {
            String log = "Rapport d'erreur :\n";
            if (isFileCorrect)
            {
                log += "Aucune erreur structurelle n'a été détectée\n";
            }
            else
            {
                log += "Une ou plusieurs erreur(s) a/ont été détéctée(s) :\n";
                if (!isNameCorrect)
                {
                    log += "\t - Le nom du fichier n'est pas conforme\n";
                }
                if (!AreColumnsCorrect)
                {
                    log += "\t - Les entêtes de colonnes ne correspondent à aucun ensemble possible pour le régime et le plan indiqués. Voici les ensembles possibles :\n";
                    foreach (List<String> set in configuration.getColumnSets(regime, plan))
                    {
                        log += "\t\t - " + set.ToString();
                    }
                }
            }
            return log;
        }
    }
}
