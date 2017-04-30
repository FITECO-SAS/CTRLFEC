using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyseEtControleFEC.Controller
{
    public class SimpleFilterController
    {
        private DataBaseController dataBaseController;

        public SimpleFilterController(DataBaseController dataBaseController)
        {
            this.dataBaseController = dataBaseController;
        }
        /*
        La liste des opérateurs à prévoir pour les champs de type Numérique et Date est la suivante :
            - Est supérieur à
            - Est supérieur ou égal à
            - Est inférieur à
            - Est inférieur ou égal à
            - Est égal à
            - Est différent de
        La liste des opérateurs à prévoir pour les champs de type Chaîne de caractères est la suivante :
            - Contient
            - Ne contient pas
            - Commence par
            - Ne commence pas par
            - Se termine par
            - Ne se termine pas par
            - Est égal à
            - Est différent de
         */

        public void SimpleFilterStatementController(string[] colums, string[] whereClause, bool[] isOr)
        {
            string finalWhereClause = "WHERE ";
            for (int i = 0; i < whereClause.Length; i++)
            {
                finalWhereClause += whereClause[i] + " ";
                if (i < isOr.Length)
                {
                    if (isOr[i])
                        finalWhereClause += "OR ";
                    else
                        finalWhereClause += "AND ";
                }
            }
            dataBaseController.AddFilter(finalWhereClause);
        }
        public string NumericOrDateSimpleFilter(string column, string typeFilter, string value)
        {
            
            string[] columnNames = dataBaseController.getColumnNames();
            string columnNameInDb = "";
            for (int i = 0; i < columnNames.Length; i++)
            {
                if (columnNames[i].Equals(column))
                    columnNameInDb = i.ToString();
            }

            string result = "WHERE Column = " + columnNameInDb;
            switch (typeFilter)
            {
                case "Est supérieur à":
                    return result+" AND Content > " + value;
                case "Est supérieur ou égal à":
                    return result + " AND Content >= " + value;
                case "Est inférieur à":
                    return result + " AND Content < " + value;
                case "Est inférieur ou égal à":
                    return result + " AND Content <= " + value;
                case "Est égal à":
                    return result + " AND Content = " + value;
                case "Est différent de":
                    return result + " AND Content <> " + value;
                default:
                    return result + "";

            }
        }

        public string TextSimpleFilter(string column, string typeFilter, string value)
        {
            string[] columnNames = dataBaseController.getColumnNames();
            string columnNameInDb = "";
            for (int i = 0; i < columnNames.Length; i++)
            {
                if (columnNames[i].Equals(column))
                    columnNameInDb = i.ToString();
            }

            string result = "WHERE Column = " + columnNameInDb;
            switch (typeFilter)
            {
                case "Contient":
                    return result + " AND Content "+"LIKE '" + "%" + value + "%" + "'";
                case "Ne contient pas":
                    return result + " AND Content "+"NOT" + " LIKE '" + "%" + value + "%"+ "'";
                case "Commence par":
                    return result + " AND Content "+" LIKE '" + value + "%" + "'";
                case "Ne commence pas par":
                    return result + " AND Content " + " NOT" +" LIKE '" + value + "%" + "'";
                case "Se termine par":
                    return result + " AND Content " + " LIKE '" + "%" + value + "'";
                case "Ne se termine pas par":
                    return result + " AND Content " + " NOT" + " LIKE '" + "%" + value + "'";
                case "Est égal à":
                    return result + " AND Content " + " LIKE '" + value + "'";
                case "Est différent de":
                    return result + " AND Content " + " NOT" + " LIKE '" + value + "'";
                default:
                    return result ;
            }
        }

    }
}
