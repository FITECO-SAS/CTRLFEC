using AnalyseEtControleFEC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace AnalyseEtControleFEC.Controller
{
    public class MainController
    {
        //Constants
        static String dataBaseFile = "data.SQLite";
        static String configuration = "Configuration.json";
        static MainController instance;

        public DataBaseController dataBaseController { get; set; }
        public SimpleFilterController simpleFilterController { get; set; }
        Configuration config;
        Start mainWindow;

        static public MainController get()
        {
            if(instance == null)
            {
                instance = new MainController();
            }
            return instance;
        }
        private MainController()
        {
            dataBaseController = new DataBaseController(dataBaseFile,this);
            simpleFilterController = new SimpleFilterController(dataBaseController);
            config = new Configuration(configuration);
        }

        public DataBaseController getDataBaseController()
        {
            return dataBaseController;
        }

        public SimpleFilterController getSimpleFilterController()
        {
            return simpleFilterController;
        }

        public void start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Configuration config = new Configuration(configuration);
            mainWindow = new Start();
            Application.Run(mainWindow);
        }

        internal void openFile(string filePath, string fileName)
        {
            ErrorLogger logger = new ErrorLogger(config, dataBaseController, "BIC", "PCG");
            dataBaseController.init();
            dataBaseController.fillDatabaseFromFile(filePath);
            logger.checkName(fileName);
            logger.checkColumns();
            //logger.checkLines();
            //logger.checkLinesWithAll();
            logger.checkLinesInDatabase();
            Console.WriteLine(logger.createLog());
            DataGridView gridView = mainWindow.getDataGridView();
            //List<string[]> content = new List<String[]>();
            //String[][] content = dataBaseController.getAllLines();
            //SQLiteDataAdapter dataAdapter = dataBaseController.getDataAdapter();
            //DataSet dataSet = new DataSet();
            //dataAdapter.Fill(dataSet);
            //gridView.DataSource = dataAdapter;
            String[] Columns = dataBaseController.getColumnNames();
            int size = dataBaseController.getNumberOfLinesInFilter();
            /*for (int i=0; i<size ; i++)
            {
                content.Add(dataBaseController.getLine(i));
            }*/
            gridView.ColumnCount = Columns.Length;
            for(int i=0; i< Columns.Length; i++)
            {
                gridView.Columns[i].Name = Columns[i];
            }
            gridView.RowCount = size;
            /*for(int i=0; i<content.Length; i++)//Length was Count
            {
                gridView.Rows.Add(content[i]);
            }
            gridView.Columns = content.ToArray()[0];*/

        }

        internal void openFilter(DataGridView gridView)
        {
            String[] Columns = dataBaseController.getColumnNames();
            int size = dataBaseController.getNumberOfLinesInFilter();
            gridView.ColumnCount = Columns.Length;
            for (int i = 0; i < Columns.Length; i++)
            {
                gridView.Columns[i].Name = Columns[i];
            }
            gridView.RowCount = size;
        }
    }
}
