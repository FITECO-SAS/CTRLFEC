using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AnalyseEtControleFEC.Model
{
    /// <summary>
    /// This class represent the configuration for the Structural check module
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// nameRegex is the regex that must be verified by the file name
        /// </summary>
        public String nameRegex { get; }
        /// <summary>
        /// columnSets is a list of Tuples each containing a regime, a plan and a list of possible Lists of columns for this regime and this plan
        /// </summary>
        private List<Tuple<String, String, List<List<String>>>> columnSets;
        /// <summary>
        /// columnRegex is a list of Tuples each containing a column name and the regex that each line of this column must verify
        /// </summary>
        private List<Tuple<String, String>> columnRegex;
        /// <summary>
        /// columnDependency is a list of Tuple each containing two column names, the second one can't be empty is the first is not
        /// </summary>
        private List<Tuple<String, String>> columnDependency;
        /// <summary>
        /// groupForBalanceChecks is a list of column names for wich we must verify a null balance for their equals members
        /// </summary>
        private List<String> groupsForBalanceChecks;

        /// <summary>
        /// Constructor for Configuration that read a JSon file for initialisation
        /// </summary>
        /// <param name="fileName">path of a valid JSon configuration file</param>
        public Configuration(String fileName)
        {
            JsonTextReader reader = new JsonTextReader(new StreamReader(fileName));
            JObject config = (JObject)JToken.ReadFrom(reader);
            nameRegex = config.Value<String>("nameRegex");
            JToken sets = config.Value<JToken>("columnSets");
            columnSets = new List<Tuple<string, string, List<List<string>>>>();
            foreach(JProperty regime in sets.Values<JProperty>())
            {
                foreach(JProperty plan in regime.Values())
                {
                    Tuple<String, String, List<List<String>>> columnSet = new Tuple<string, string, List<List<String>>> (regime.Name,plan.Name,new List<List<String>>());
                    foreach(JArray column in plan.Values<JArray>().Values<JArray>())
                    {
                        columnSet.Item3.Add(new List<String>(column.ToObject<string[]>()));
                    }
                    columnSets.Add(columnSet);
                }
            }
            JToken regex = config.Value<JToken>("columnRegex");
            columnRegex = new List<Tuple<string, string>>();
            foreach(JProperty column in regex.Values<JProperty>())
            {
                columnRegex.Add(new Tuple<string, string>(column.Name, column.Value.Value<String>()));
            }
            JToken dependency = config.Value<JToken>("columnDependency");
            columnDependency = new List<Tuple<string, string>>();
            foreach (JProperty column in dependency.Values<JProperty>())
            {
                columnDependency.Add(new Tuple<string, string>(column.Name, column.Value.Value<String>()));
            }
            groupsForBalanceChecks = new List<String>(config.Value<JArray>("groupsForBalanceCheck").ToObject<string[]>());
        }

        /// <summary>
        /// this function returns an array of possible list of columns that we can use for specified regime and plan 
        /// </summary>
        /// <param name="regime">the regime that we use</param>
        /// <param name="plan">the plan that we use</param>
        /// <returns></returns>
        public List<String>[] getColumnSets(string regime, string plan)
        {
            foreach(Tuple<String, String, List<List<String>>> sets in columnSets)
            {
                if (sets.Item1.Equals(regime) && sets.Item2.Equals(plan))
                {
                    return sets.Item3.ToArray();
                }
            }
            return new List<String>[0];
        }

        /// <summary>
        /// this function returns as a string the regex associated with the specified column name
        /// </summary>
        /// <param name="columnName">the name of the column wich we want it regex</param>
        /// <returns>the regex associated with the specified column name</returns>
        public String getColumnRegex(String columnName)
        {
            foreach (Tuple<String,String> cregex in columnRegex)
            {
                if (cregex.Item1 == columnName) ;
                return cregex.Item2;
            }
            return null;
        }

        /// <summary>
        /// this function returns an array of string containing regex for each column which name is in the specified array in the same order
        /// </summary>
        /// <param name="columnSet">Array of column names for which we want corresponding regex</param>
        /// <returns></returns>
        public String[] getColumnsRegex(String[] columnSet)
        {
            List<String> columnRegex = new List<string>();
            for(int i = 0; i < columnSet.Length; i++)
            {
                columnRegex.Add(getColumnRegex(columnSet[i]));
            }
            return columnRegex.ToArray();
        }
    }
}
