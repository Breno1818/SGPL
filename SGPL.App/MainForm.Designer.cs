namespace SGPL.App
{
    partial class MainForm
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
            ReaLTaiizor.ControlRenderer controlRenderer3 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable3 = new ReaLTaiizor.MSColorTable();
            formMenuStrip = new ReaLTaiizor.Controls.FormMenuStrip();
            registerToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem = new ToolStripMenuItem();
            feedToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            lblUser = new Label();
            formMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip
            // 
            formMenuStrip.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem, reportToolStripMenuItem, helpToolStripMenuItem, closeToolStripMenuItem });
            formMenuStrip.Location = new Point(3, 64);
            formMenuStrip.Name = "formMenuStrip";
            controlRenderer3.ColorTable = msColorTable3;
            controlRenderer3.RoundedEdges = true;
            formMenuStrip.Renderer = controlRenderer3;
            formMenuStrip.Size = new Size(794, 24);
            formMenuStrip.TabIndex = 0;
            formMenuStrip.Text = "formMenuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, animalToolStripMenuItem, feedToolStripMenuItem, productionToolStripMenuItem, saleToolStripMenuItem });
            registerToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(133, 22);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // animalToolStripMenuItem
            // 
            animalToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            animalToolStripMenuItem.Size = new Size(133, 22);
            animalToolStripMenuItem.Text = "Animal";
            animalToolStripMenuItem.Click += animalToolStripMenuItem_Click;
            // 
            // feedToolStripMenuItem
            // 
            feedToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            feedToolStripMenuItem.Size = new Size(133, 22);
            feedToolStripMenuItem.Text = "Feed";
            feedToolStripMenuItem.Click += feedToolStripMenuItem_Click;
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(133, 22);
            productionToolStripMenuItem.Text = "Production";
            productionToolStripMenuItem.Click += productionToolStripMenuItem_Click;
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(133, 22);
            saleToolStripMenuItem.Text = "Sale";
            saleToolStripMenuItem.Click += saleToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(54, 20);
            reportToolStripMenuItem.Text = "Report";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(48, 20);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Bottom;
            lblUser.Location = new Point(3, 432);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(33, 15);
            lblUser.TabIndex = 4;
            lblUser.Text = "User:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUser);
            Controls.Add(formMenuStrip);
            MainMenuStrip = formMenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGPL";
            formMenuStrip.ResumeLayout(false);
            formMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem feedToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label lblUser;
    }
}