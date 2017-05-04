namespace Encryption
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criptareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playfairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adfgvxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homophonicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enigmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtNormal = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncrypt = new System.Windows.Forms.RichTextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criptareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criptareToolStripMenuItem
            // 
            this.criptareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greekToolStripMenuItem,
            this.caesarToolStripMenuItem,
            this.playfairToolStripMenuItem,
            this.adfgvxToolStripMenuItem,
            this.homophonicToolStripMenuItem,
            this.enigmaToolStripMenuItem,
            this.dESToolStripMenuItem});
            this.criptareToolStripMenuItem.Name = "criptareToolStripMenuItem";
            this.criptareToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.criptareToolStripMenuItem.Text = "Choose mode";
            // 
            // greekToolStripMenuItem
            // 
            this.greekToolStripMenuItem.Name = "greekToolStripMenuItem";
            this.greekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greekToolStripMenuItem.Text = "Greek";
            this.greekToolStripMenuItem.Click += new System.EventHandler(this.menuSelectEncrypt);
            // 
            // caesarToolStripMenuItem
            // 
            this.caesarToolStripMenuItem.Name = "caesarToolStripMenuItem";
            this.caesarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.caesarToolStripMenuItem.Text = "Caesar";
            this.caesarToolStripMenuItem.Click += new System.EventHandler(this.menuSelectEncrypt);
            // 
            // playfairToolStripMenuItem
            // 
            this.playfairToolStripMenuItem.Name = "playfairToolStripMenuItem";
            this.playfairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playfairToolStripMenuItem.Text = "Playfair";
            this.playfairToolStripMenuItem.Click += new System.EventHandler(this.menuSelectEncrypt);
            // 
            // adfgvxToolStripMenuItem
            // 
            this.adfgvxToolStripMenuItem.Name = "adfgvxToolStripMenuItem";
            this.adfgvxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adfgvxToolStripMenuItem.Text = "ADFGVX";
            this.adfgvxToolStripMenuItem.Click += new System.EventHandler(this.menuSelectEncrypt);
            // 
            // homophonicToolStripMenuItem
            // 
            this.homophonicToolStripMenuItem.Name = "homophonicToolStripMenuItem";
            this.homophonicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homophonicToolStripMenuItem.Text = "Homophonic";
            this.homophonicToolStripMenuItem.Click += new System.EventHandler(this.menuSelectEncrypt);
            // 
            // enigmaToolStripMenuItem
            // 
            this.enigmaToolStripMenuItem.Name = "enigmaToolStripMenuItem";
            this.enigmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enigmaToolStripMenuItem.Text = "Enigma";
            this.enigmaToolStripMenuItem.Click += new System.EventHandler(this.menuSelectEncrypt);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtNormal);
            this.splitContainer1.Panel1.Controls.Add(this.btnEncrypt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtEncrypt);
            this.splitContainer1.Panel2.Controls.Add(this.btnDecrypt);
            this.splitContainer1.Size = new System.Drawing.Size(715, 565);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtNormal
            // 
            this.txtNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNormal.Location = new System.Drawing.Point(12, 13);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(591, 215);
            this.txtNormal.TabIndex = 1;
            this.txtNormal.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Location = new System.Drawing.Point(609, 3);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(103, 37);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncrypt.Location = new System.Drawing.Point(15, 12);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(591, 295);
            this.txtEncrypt.TabIndex = 1;
            this.txtEncrypt.Text = "";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Location = new System.Drawing.Point(612, 3);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(103, 37);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // dESToolStripMenuItem
            // 
            this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            this.dESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dESToolStripMenuItem.Text = "DES";
            this.dESToolStripMenuItem.Click += new System.EventHandler(this.menuSelectEncrypt);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 589);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criptareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caesarToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox txtNormal;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RichTextBox txtEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ToolStripMenuItem adfgvxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playfairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homophonicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enigmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
    }
}

