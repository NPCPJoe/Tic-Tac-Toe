namespace Tic_Tac_Toe
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.XWincount = new System.Windows.Forms.Label();
            this.DrawCount = new System.Windows.Forms.Label();
            this.Owincount = new System.Windows.Forms.Label();
            this.Xcount = new System.Windows.Forms.Label();
            this.Ocount = new System.Windows.Forms.Label();
            this.Dcount = new System.Windows.Forms.Label();
            this.resetCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A1.Location = new System.Drawing.Point(12, 43);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 2;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_click);
            this.A1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A3.Location = new System.Drawing.Point(174, 43);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_click);
            this.A3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A2.Location = new System.Drawing.Point(93, 43);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 4;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_click);
            this.A2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B3.Location = new System.Drawing.Point(174, 124);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_click);
            this.B3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B2.Location = new System.Drawing.Point(93, 124);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 6;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_click);
            this.B2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.b1.Location = new System.Drawing.Point(12, 124);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 7;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.Button_click);
            this.b1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.b1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C3.Location = new System.Drawing.Point(174, 205);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_click);
            this.C3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C2.Location = new System.Drawing.Point(93, 205);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_click);
            this.C2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C1.Location = new System.Drawing.Point(12, 205);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 10;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_click);
            this.C1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // XWincount
            // 
            this.XWincount.AutoSize = true;
            this.XWincount.Location = new System.Drawing.Point(12, 307);
            this.XWincount.Name = "XWincount";
            this.XWincount.Size = new System.Drawing.Size(80, 17);
            this.XWincount.TabIndex = 11;
            this.XWincount.Text = "X win count";
            // 
            // DrawCount
            // 
            this.DrawCount.AutoSize = true;
            this.DrawCount.Location = new System.Drawing.Point(9, 378);
            this.DrawCount.Name = "DrawCount";
            this.DrawCount.Size = new System.Drawing.Size(79, 17);
            this.DrawCount.TabIndex = 12;
            this.DrawCount.Text = "Draw count";
            // 
            // Owincount
            // 
            this.Owincount.AutoSize = true;
            this.Owincount.Location = new System.Drawing.Point(12, 346);
            this.Owincount.Name = "Owincount";
            this.Owincount.Size = new System.Drawing.Size(82, 17);
            this.Owincount.TabIndex = 13;
            this.Owincount.Text = "O win count";
            // 
            // Xcount
            // 
            this.Xcount.AutoSize = true;
            this.Xcount.Location = new System.Drawing.Point(122, 307);
            this.Xcount.Name = "Xcount";
            this.Xcount.Size = new System.Drawing.Size(16, 17);
            this.Xcount.TabIndex = 14;
            this.Xcount.Text = "0";
            // 
            // Ocount
            // 
            this.Ocount.AutoSize = true;
            this.Ocount.Location = new System.Drawing.Point(122, 346);
            this.Ocount.Name = "Ocount";
            this.Ocount.Size = new System.Drawing.Size(16, 17);
            this.Ocount.TabIndex = 15;
            this.Ocount.Text = "0";
            // 
            // Dcount
            // 
            this.Dcount.AutoSize = true;
            this.Dcount.Location = new System.Drawing.Point(122, 378);
            this.Dcount.Name = "Dcount";
            this.Dcount.Size = new System.Drawing.Size(16, 17);
            this.Dcount.TabIndex = 16;
            this.Dcount.Text = "0";
            // 
            // resetCountsToolStripMenuItem
            // 
            this.resetCountsToolStripMenuItem.Name = "resetCountsToolStripMenuItem";
            this.resetCountsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.resetCountsToolStripMenuItem.Text = "Reset Counts";
            this.resetCountsToolStripMenuItem.Click += new System.EventHandler(this.resetCountsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 404);
            this.Controls.Add(this.Dcount);
            this.Controls.Add(this.Ocount);
            this.Controls.Add(this.Xcount);
            this.Controls.Add(this.Owincount);
            this.Controls.Add(this.DrawCount);
            this.Controls.Add(this.XWincount);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label XWincount;
        private System.Windows.Forms.Label DrawCount;
        private System.Windows.Forms.Label Owincount;
        private System.Windows.Forms.Label Xcount;
        private System.Windows.Forms.Label Ocount;
        private System.Windows.Forms.Label Dcount;
        private System.Windows.Forms.ToolStripMenuItem resetCountsToolStripMenuItem;
    }
}

