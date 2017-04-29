using AnalyseEtControleFEC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AnalyseEtControleFEC
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ouvrirFECToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile openFile = new OpenFile();
            openFile.ShowDialog();
            //this.Hide();
        }

        private static void readXML(string strFileName)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void sauvegarderLeFiltreSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SauFormFiltreSimple formFiltreSimple = new SauFormFiltreSimple();
            formFiltreSimple.ShowDialog();
        }

        private void sauvegarderLeFiltreÉlaboréToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            MainController controller = MainController.get();
            e.Value = controller.dataBaseController.getContentFromFilter(e.ColumnIndex, e.RowIndex);
        }

        internal DataGridView getDataGridView()
        {
            return dataGridView1;
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Simple")
            {
                panel1.Visible = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Simple")
            {
                panel1.Visible = true;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (field1ComboBox.SelectedItem.ToString().ToUpper().Contains("DATE") || field1ComboBox.SelectedItem.ToString().ToUpper().Contains("NUM") ||
                field1ComboBox.SelectedItem.ToString().ToUpper().Contains("DEBIT") || field1ComboBox.SelectedItem.ToString().ToUpper().Contains("CREDIT"))
            {
                condition1ComboBox.Items.Clear();
                condition1ComboBox.Items.AddRange(new object[] {"", "Est supérieur à", "Est supérieur ou égal à",
                    "Est inférieur à","Est inférieur ou égal à","Est égal à","Est différent de" });

            }
            else
            {
                condition1ComboBox.Items.Clear();
                condition1ComboBox.Items.AddRange(new object[] {"", "Contient", "Ne contient pas","Commence par",
                "Ne commence pas par","Se termine par","Ne se termine pas par","Est égal à","Est différent de" });
            }
        }
        private void dataGridView2_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            MainController controller = MainController.get();
            e.Value = controller.dataBaseController.getContentFromFilter(e.ColumnIndex, e.RowIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportFile exportFile = new ExportFile();
            //exportFile.ExportDataGridviewToWord(dataGridView1, true);
            //exportFile.ExportDataGridviewToExcel(dataGridView1, true);
            exportFile.ExportToCsv(dataGridView1);
        }

        private void field2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (field2ComboBox.SelectedItem.ToString().ToUpper().Contains("DATE") || field2ComboBox.SelectedItem.ToString().ToUpper().Contains("NUM") ||
                field2ComboBox.SelectedItem.ToString().ToUpper().Contains("DEBIT") || field2ComboBox.SelectedItem.ToString().ToUpper().Contains("CREDIT"))
            {
                condition2ComboBox.Items.Clear();
                condition2ComboBox.Items.AddRange(new object[] {"", "Est supérieur à", "Est supérieur ou égal à",
                    "Est inférieur à","Est inférieur ou égal à","Est égal à","Est différent de" });

            }
            else
            {
                condition2ComboBox.Items.Clear();
                condition2ComboBox.Items.AddRange(new object[] {"", "Contient", "Ne contient pas","Commence par",
                "Ne commence pas par","Se termine par","Ne se termine pas par","Est égal à","Est différent de" });
            }
        }

        private void field3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (field3ComboBox.SelectedItem.ToString().ToUpper().Contains("DATE") || field3ComboBox.SelectedItem.ToString().ToUpper().Contains("NUM") ||
                field3ComboBox.SelectedItem.ToString().ToUpper().Contains("DEBIT") || field3ComboBox.SelectedItem.ToString().ToUpper().Contains("CREDIT"))
            {
                condition3ComboBox.Items.Clear();
                condition3ComboBox.Items.AddRange(new object[] {"", "Est supérieur à", "Est supérieur ou égal à",
                    "Est inférieur à","Est inférieur ou égal à","Est égal à","Est différent de" });

            }
            else
            {
                condition3ComboBox.Items.Clear();
                condition3ComboBox.Items.AddRange(new object[] {"", "Contient", "Ne contient pas","Commence par",
                "Ne commence pas par","Se termine par","Ne se termine pas par","Est égal à","Est différent de" });
            }
        }

        private void field4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (field4ComboBox.SelectedItem.ToString().ToUpper().Contains("DATE") || field4ComboBox.SelectedItem.ToString().ToUpper().Contains("NUM") ||
                field4ComboBox.SelectedItem.ToString().ToUpper().Contains("DEBIT") || field4ComboBox.SelectedItem.ToString().ToUpper().Contains("CREDIT"))
            {
                condition4ComboBox.Items.Clear();
                condition4ComboBox.Items.AddRange(new object[] {"", "Est supérieur à", "Est supérieur ou égal à",
                    "Est inférieur à","Est inférieur ou égal à","Est égal à","Est différent de" });

            }
            else
            {
                condition4ComboBox.Items.Clear();
                condition4ComboBox.Items.AddRange(new object[] {"", "Contient", "Ne contient pas","Commence par",
                "Ne commence pas par","Se termine par","Ne se termine pas par","Est égal à","Est différent de" });
            }
        }

        String transformComboBoxValueToCommand(String operation, String content)
        {
            switch (operation)
            {
                case "Contient": return " LIKE '%" + content + "%'";
                case "Ne contient pas": return " NOT LIKE '%" + content + "%'";
                case "Commence par": return " LIKE '%" + content+"'";
                case "Ne commence pas par": return " NOT LIKE '%" + content + "'";
                case "Se termine par": return " LIKE '" + content + "%'";
                case "Ne se termine pas par": return " NOT LIKE '" + content + "%'";
                case "Est égal à": return " = '" + content + "'";
                case "Est différent de": return " != '" + content + "'";
                case "Est supérieur à": return " > '" + content + "'";
                case "Est supérieur ou égal à": return " >= '" + content + "'";
                case "Est inférieur à": return " < '" + content + "'";
                case "Est inférieur ou égal à": return " <= '" + content + "'";
                default: return "";
            }
        }
    }
}
