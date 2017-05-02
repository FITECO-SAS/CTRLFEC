using AnalyseEtControleFEC.Controller;
using ProCol;
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
            if(sender is DataGridViewBDD)
            {
                e.Value = controller.dataBaseController.getContentFromFilter(e.ColumnIndex, e.RowIndex, ((DataGridViewBDD)sender).numGridView);
            }
            else
            {
                e.Value = controller.dataBaseController.getContent(e.ColumnIndex, e.RowIndex);
            }       
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

        /*String radioButtonString(RadioButton andRadioButton, RadioButton orRadioButton)
        {
            if (andRadioButton.Checked)
            {
                return "AND";
            }
            else
            {
                if (orRadioButton.Checked)
                {
                    return "OR";
                }
                else return "";
            }
        }*/

        private void addFilter(int lastTabId, bool isOr, String field, String condition, String value)
        {
            MainController controller = MainController.get();
            string finalWhereClause = "";
            if (field.ToUpper().Contains("DATE") || field.ToUpper().Contains("NUM") ||
                field.ToUpper().Contains("DEBIT") || field.ToUpper().Contains("CREDIT"))
            {
                finalWhereClause = controller.simpleFilterController.NumericOrDateSimpleFilter(field, condition, value);
            }
            else
            {
                finalWhereClause = controller.simpleFilterController.TextSimpleFilter(field, condition, value);
            }
            if (isOr)
            {
                controller.dataBaseController.AddFilterOr(finalWhereClause, lastTabId);
            }
            else
            {
                controller.dataBaseController.AddFilterAdd(finalWhereClause);
            }
        }

        private void reinitializeFilterForm()
        {
            andRadioButton1.Checked = false;
            orRadioButton1.Checked = false;
            andRadioButton2.Checked = false;
            orRadioButton2.Checked = false;
            andRadioButton3.Checked = false;
            orRadioButton3.Checked = false;
            field1ComboBox.Text = "";
            condition1ComboBox.Text = "";
            value1TextBox.Text = "";
            field2ComboBox.Text = "";
            condition2ComboBox.Text = "";
            value2TextBox.Text = "";
            field3ComboBox.Text = "";
            condition3ComboBox.Text = "";
            value3TextBox.Text = "";
            field4ComboBox.Text = "";
            condition4ComboBox.Text = "";
            value4TextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainController controller = MainController.get();
            int filterIdOfLastTab = controller.getDataBaseController().getLastFilterId();
            addFilter(filterIdOfLastTab, false, field1ComboBox.SelectedItem.ToString(), condition1ComboBox.SelectedItem.ToString(), value1TextBox.Text);
            if (andRadioButton1.Checked)
            {
                addFilter(filterIdOfLastTab, false, field2ComboBox.SelectedItem.ToString(), condition2ComboBox.SelectedItem.ToString(), value2TextBox.Text);
            }
            else if (orRadioButton1.Checked)
            {
                addFilter(filterIdOfLastTab, true, field2ComboBox.SelectedItem.ToString(), condition2ComboBox.SelectedItem.ToString(), value2TextBox.Text);
            }
            if (andRadioButton2.Checked)
            {
                addFilter(filterIdOfLastTab, false, field3ComboBox.SelectedItem.ToString(), condition3ComboBox.SelectedItem.ToString(), value3TextBox.Text);
            }
            else if (orRadioButton2.Checked)
            {
                addFilter(filterIdOfLastTab, true, field3ComboBox.SelectedItem.ToString(), condition3ComboBox.SelectedItem.ToString(), value3TextBox.Text);
            }
            if (andRadioButton3.Checked)
            {
                addFilter(filterIdOfLastTab, false, field4ComboBox.SelectedItem.ToString(), condition4ComboBox.SelectedItem.ToString(), value4TextBox.Text);
            }
            else if (orRadioButton3.Checked)
            {
                addFilter(filterIdOfLastTab, true, field4ComboBox.SelectedItem.ToString(), condition4ComboBox.SelectedItem.ToString(), value4TextBox.Text);
            }
            reinitializeFilterForm();
            string title = "tabPage" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            DataGridViewBDD newDataGridView = new DataGridViewBDD(controller.getDataBaseController().getLastFilterId());
            newDataGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(dataGridView1_CellValueNeeded);
            newDataGridView.Size = dataGridView1.Size;
            MainController.get().openFilter(newDataGridView);
            myTabPage.Controls.Add(newDataGridView);
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
            panel1.Visible = false;
        }
    }
}
