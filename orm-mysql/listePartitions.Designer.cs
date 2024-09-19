namespace orm_mysql
{
    partial class listePartitions
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
            dgvPartitions = new DataGridView();
            bsStyle = new BindingSource(components);
            cbPartitions = new ComboBox();
            bsStyle2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvPartitions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle2).BeginInit();
            SuspendLayout();
            // 
            // dgvPartitions
            // 
            dgvPartitions.AllowUserToAddRows = false;
            dgvPartitions.AllowUserToDeleteRows = false;
            dgvPartitions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPartitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartitions.Location = new Point(175, 101);
            dgvPartitions.Name = "dgvPartitions";
            dgvPartitions.Size = new Size(457, 261);
            dgvPartitions.TabIndex = 0;
            // 
            // cbPartitions
            // 
            cbPartitions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPartitions.FormattingEnabled = true;
            cbPartitions.Location = new Point(175, 42);
            cbPartitions.Name = "cbPartitions";
            cbPartitions.Size = new Size(121, 23);
            cbPartitions.TabIndex = 1;
            // 
            // bsStyle2
            // 
            bsStyle2.CurrentChanged += bsStyle2_CurrentChanged;
            // 
            // listePartitions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbPartitions);
            Controls.Add(dgvPartitions);
            Name = "listePartitions";
            Text = "listePartitions";
            Load += listeStyle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartitions).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPartitions;
        private BindingSource bsStyle;
        private ComboBox cbPartitions;
        private BindingSource bsStyle2;
    }
}