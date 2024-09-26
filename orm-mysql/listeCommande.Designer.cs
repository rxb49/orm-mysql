namespace orm_mysql
{
    partial class listeCommande
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
            components = new System.ComponentModel.Container();
            bsCommande = new BindingSource(components);
            dgvCommande = new DataGridView();
            btn_return = new Button();
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            btn_afficherTout = new Button();
            label1 = new Label();
            nmMontant = new NumericUpDown();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmMontant).BeginInit();
            SuspendLayout();
            // 
            // dgvCommande
            // 
            dgvCommande.AllowUserToAddRows = false;
            dgvCommande.AllowUserToDeleteRows = false;
            dgvCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommande.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommande.Location = new Point(177, 79);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.Size = new Size(445, 272);
            dgvCommande.TabIndex = 0;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(63, 30);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(75, 23);
            btn_return.TabIndex = 1;
            btn_return.Text = "fermer";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // cbClients
            // 
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(655, 100);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(121, 23);
            cbClients.TabIndex = 2;
            // 
            // bsClients2
            // 
            bsClients2.CurrentChanged += bsClients2_CurrentChanged;
            // 
            // btn_afficherTout
            // 
            btn_afficherTout.Location = new Point(654, 48);
            btn_afficherTout.Name = "btn_afficherTout";
            btn_afficherTout.Size = new Size(122, 23);
            btn_afficherTout.TabIndex = 3;
            btn_afficherTout.Text = "Afficher tout";
            btn_afficherTout.UseVisualStyleBackColor = true;
            btn_afficherTout.Click += btn_afficherTout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(658, 135);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 5;
            label1.Text = "Montant minimum :";
            // 
            // nmMontant
            // 
            nmMontant.Location = new Point(656, 176);
            nmMontant.Name = "nmMontant";
            nmMontant.Size = new Size(120, 23);
            nmMontant.TabIndex = 6;
            nmMontant.ValueChanged += nmMontant_ValueChanged;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(660, 273);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(113, 23);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "AJOUTER";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(660, 317);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(113, 23);
            btnModifier.TabIndex = 8;
            btnModifier.Text = "MODIFIER";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(660, 361);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(113, 23);
            btnSupprimer.TabIndex = 9;
            btnSupprimer.Text = "SUPPRIMER";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // listeCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(nmMontant);
            Controls.Add(label1);
            Controls.Add(btn_afficherTout);
            Controls.Add(cbClients);
            Controls.Add(btn_return);
            Controls.Add(dgvCommande);
            Name = "listeCommande";
            Text = "listeCommande";
            Load += listeCommande_Load;
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmMontant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsCommande;
        private DataGridView dgvCommande;
        private Button btn_return;
        private ComboBox cbClients;
        private BindingSource bsClients2;
        private Button btn_afficherTout;
        private Label label1;
        private NumericUpDown nmMontant;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
    }
}