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
    }
}
