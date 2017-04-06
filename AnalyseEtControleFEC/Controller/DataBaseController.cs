using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;
using AnalyseEtControleFEC.Controller;

namespace AnalyseEtControleFEC.Controller
{
    [SQLiteFunction(Name = "REGEXP", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class RegExSQLiteFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(Convert.ToString(args[1]), Convert.ToString(args[0]));
        }
    }

    /// <summary>
    /// This Class is the controller for database reading and writing
    /// </summary>
    public class DataBaseController
    {
        SQLiteConnection dbConnection;
        MainController mainController;

        /// <summary>
        /// Constructor for DataBaseController
        /// </summary>
        /// <param name="fileName">Name of the database file where we want to store the database</param>
        /// <param name="mainController">The main Controller for this program</param>
        public DataBaseController(String fileName, MainController mainController)
        {
            if (!File.Exists(fileName))
            {
                SQLiteConnection.CreateFile(fileName);
            }
            dbConnection = new SQLiteConnection("Data Source="+fileName+ ";Version=3;");
            //dbConnection = new SQLiteConnection("Data Source=:memory:;Version=3;");
        }

        /// <summary>
        /// Initialyse the database by dropping existing tables if exists and create empty ones
        /// </summary>
        public void init()
        {
            dbConnection.Open();
            new SQLiteCommand("DROP TABLE IF EXISTS Column", dbConnection).ExecuteNonQuery();
            new SQLiteCommand("DROP TABLE IF EXISTS Content", dbConnection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE Column (Position INT, Name VARCHAR(20))", dbConnection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE Content (Line INT, Column INT, Content VARCHAR(100))", dbConnection).ExecuteNonQuery();
            //dbConnection.Close();
        }

        internal SQLiteDataAdapter getDataAdapter()
        {
            return new SQLiteDataAdapter("SELECT * FROM Content ORDER BY Line, Column ASC",dbConnection);
        }

        /// <summary>
        /// Fill the dataBase by reading an Accounting Entry File
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        public void fillDatabaseFromFile(String filePath)
        {
            Char[] separators = { '|', '\t' };
            FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BufferedStream bs = new BufferedStream(fs);
            StreamReader reader = new StreamReader(bs);
            //File.OpenText(filePath);
            String readLine = reader.ReadLine();
            String[] splitLine = readLine.Split(separators);
            //dbConnection.Open();
            for(int i=0; i<splitLine.Length; i++)
            {
                new SQLiteCommand("INSERT INTO Column (Position, Name) VALUES ("+i+",'"+splitLine[i]+"')", dbConnection).ExecuteNonQuery();
            }
            int line = 1;
            SQLiteCommand beginTrans = new SQLiteCommand("BEGIN TRANSACTION", dbConnection);
            SQLiteCommand commitTrans = new SQLiteCommand("COMMIT TRANSACTION", dbConnection);
            SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO Content (Line, Column, Content) VALUES (@line,@column,@content)", dbConnection);
            while (!reader.EndOfStream)
            {
                beginTrans.ExecuteNonQuery();
                int curCount = 0;
                while (!reader.EndOfStream && curCount<10000)
                {
                    readLine = reader.ReadLine();
                    splitLine = readLine.Split(separators);
                    for (int column = 0; column < splitLine.Length; column++)
                    {
                        insertCmd.Parameters.Add(new SQLiteParameter("@line", line));
                        insertCmd.Parameters.Add(new SQLiteParameter("@column", column));
                        insertCmd.Parameters.Add(new SQLiteParameter("@content", splitLine[column]));
                        insertCmd.ExecuteNonQuery();
                    }
                    line++;
                    curCount++;
                }
                commitTrans.ExecuteNonQuery();
            }
            //dbConnection.Close();
        }

        /// <summary>
        /// Getter for Columns names in the dataBase
        /// </summary>
        /// <returns>A String array containing the columns names in the database in the same order as in the file</returns>
        public String[] getColumnNames()
        {
            //dbConnection.Open();
            SQLiteDataReader reader = new SQLiteCommand("SELECT Name FROM Column ORDER BY Position ASC",dbConnection).ExecuteReader();
            List<String> result = new List<String>();
            while(reader.Read())
            {
                result.Add((String)reader["Name"]);
            }
            //dbConnection.Close();
            return result.ToArray();
        }

        /// <summary>
        /// Return a line in the file
        /// </summary>
        /// <param name="line">Line of the file to read</param>
        /// <returns>A String array containing the contents for the different columns (in the same order than the getColumnNames function) of the specified line</returns>
        public String[] getLine(int line)
        {
            //dbConnection.Open();
            SQLiteDataReader reader = new SQLiteCommand("SELECT Content FROM Content WHERE Line = "+line+" ORDER BY Column ASC", dbConnection).ExecuteReader();
            List<String> result = new List<String>();
            while (reader.Read())
            {
                result.Add((String)reader["Content"]);
            }
            //dbConnection.Close();
            return result.ToArray();
        }

        public String[][] getAllLines()
        {
            List<String[]> result = new List<String[]>();
            SQLiteDataReader reader = new SQLiteCommand("SELECT * FROM Content ORDER BY Line,Column ASC", dbConnection).ExecuteReader();
            List<String> lineContent = null;
            int line = 0;
            while (reader.Read())
            {
                if(line != (int)reader["Line"])
                {
                    if(lineContent != null)
                    {
                        result.Add(lineContent.ToArray());
                    }
                    line = (int)reader["Line"];
                    lineContent = new List<String>();
                }
                lineContent.Add((String)reader["Content"]);
            }
            result.Add(lineContent.ToArray());
            return result.ToArray();
        }

        /// <summary>
        /// Return the number of lines in the file
        /// </summary>
        /// <returns>An integer that represent the number of different lines in the file</returns>
        public int getNumberOfLines()
        {
            //dbConnection.Open();
            int result = Convert.ToInt32(new SQLiteCommand("SELECT count(*) FROM Content GROUP BY Column", dbConnection).ExecuteScalar());
            //dbConnection.Close();
            return result;
        }

        /// <summary>
        /// this method is used for regex verification using LIKE for each content member of the sepecified column
        /// </summary>
        /// <param name="column">the  column number we want to check</param>
        /// <param name="regex">the regex we want to use</param>
        /// <returns></returns>
        public List<int> checkRegexColumn(int column, String regex)
        {
            List<int> errorLines = new List<int>();
            //dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT Line FROM Content WHERE Column = @col AND Content NOT REGEXP @regex ORDER BY Line ASC", dbConnection);
            command.Parameters.Add(new SQLiteParameter("@col", column));
            command.Parameters.Add(new SQLiteParameter("@regex", regex));
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                errorLines.Add((int)reader["Line"]);
            }
            //dbConnection.Close();
            return errorLines;
        }
    }
}
