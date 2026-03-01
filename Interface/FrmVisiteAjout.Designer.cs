namespace Interface
{
    partial class FrmVisiteAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteAjout));
            this.lblVisiteur = new Label();
            this.panel3 = new Panel();
            this.cbxPraticien = new ComboBox();
            this.label4 = new Label();
            this.cbxMotif = new ComboBox();
            this.btnAjouter = new Button();
            this.label2 = new Label();
            this.label6 = new Label();
            this.label3 = new Label();
            this.dtpDate = new DateTimePicker();
            this.label5 = new Label();
            this.dgvVisites = new DataGridView();
            this.panelDroite = new Panel();
            this.panelGauche = new Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvVisites).BeginInit();
            this.panelDroite.SuspendLayout();
            this.panelGauche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new Padding(4, 0, 4, 0);
            this.lblTitre.Size = new Size(1358, 75);
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.Dock = DockStyle.Fill;
            this.lblVisiteur.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblVisiteur.Location = new Point(0, 0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new Size(1472, 47);
            this.lblVisiteur.TabIndex = 1;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbxPraticien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbxMotif);
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Location = new Point(22, 99);
            this.panel3.Margin = new Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(506, 522);
            this.panel3.TabIndex = 14;
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cbxPraticien.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cbxPraticien.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxPraticien.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new Point(169, 103);
            this.cbxPraticien.Margin = new Padding(4, 5, 4, 5);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new Size(327, 32);
            this.cbxPraticien.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(26, 32);
            this.label4.Name = "label4";
            this.label4.Size = new Size(355, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nouveau rendez vous";
            // 
            // cbxMotif
            // 
            this.cbxMotif.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cbxMotif.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cbxMotif.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new Point(169, 188);
            this.cbxMotif.Margin = new Padding(4, 5, 4, 5);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new Size(327, 32);
            this.cbxMotif.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = Color.Red;
            this.btnAjouter.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAjouter.Location = new Point(191, 392);
            this.btnAjouter.Margin = new Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new Size(243, 58);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += this.btnAjouter_Click;
            // 
            // label2
            // 
            this.label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new Size(91, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motif";
            // 
            // label6
            // 
            this.label6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(16, 278);
            this.label6.Name = "label6";
            this.label6.Size = new Size(148, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date et heure";
            // 
            // label3
            // 
            this.label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new Size(115, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Praticien";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dtpDate.Format = DateTimePickerFormat.Custom;
            this.dtpDate.Location = new Point(169, 274);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(327, 30);
            this.dtpDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = DockStyle.Top;
            this.label5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new Size(781, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "Liste des rendez-vous déjà enregistrés";
            // 
            // dgvVisites
            // 
            this.dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisites.Dock = DockStyle.Fill;
            this.dgvVisites.Location = new Point(10, 46);
            this.dgvVisites.Margin = new Padding(4, 5, 4, 5);
            this.dgvVisites.Name = "dgvVisites";
            this.dgvVisites.RowHeadersWidth = 51;
            this.dgvVisites.Size = new Size(781, 594);
            this.dgvVisites.TabIndex = 19;
            // 
            // panelDroite
            // 
            this.panelDroite.Controls.Add(this.panel3);
            this.panelDroite.Dock = DockStyle.Right;
            this.panelDroite.Location = new Point(801, 103);
            this.panelDroite.Name = "panelDroite";
            this.panelDroite.Size = new Size(557, 650);
            this.panelDroite.TabIndex = 23;
            // 
            // panelGauche
            // 
            this.panelGauche.Controls.Add(this.dgvVisites);
            this.panelGauche.Controls.Add(this.label5);
            this.panelGauche.Dock = DockStyle.Fill;
            this.panelGauche.Location = new Point(0, 103);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Padding = new Padding(10);
            this.panelGauche.Size = new Size(801, 650);
            this.panelGauche.TabIndex = 24;
            // 
            // FrmVisiteAjout
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1358, 813);
            this.Controls.Add(this.panelGauche);
            this.Controls.Add(this.panelDroite);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.KeyPreview = true;
            this.Margin = new Padding(3, 5, 3, 5);
            this.Name = "FrmVisiteAjout";
            this.Text = "Saisie d'une visite";
            Load += this.FmrSaisieVisite_Load;
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panelDroite, 0);
            this.Controls.SetChildIndex(this.panelGauche, 0);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvVisites).EndInit();
            this.panelDroite.ResumeLayout(false);
            this.panelGauche.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVisiteur;
        // private System.Windows.Forms.Panel panelSaisie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Label label5;
        private DataGridView dgvVisites;
        private Panel panelDroite;
        private Panel panelGauche;
    }
}