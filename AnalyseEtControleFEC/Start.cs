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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
            e.Value = controller.dataBaseController.getContentFromFilter(e.ColumnIndex,e.RowIndex);
        }

        internal DataGridView getDataGridView()
        {
            return dataGridView1;
        }
    }
}
