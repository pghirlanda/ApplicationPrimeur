namespace LogicielCaisse
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.importerPrixButton = new System.Windows.Forms.Button();
            this.nouveauPanierButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.terminerButton = new System.Windows.Forms.Button();
            this.validerButton = new System.Windows.Forms.Button();
            this.poidsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fichierLabel = new System.Windows.Forms.Label();
            this.produitComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.recapitulatifLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // importerPrixButton
            // 
            this.importerPrixButton.Location = new System.Drawing.Point(570, 58);
            this.importerPrixButton.Name = "importerPrixButton";
            this.importerPrixButton.Size = new System.Drawing.Size(189, 27);
            this.importerPrixButton.TabIndex = 0;
            this.importerPrixButton.Text = "Importer fichier prix au kilo";
            this.importerPrixButton.UseVisualStyleBackColor = true;
            this.importerPrixButton.Visible = false;
            this.importerPrixButton.Click += new System.EventHandler(this.importerPrixButton_Click);
            // 
            // nouveauPanierButton
            // 
            this.nouveauPanierButton.Location = new System.Drawing.Point(18, 124);
            this.nouveauPanierButton.Name = "nouveauPanierButton";
            this.nouveauPanierButton.Size = new System.Drawing.Size(284, 40);
            this.nouveauPanierButton.TabIndex = 1;
            this.nouveauPanierButton.Text = "Nouveau panier";
            this.nouveauPanierButton.UseVisualStyleBackColor = true;
            this.nouveauPanierButton.Click += new System.EventHandler(this.nouveauPanierButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // terminerButton
            // 
            this.terminerButton.Location = new System.Drawing.Point(497, 124);
            this.terminerButton.Name = "terminerButton";
            this.terminerButton.Size = new System.Drawing.Size(284, 40);
            this.terminerButton.TabIndex = 4;
            this.terminerButton.Text = "Terminer";
            this.terminerButton.UseVisualStyleBackColor = true;
            this.terminerButton.Click += new System.EventHandler(this.terminerButton_Click);
            // 
            // validerButton
            // 
            this.validerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerButton.Location = new System.Drawing.Point(348, 82);
            this.validerButton.Name = "validerButton";
            this.validerButton.Size = new System.Drawing.Size(83, 38);
            this.validerButton.TabIndex = 5;
            this.validerButton.Text = "Valider";
            this.validerButton.UseVisualStyleBackColor = true;
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // poidsTextBox
            // 
            this.poidsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poidsTextBox.Location = new System.Drawing.Point(219, 304);
            this.poidsTextBox.Name = "poidsTextBox";
            this.poidsTextBox.ReadOnly = true;
            this.poidsTextBox.Size = new System.Drawing.Size(121, 24);
            this.poidsTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entrez le poids de l\'article : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "(Rentrez les nombres à virgules avec , et non .)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fichier actuel des prix : ";
            // 
            // fichierLabel
            // 
            this.fichierLabel.AutoSize = true;
            this.fichierLabel.Location = new System.Drawing.Point(162, 26);
            this.fichierLabel.Name = "fichierLabel";
            this.fichierLabel.Size = new System.Drawing.Size(106, 17);
            this.fichierLabel.TabIndex = 10;
            this.fichierLabel.Text = "prixproduits.csv";
            // 
            // produitComboBox
            // 
            this.produitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitComboBox.FormattingEnabled = true;
            this.produitComboBox.Location = new System.Drawing.Point(221, 243);
            this.produitComboBox.Name = "produitComboBox";
            this.produitComboBox.Size = new System.Drawing.Size(121, 25);
            this.produitComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choisissez un article : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectionButton);
            this.groupBox1.Controls.Add(this.mdpTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nomTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fichierLabel);
            this.groupBox1.Controls.Add(this.importerPrixButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Réservé au personnel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.validerButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 194);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choix de l\'article à ajouter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Prix total :";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(202, 394);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 30);
            this.totalTextBox.TabIndex = 16;
            this.totalTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "€";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.recapitulatifLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(497, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 247);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Récapitulatif des produits";
            // 
            // recapitulatifLabel
            // 
            this.recapitulatifLabel.AutoSize = true;
            this.recapitulatifLabel.Location = new System.Drawing.Point(25, 47);
            this.recapitulatifLabel.Name = "recapitulatifLabel";
            this.recapitulatifLabel.Size = new System.Drawing.Size(0, 18);
            this.recapitulatifLabel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nom :";
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(57, 60);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mot de passe :";
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.Location = new System.Drawing.Point(274, 60);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(100, 22);
            this.mdpTextBox.TabIndex = 14;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(410, 58);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(123, 27);
            this.connectionButton.TabIndex = 15;
            this.connectionButton.Text = "Se connecter";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.terminerButton);
            this.Controls.Add(this.nouveauPanierButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.produitComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poidsTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Primeur de la côte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importerPrixButton;
        private System.Windows.Forms.Button nouveauPanierButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button terminerButton;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.TextBox poidsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fichierLabel;
        private System.Windows.Forms.ComboBox produitComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label recapitulatifLabel;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label label7;
    }
}

