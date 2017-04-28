using System;
using System.Windows.Forms;

namespace AnalyseEtControleFEC
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Par Ligne");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Selection", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Simple");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Élaboré");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Filtre", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tri");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirFECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerFECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesÉcrituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierLaSélectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterLaSélectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLeFiltreSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesFiltresSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesFiltresÉlaborésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declarationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteDeRésultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.analyseToolStripMenuItem,
            this.declarationsToolStripMenuItem,
            this.parametresToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirFECToolStripMenuItem,
            this.fermerFECToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // ouvrirFECToolStripMenuItem
            // 
            this.ouvrirFECToolStripMenuItem.Name = "ouvrirFECToolStripMenuItem";
            this.ouvrirFECToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.ouvrirFECToolStripMenuItem.Text = "Ouvrir FEC";
            this.ouvrirFECToolStripMenuItem.Click += new System.EventHandler(this.ouvrirFECToolStripMenuItem_Click);
            // 
            // fermerFECToolStripMenuItem
            // 
            this.fermerFECToolStripMenuItem.Name = "fermerFECToolStripMenuItem";
            this.fermerFECToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.fermerFECToolStripMenuItem.Text = "Fermer FEC";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLesÉcrituresToolStripMenuItem,
            this.copierLaSélectionToolStripMenuItem,
            this.exporterLaSélectionToolStripMenuItem,
            this.sauvegarderLeFiltreSimpleToolStripMenuItem,
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // afficherLesÉcrituresToolStripMenuItem
            // 
            this.afficherLesÉcrituresToolStripMenuItem.Name = "afficherLesÉcrituresToolStripMenuItem";
            this.afficherLesÉcrituresToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.afficherLesÉcrituresToolStripMenuItem.Text = "Afficher les écritures";
            // 
            // copierLaSélectionToolStripMenuItem
            // 
            this.copierLaSélectionToolStripMenuItem.Name = "copierLaSélectionToolStripMenuItem";
            this.copierLaSélectionToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.copierLaSélectionToolStripMenuItem.Text = "Copier la sélection";
            // 
            // exporterLaSélectionToolStripMenuItem
            // 
            this.exporterLaSélectionToolStripMenuItem.Name = "exporterLaSélectionToolStripMenuItem";
            this.exporterLaSélectionToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.exporterLaSélectionToolStripMenuItem.Text = "Exporter la sélection";
            // 
            // sauvegarderLeFiltreSimpleToolStripMenuItem
            // 
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Name = "sauvegarderLeFiltreSimpleToolStripMenuItem";
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Text = "Sauvegarder le filtre simple";
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLeFiltreSimpleToolStripMenuItem_Click);
            // 
            // sauvegarderLeFiltreÉlaboréToolStripMenuItem
            // 
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem.Name = "sauvegarderLeFiltreÉlaboréToolStripMenuItem";
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem.Text = "Sauvegarder le filtre élaboré";
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLeFiltreÉlaboréToolStripMenuItem_Click);
            // 
            // analyseToolStripMenuItem
            // 
            this.analyseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrerToolStripMenuItem,
            this.trierToolStripMenuItem,
            this.sélectionnerToolStripMenuItem,
            this.analyserToolStripMenuItem});
            this.analyseToolStripMenuItem.Name = "analyseToolStripMenuItem";
            this.analyseToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.analyseToolStripMenuItem.Text = "Analyse";
            // 
            // filtrerToolStripMenuItem
            // 
            this.filtrerToolStripMenuItem.Name = "filtrerToolStripMenuItem";
            this.filtrerToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.filtrerToolStripMenuItem.Text = "Filtrer";
            // 
            // trierToolStripMenuItem
            // 
            this.trierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesFiltresSimplesToolStripMenuItem,
            this.mesFiltresÉlaborésToolStripMenuItem});
            this.trierToolStripMenuItem.Name = "trierToolStripMenuItem";
            this.trierToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.trierToolStripMenuItem.Text = "Trier";
            // 
            // mesFiltresSimplesToolStripMenuItem
            // 
            this.mesFiltresSimplesToolStripMenuItem.Name = "mesFiltresSimplesToolStripMenuItem";
            this.mesFiltresSimplesToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.mesFiltresSimplesToolStripMenuItem.Text = "Mes filtres simples";
            // 
            // mesFiltresÉlaborésToolStripMenuItem
            // 
            this.mesFiltresÉlaborésToolStripMenuItem.Name = "mesFiltresÉlaborésToolStripMenuItem";
            this.mesFiltresÉlaborésToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.mesFiltresÉlaborésToolStripMenuItem.Text = "Mes filtres élaborés";
            // 
            // sélectionnerToolStripMenuItem
            // 
            this.sélectionnerToolStripMenuItem.Name = "sélectionnerToolStripMenuItem";
            this.sélectionnerToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.sélectionnerToolStripMenuItem.Text = "Sélectionner";
            // 
            // analyserToolStripMenuItem
            // 
            this.analyserToolStripMenuItem.Name = "analyserToolStripMenuItem";
            this.analyserToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.analyserToolStripMenuItem.Text = "Analyser";
            // 
            // declarationsToolStripMenuItem
            // 
            this.declarationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilanToolStripMenuItem,
            this.compteDeRésultatToolStripMenuItem,
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem});
            this.declarationsToolStripMenuItem.Name = "declarationsToolStripMenuItem";
            this.declarationsToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.declarationsToolStripMenuItem.Text = "Declarations";
            // 
            // bilanToolStripMenuItem
            // 
            this.bilanToolStripMenuItem.Name = "bilanToolStripMenuItem";
            this.bilanToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.bilanToolStripMenuItem.Text = "Bilan";
            // 
            // compteDeRésultatToolStripMenuItem
            // 
            this.compteDeRésultatToolStripMenuItem.Name = "compteDeRésultatToolStripMenuItem";
            this.compteDeRésultatToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.compteDeRésultatToolStripMenuItem.Text = "Compte de résultat";
            // 
            // déterminationDeLaValeurAjoutéeToolStripMenuItem
            // 
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem.Name = "déterminationDeLaValeurAjoutéeToolStripMenuItem";
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem.Text = "Détermination de la Valeur Ajoutée";
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem});
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.parametresToolStripMenuItem.Text = "Parametres";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationUtilisateurToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // documentationUtilisateurToolStripMenuItem
            // 
            this.documentationUtilisateurToolStripMenuItem.Name = "documentationUtilisateurToolStripMenuItem";
            this.documentationUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.documentationUtilisateurToolStripMenuItem.Text = "documentation utilisateur";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.versionToolStripMenuItem.Text = "version";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1800, 900);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(10, 40);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Par Ligne";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Selection";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Simple";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Élaboré";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Filtre";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Tri";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(266, 142);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox8);
            this.panel1.Controls.Add(this.comboBox7);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 477);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cacher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(531, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Filtrer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(66, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "OU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "ET";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton8);
            this.panel5.Controls.Add(this.radioButton7);
            this.panel5.Location = new System.Drawing.Point(4, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(103, 25);
            this.panel5.TabIndex = 18;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(62, 5);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(17, 16);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(19, 5);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(17, 16);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton6);
            this.panel4.Controls.Add(this.radioButton5);
            this.panel4.Location = new System.Drawing.Point(4, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 25);
            this.panel4.TabIndex = 17;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(62, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(17, 16);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(19, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(17, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Location = new System.Drawing.Point(4, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 25);
            this.panel3.TabIndex = 16;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(62, 6);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(493, 312);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 25);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(493, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 25);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(493, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 25);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 25);
            this.textBox1.TabIndex = 11;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(142, 314);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(138, 23);
            this.comboBox8.TabIndex = 10;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(142, 241);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(138, 23);
            this.comboBox7.TabIndex = 9;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(142, 168);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(138, 23);
            this.comboBox6.TabIndex = 8;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(142, 87);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(138, 23);
            this.comboBox5.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(325, 314);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(138, 23);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(325, 241);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(138, 23);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(325, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valeurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Condition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Champ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(200, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1810, 925);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1802, 896);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1802, 896);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1802, 896);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 688);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "output";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1682, 953);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "mi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declarationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerFECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesÉcrituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierLaSélectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterLaSélectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLeFiltreSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLeFiltreÉlaboréToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sélectionnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteDeRésultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déterminationDeLaValeurAjoutéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesFiltresSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesFiltresÉlaborésToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TreeView treeView1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Panel panel5;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Panel panel4;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private Panel panel3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox8;
        private ComboBox comboBox7;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button3;
    }
}

