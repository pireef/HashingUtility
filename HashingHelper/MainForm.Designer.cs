namespace HashingHelper
{
    partial class MainForm
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
            fileDialog = new OpenFileDialog();
            btnSelectFile = new Button();
            txtFile = new TextBox();
            btnHash = new Button();
            label1 = new Label();
            txtMD5 = new TextBox();
            label2 = new Label();
            txtSHA1 = new TextBox();
            label3 = new Label();
            txtsha256 = new TextBox();
            label4 = new Label();
            txtsha384 = new TextBox();
            label5 = new Label();
            txtsha512 = new TextBox();
            statusStrip1 = new StatusStrip();
            statusLbl = new ToolStripStatusLabel();
            statusPGBar = new ToolStripProgressBar();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // fileDialog
            // 
            fileDialog.FileName = "fileDialog";
            fileDialog.InitialDirectory = "C:/";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(526, 39);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(12, 39);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(508, 23);
            txtFile.TabIndex = 1;
            // 
            // btnHash
            // 
            btnHash.Location = new Point(607, 39);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(75, 23);
            btnHash.TabIndex = 2;
            btnHash.Text = "Hash";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 3;
            label1.Text = "MD5";
            // 
            // txtMD5
            // 
            txtMD5.Location = new Point(115, 84);
            txtMD5.Name = "txtMD5";
            txtMD5.ReadOnly = true;
            txtMD5.Size = new Size(567, 23);
            txtMD5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "SHA-1";
            // 
            // txtSHA1
            // 
            txtSHA1.Location = new Point(115, 116);
            txtSHA1.Name = "txtSHA1";
            txtSHA1.ReadOnly = true;
            txtSHA1.Size = new Size(567, 23);
            txtSHA1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "SHA-256";
            // 
            // txtsha256
            // 
            txtsha256.Location = new Point(115, 151);
            txtsha256.Name = "txtsha256";
            txtsha256.ReadOnly = true;
            txtsha256.Size = new Size(567, 23);
            txtsha256.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "SHA-384";
            // 
            // txtsha384
            // 
            txtsha384.Location = new Point(115, 188);
            txtsha384.Name = "txtsha384";
            txtsha384.ReadOnly = true;
            txtsha384.Size = new Size(567, 23);
            txtsha384.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 11;
            label5.Text = "SHA-512";
            // 
            // txtsha512
            // 
            txtsha512.Location = new Point(115, 220);
            txtsha512.Name = "txtsha512";
            txtsha512.ReadOnly = true;
            txtsha512.Size = new Size(567, 23);
            txtsha512.TabIndex = 12;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLbl, statusPGBar });
            statusStrip1.Location = new Point(0, 257);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(694, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(0, 17);
            // 
            // statusPGBar
            // 
            statusPGBar.Alignment = ToolStripItemAlignment.Right;
            statusPGBar.MarqueeAnimationSpeed = 10;
            statusPGBar.Name = "statusPGBar";
            statusPGBar.Size = new Size(100, 16);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(694, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 279);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(txtsha512);
            Controls.Add(label5);
            Controls.Add(txtsha384);
            Controls.Add(label4);
            Controls.Add(txtsha256);
            Controls.Add(label3);
            Controls.Add(txtSHA1);
            Controls.Add(label2);
            Controls.Add(txtMD5);
            Controls.Add(label1);
            Controls.Add(btnHash);
            Controls.Add(txtFile);
            Controls.Add(btnSelectFile);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Hasing Helper";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog fileDialog;
        private Button btnSelectFile;
        private TextBox txtFile;
        private Button btnHash;
        private Label label1;
        private TextBox txtMD5;
        private Label label2;
        private TextBox txtSHA1;
        private Label label3;
        private TextBox txtsha256;
        private Label label4;
        private TextBox txtsha384;
        private Label label5;
        private TextBox txtsha512;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLbl;
        private ToolStripProgressBar statusPGBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}