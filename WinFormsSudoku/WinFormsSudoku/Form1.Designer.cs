namespace WinFormsSudoku
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.rightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.rightLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(534, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCtrlOToolStripMenuItem,
            this.saveCtrlSToolStripMenuItem,
            this.resetCtrlRToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCtrlOToolStripMenuItem
            // 
            this.openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            this.openCtrlOToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openCtrlOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openCtrlOToolStripMenuItem.Text = "Open";
            this.openCtrlOToolStripMenuItem.Click += new System.EventHandler(this.openCtrlOToolStripMenuItem_Click);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveCtrlSToolStripMenuItem.Text = "Save";
            this.saveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.saveCtrlSToolStripMenuItem_Click);
            // 
            // resetCtrlRToolStripMenuItem
            // 
            this.resetCtrlRToolStripMenuItem.Name = "resetCtrlRToolStripMenuItem";
            this.resetCtrlRToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.resetCtrlRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetCtrlRToolStripMenuItem.Text = "Reset";
            this.resetCtrlRToolStripMenuItem.Click += new System.EventHandler(this.resetCtrlRToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonLayoutPanel);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightLayoutPanel);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(534, 338);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.ColumnCount = 4;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.Controls.Add(this.button1, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.button2, 1, 0);
            this.buttonLayoutPanel.Controls.Add(this.button3, 2, 0);
            this.buttonLayoutPanel.Controls.Add(this.button4, 3, 0);
            this.buttonLayoutPanel.Controls.Add(this.button5, 0, 1);
            this.buttonLayoutPanel.Controls.Add(this.button6, 1, 1);
            this.buttonLayoutPanel.Controls.Add(this.button7, 2, 1);
            this.buttonLayoutPanel.Controls.Add(this.button8, 3, 1);
            this.buttonLayoutPanel.Controls.Add(this.button9, 0, 2);
            this.buttonLayoutPanel.Controls.Add(this.button10, 1, 2);
            this.buttonLayoutPanel.Controls.Add(this.button11, 2, 2);
            this.buttonLayoutPanel.Controls.Add(this.button12, 3, 2);
            this.buttonLayoutPanel.Controls.Add(this.button13, 0, 3);
            this.buttonLayoutPanel.Controls.Add(this.button14, 1, 3);
            this.buttonLayoutPanel.Controls.Add(this.button15, 2, 3);
            this.buttonLayoutPanel.Controls.Add(this.button16, 3, 3);
            this.buttonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 4;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(400, 338);
            this.buttonLayoutPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(103, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 78);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(203, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 78);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(303, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 78);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 78);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(103, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 78);
            this.button6.TabIndex = 4;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(203, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 78);
            this.button7.TabIndex = 5;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(303, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 78);
            this.button8.TabIndex = 6;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(3, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 78);
            this.button9.TabIndex = 7;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(103, 171);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 78);
            this.button10.TabIndex = 8;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(203, 171);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 78);
            this.button11.TabIndex = 9;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(303, 171);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 78);
            this.button12.TabIndex = 10;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(3, 255);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 80);
            this.button13.TabIndex = 11;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Location = new System.Drawing.Point(103, 255);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 80);
            this.button14.TabIndex = 12;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Click);
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(203, 255);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 80);
            this.button15.TabIndex = 13;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_Click);
            this.button15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(303, 255);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(94, 80);
            this.button16.TabIndex = 14;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Click);
            this.button16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // rightLayoutPanel
            // 
            this.rightLayoutPanel.ColumnCount = 1;
            this.rightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayoutPanel.Controls.Add(this.numericUpDown1, 0, 2);
            this.rightLayoutPanel.Controls.Add(this.settingsLabel, 0, 0);
            this.rightLayoutPanel.Controls.Add(this.fontLabel, 0, 1);
            this.rightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rightLayoutPanel.Name = "rightLayoutPanel";
            this.rightLayoutPanel.RowCount = 4;
            this.rightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayoutPanel.Size = new System.Drawing.Size(130, 338);
            this.rightLayoutPanel.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Location = new System.Drawing.Point(33, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(42, 18);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(45, 13);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            // 
            // fontLabel
            // 
            this.fontLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(39, 68);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(52, 13);
            this.fontLabel.TabIndex = 1;
            this.fontLabel.Text = "Font size:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(81, 114);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = " ";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip2);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.rightLayoutPanel.ResumeLayout(false);
            this.rightLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetCtrlRToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TableLayoutPanel rightLayoutPanel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

