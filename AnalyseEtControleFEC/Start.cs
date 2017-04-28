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
            field1ComboBox.SelectedItem = field1ComboBox.Items[0];
            if (field1ComboBox.SelectedItem.ToString().ToUpper().Contains("DATE") || field1ComboBox.SelectedItem.ToString().ToUpper().Contains("NUM"))
            {
                condition1ComboBox.Items.Clear();
                condition1ComboBox.Items.Add("Est supérieur à");
                condition1ComboBox.Items.Add("Est supérieur ou égal à");
                condition1ComboBox.Items.Add("Est inférieur à");
                condition1ComboBox.Items.Add("Est inférieur ou égal à");
                condition1ComboBox.Items.Add("Est égal à");
                condition1ComboBox.Items.Add("Est différent de");

            }
            else
            {
                condition1ComboBox.Items.Clear();
                condition1ComboBox.Items.Add("Contient");
                condition1ComboBox.Items.Add("Ne contient pas");
                condition1ComboBox.Items.Add("Commence par");
                condition1ComboBox.Items.Add("Ne commence pas par");
                condition1ComboBox.Items.Add("Se termine par");
                condition1ComboBox.Items.Add("Ne se termine pas par");
                condition1ComboBox.Items.Add("Est égal à");
                condition1ComboBox.Items.Add("Est différent de");
            }
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
                condition1ComboBox.Items.Add("Est supérieur à");
                condition1ComboBox.Items.Add("Est supérieur ou égal à");
                condition1ComboBox.Items.Add("Est inférieur à");
                condition1ComboBox.Items.Add("Est inférieur ou égal à");
                condition1ComboBox.Items.Add("Est égal à");
                condition1ComboBox.Items.Add("Est différent de");

            }
            else
            {
                condition1ComboBox.Items.Clear();
                condition1ComboBox.Items.Add("Contient");
                condition1ComboBox.Items.Add("Ne contient pas");
                condition1ComboBox.Items.Add("Commence par");
                condition1ComboBox.Items.Add("Ne commence pas par");
                condition1ComboBox.Items.Add("Se termine par");
                condition1ComboBox.Items.Add("Ne se termine pas par");
                condition1ComboBox.Items.Add("Est égal à");
                condition1ComboBox.Items.Add("Est différent de");
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
    }
}
