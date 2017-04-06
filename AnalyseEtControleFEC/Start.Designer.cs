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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
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
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // ouvrirFECToolStripMenuItem
            // 
            this.ouvrirFECToolStripMenuItem.Name = "ouvrirFECToolStripMenuItem";
            this.ouvrirFECToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ouvrirFECToolStripMenuItem.Text = "Ouvrir FEC";
            this.ouvrirFECToolStripMenuItem.Click += new System.EventHandler(this.ouvrirFECToolStripMenuItem_Click);
            // 
            // fermerFECToolStripMenuItem
            // 
            this.fermerFECToolStripMenuItem.Name = "fermerFECToolStripMenuItem";
            this.fermerFECToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fermerFECToolStripMenuItem.Text = "Fermer FEC";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
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
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // afficherLesÉcrituresToolStripMenuItem
            // 
            this.afficherLesÉcrituresToolStripMenuItem.Name = "afficherLesÉcrituresToolStripMenuItem";
            this.afficherLesÉcrituresToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.afficherLesÉcrituresToolStripMenuItem.Text = "Afficher les écritures";
            // 
            // copierLaSélectionToolStripMenuItem
            // 
            this.copierLaSélectionToolStripMenuItem.Name = "copierLaSélectionToolStripMenuItem";
            this.copierLaSélectionToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.copierLaSélectionToolStripMenuItem.Text = "Copier la sélection";
            // 
            // exporterLaSélectionToolStripMenuItem
            // 
            this.exporterLaSélectionToolStripMenuItem.Name = "exporterLaSélectionToolStripMenuItem";
            this.exporterLaSélectionToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exporterLaSélectionToolStripMenuItem.Text = "Exporter la sélection";
            // 
            // sauvegarderLeFiltreSimpleToolStripMenuItem
            // 
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Name = "sauvegarderLeFiltreSimpleToolStripMenuItem";
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Text = "Sauvegarder le filtre simple";
            this.sauvegarderLeFiltreSimpleToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLeFiltreSimpleToolStripMenuItem_Click);
            // 
            // sauvegarderLeFiltreÉlaboréToolStripMenuItem
            // 
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem.Name = "sauvegarderLeFiltreÉlaboréToolStripMenuItem";
            this.sauvegarderLeFiltreÉlaboréToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
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
            this.analyseToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.analyseToolStripMenuItem.Text = "Analyse";
            // 
            // filtrerToolStripMenuItem
            // 
            this.filtrerToolStripMenuItem.Name = "filtrerToolStripMenuItem";
            this.filtrerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.filtrerToolStripMenuItem.Text = "Filtrer";
            // 
            // trierToolStripMenuItem
            // 
            this.trierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesFiltresSimplesToolStripMenuItem,
            this.mesFiltresÉlaborésToolStripMenuItem});
            this.trierToolStripMenuItem.Name = "trierToolStripMenuItem";
            this.trierToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.trierToolStripMenuItem.Text = "Trier";
            // 
            // mesFiltresSimplesToolStripMenuItem
            // 
            this.mesFiltresSimplesToolStripMenuItem.Name = "mesFiltresSimplesToolStripMenuItem";
            this.mesFiltresSimplesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mesFiltresSimplesToolStripMenuItem.Text = "Mes filtres simples";
            // 
            // mesFiltresÉlaborésToolStripMenuItem
            // 
            this.mesFiltresÉlaborésToolStripMenuItem.Name = "mesFiltresÉlaborésToolStripMenuItem";
            this.mesFiltresÉlaborésToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mesFiltresÉlaborésToolStripMenuItem.Text = "Mes filtres élaborés";
            // 
            // sélectionnerToolStripMenuItem
            // 
            this.sélectionnerToolStripMenuItem.Name = "sélectionnerToolStripMenuItem";
            this.sélectionnerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sélectionnerToolStripMenuItem.Text = "Sélectionner";
            // 
            // analyserToolStripMenuItem
            // 
            this.analyserToolStripMenuItem.Name = "analyserToolStripMenuItem";
            this.analyserToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.analyserToolStripMenuItem.Text = "Analyser";
            // 
            // declarationsToolStripMenuItem
            // 
            this.declarationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilanToolStripMenuItem,
            this.compteDeRésultatToolStripMenuItem,
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem});
            this.declarationsToolStripMenuItem.Name = "declarationsToolStripMenuItem";
            this.declarationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.declarationsToolStripMenuItem.Text = "Declarations";
            // 
            // bilanToolStripMenuItem
            // 
            this.bilanToolStripMenuItem.Name = "bilanToolStripMenuItem";
            this.bilanToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.bilanToolStripMenuItem.Text = "Bilan";
            // 
            // compteDeRésultatToolStripMenuItem
            // 
            this.compteDeRésultatToolStripMenuItem.Name = "compteDeRésultatToolStripMenuItem";
            this.compteDeRésultatToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.compteDeRésultatToolStripMenuItem.Text = "Compte de résultat";
            // 
            // déterminationDeLaValeurAjoutéeToolStripMenuItem
            // 
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem.Name = "déterminationDeLaValeurAjoutéeToolStripMenuItem";
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.déterminationDeLaValeurAjoutéeToolStripMenuItem.Text = "Détermination de la Valeur Ajoutée";
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem});
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.parametresToolStripMenuItem.Text = "Parametres";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationUtilisateurToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // documentationUtilisateurToolStripMenuItem
            // 
            this.documentationUtilisateurToolStripMenuItem.Name = "documentationUtilisateurToolStripMenuItem";
            this.documentationUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.documentationUtilisateurToolStripMenuItem.Text = "documentation utilisateur";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.versionToolStripMenuItem.Text = "version";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(9, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 153);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(68, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "EcritureDate";
            this.toolTip1.SetToolTip(this.button3, "Filtrer");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 75);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "Piece  Date";
            this.toolTip1.SetToolTip(this.button4, "Filtrer");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(67, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Compte Num";
            this.toolTip1.SetToolTip(this.button2, "Filtrer");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Journal Code";
            this.toolTip1.SetToolTip(this.button1, "Filtrer");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(730, 479);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(898, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Start";
            this.Text = "mi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}

