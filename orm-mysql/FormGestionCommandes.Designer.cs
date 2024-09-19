namespace orm_mysql
{
    partial class FormGestionCommandes
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
            txt_montant = new TextBox();
            Montant = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            cbClients = new ComboBox();
            label2 = new Label();
            btnValider = new Button();
            btnAnnuler = new Button();
            btnFermer = new Button();
            bsGestion = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsGestion).BeginInit();
            SuspendLayout();
            // 
            // txt_montant
            // 
            txt_montant.Location = new Point(113, 133);
            txt_montant.Name = "txt_montant";
            txt_montant.Size = new Size(100, 23);
            txt_montant.TabIndex = 0;
            // 
            // Montant
            // 
            Montant.AutoSize = true;
            Montant.Location = new Point(113, 104);
            Montant.Name = "Montant";
            Montant.Size = new Size(53, 15);
            Montant.TabIndex = 1;
            Montant.Text = "Montant";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(310, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 104);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Date";
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(560, 134);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(121, 23);
            cbClients.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 104);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Clients";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(404, 285);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 6;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(277, 285);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 7;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(50, 34);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(75, 23);
            btnFermer.TabIndex = 8;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // FormGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFermer);
            Controls.Add(btnAnnuler);
            Controls.Add(btnValider);
            Controls.Add(label2);
            Controls.Add(cbClients);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Montant);
            Controls.Add(txt_montant);
            Name = "FormGestionCommandes";
            Text = "FormGestionCommandes";
            Load += FormGestionCommandes_Load;
            ((System.ComponentModel.ISupportInitialize)bsGestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_montant;
        private Label Montant;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox cbClients;
        private Label label2;
        private Button btnValider;
        private Button btnAnnuler;
        private Button btnFermer;
        private BindingSource bsGestion;
    }
}