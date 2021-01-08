namespace Projet1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMeilleurCombinaison = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nomObjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidObjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valObjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioSacGlouton = new System.Windows.Forms.RadioButton();
            this.radioSacDynamique = new System.Windows.Forms.RadioButton();
            this.radioSacComplet = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Générer Objets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMeilleurCombinaison
            // 
            this.buttonMeilleurCombinaison.Location = new System.Drawing.Point(587, 193);
            this.buttonMeilleurCombinaison.Name = "buttonMeilleurCombinaison";
            this.buttonMeilleurCombinaison.Size = new System.Drawing.Size(123, 24);
            this.buttonMeilleurCombinaison.TabIndex = 2;
            this.buttonMeilleurCombinaison.Text = "Meilleur Combinaison";
            this.buttonMeilleurCombinaison.UseVisualStyleBackColor = true;
            this.buttonMeilleurCombinaison.Visible = false;
            this.buttonMeilleurCombinaison.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomObjet,
            this.poidObjet,
            this.valObjet});
            this.dataGridView2.Location = new System.Drawing.Point(815, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 265);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nomObjet
            // 
            this.nomObjet.HeaderText = "Nom Objet";
            this.nomObjet.Name = "nomObjet";
            // 
            // poidObjet
            // 
            this.poidObjet.HeaderText = "Poid";
            this.poidObjet.Name = "poidObjet";
            // 
            // valObjet
            // 
            this.valObjet.HeaderText = "Valeur";
            this.valObjet.Name = "valObjet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valeur Max Récupérée :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // radioSacGlouton
            // 
            this.radioSacGlouton.AutoSize = true;
            this.radioSacGlouton.Checked = true;
            this.radioSacGlouton.Location = new System.Drawing.Point(587, 283);
            this.radioSacGlouton.Name = "radioSacGlouton";
            this.radioSacGlouton.Size = new System.Drawing.Size(84, 17);
            this.radioSacGlouton.TabIndex = 27;
            this.radioSacGlouton.TabStop = true;
            this.radioSacGlouton.Text = "Sac Glouton";
            this.radioSacGlouton.UseVisualStyleBackColor = true;
            // 
            // radioSacDynamique
            // 
            this.radioSacDynamique.AutoSize = true;
            this.radioSacDynamique.Location = new System.Drawing.Point(587, 306);
            this.radioSacDynamique.Name = "radioSacDynamique";
            this.radioSacDynamique.Size = new System.Drawing.Size(100, 17);
            this.radioSacDynamique.TabIndex = 28;
            this.radioSacDynamique.Text = "Sac Dynamique";
            this.radioSacDynamique.UseVisualStyleBackColor = true;
            // 
            // radioSacComplet
            // 
            this.radioSacComplet.AutoSize = true;
            this.radioSacComplet.Location = new System.Drawing.Point(587, 329);
            this.radioSacComplet.Name = "radioSacComplet";
            this.radioSacComplet.Size = new System.Drawing.Size(85, 17);
            this.radioSacComplet.TabIndex = 29;
            this.radioSacComplet.Text = "Sac Complet";
            this.radioSacComplet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1352, 429);
            this.Controls.Add(this.radioSacComplet);
            this.Controls.Add(this.radioSacDynamique);
            this.Controls.Add(this.radioSacGlouton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonMeilleurCombinaison);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMeilleurCombinaison;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomObjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidObjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn valObjet;
        private System.Windows.Forms.RadioButton radioSacGlouton;
        private System.Windows.Forms.RadioButton radioSacDynamique;
        private System.Windows.Forms.RadioButton radioSacComplet;
    }
}

