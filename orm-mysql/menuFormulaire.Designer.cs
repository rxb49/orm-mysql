namespace orm_mysql
{
    partial class menuFormulaire
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            listeClientToolStripMenuItem = new ToolStripMenuItem();
            listeCommandeToolStripMenuItem = new ToolStripMenuItem();
            listeStyleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeClientToolStripMenuItem, listeCommandeToolStripMenuItem, listeStyleToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "menu";
            // 
            // listeClientToolStripMenuItem
            // 
            listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            listeClientToolStripMenuItem.Size = new Size(180, 22);
            listeClientToolStripMenuItem.Text = "liste Client";
            listeClientToolStripMenuItem.Click += listeClientToolStripMenuItem_Click;
            // 
            // listeCommandeToolStripMenuItem
            // 
            listeCommandeToolStripMenuItem.Name = "listeCommandeToolStripMenuItem";
            listeCommandeToolStripMenuItem.Size = new Size(180, 22);
            listeCommandeToolStripMenuItem.Text = "liste Commande";
            listeCommandeToolStripMenuItem.Click += listeCommandeToolStripMenuItem_Click;
            // 
            // listeStyleToolStripMenuItem
            // 
            listeStyleToolStripMenuItem.Name = "listeStyleToolStripMenuItem";
            listeStyleToolStripMenuItem.Size = new Size(180, 22);
            listeStyleToolStripMenuItem.Text = "liste Style";
            listeStyleToolStripMenuItem.Click += listeStyleToolStripMenuItem_Click;
            // 
            // menuFormulaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "menuFormulaire";
            Text = "menuFormulaire";
            Load += menuFormulaire_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem listeClientToolStripMenuItem;
        private ToolStripMenuItem listeCommandeToolStripMenuItem;
        private ToolStripMenuItem listeStyleToolStripMenuItem;
    }
}