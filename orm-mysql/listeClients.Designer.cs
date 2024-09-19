namespace orm_mysql
{
    partial class listeClients
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            btn_return = new Button();
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(153, 78);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.Size = new Size(477, 266);
            dgvClients.TabIndex = 0;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(39, 28);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(75, 23);
            btn_return.TabIndex = 1;
            btn_return.Text = "fermer";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(668, 92);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(121, 23);
            cbClients.TabIndex = 2;
            // 
            // bsClients2
            // 
            // 
            // listeClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbClients);
            Controls.Add(btn_return);
            Controls.Add(dgvClients);
            Name = "listeClients";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private Button btn_return;
        private ComboBox cbClients;
        private BindingSource bsClients2;
    }
}
