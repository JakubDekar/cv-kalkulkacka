﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(952, 527);
            this.splitContainer1.SplitterDistance = 559;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 523);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "History";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.additionButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.decimalButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.changeSignButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.zeroButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.equalsButton, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.substractionButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.threeButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.twoButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.oneButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplicationButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.fiveButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fourButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sevenButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eightButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nineButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.divisionButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 523);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 5);
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(3, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sevenButton
            // 
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sevenButton.Location = new System.Drawing.Point(5, 109);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(5);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(101, 94);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // eightButton
            // 
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eightButton.Location = new System.Drawing.Point(116, 109);
            this.eightButton.Margin = new System.Windows.Forms.Padding(5);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(101, 94);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nineButton
            // 
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nineButton.Location = new System.Drawing.Point(227, 109);
            this.nineButton.Margin = new System.Windows.Forms.Padding(5);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(101, 94);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divisionButton.Location = new System.Drawing.Point(338, 109);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(5);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(101, 94);
            this.divisionButton.TabIndex = 4;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(449, 109);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.tableLayoutPanel1.SetRowSpan(this.clearButton, 2);
            this.clearButton.Size = new System.Drawing.Size(101, 198);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // fourButton
            // 
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fourButton.Location = new System.Drawing.Point(5, 213);
            this.fourButton.Margin = new System.Windows.Forms.Padding(5);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(101, 94);
            this.fourButton.TabIndex = 6;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fiveButton.Location = new System.Drawing.Point(116, 213);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(5);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(101, 94);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // sixButton
            // 
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sixButton.Location = new System.Drawing.Point(227, 213);
            this.sixButton.Margin = new System.Windows.Forms.Padding(5);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(101, 94);
            this.sixButton.TabIndex = 8;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplicationButton.Location = new System.Drawing.Point(338, 213);
            this.multiplicationButton.Margin = new System.Windows.Forms.Padding(5);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(101, 94);
            this.multiplicationButton.TabIndex = 9;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // oneButton
            // 
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneButton.Location = new System.Drawing.Point(5, 317);
            this.oneButton.Margin = new System.Windows.Forms.Padding(5);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(101, 94);
            this.oneButton.TabIndex = 11;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // twoButton
            // 
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twoButton.Location = new System.Drawing.Point(116, 317);
            this.twoButton.Margin = new System.Windows.Forms.Padding(5);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(101, 94);
            this.twoButton.TabIndex = 12;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.button12_Click);
            // 
            // threeButton
            // 
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.threeButton.Location = new System.Drawing.Point(227, 317);
            this.threeButton.Margin = new System.Windows.Forms.Padding(5);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(101, 94);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // substractionButton
            // 
            this.substractionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.substractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.substractionButton.Location = new System.Drawing.Point(338, 317);
            this.substractionButton.Margin = new System.Windows.Forms.Padding(5);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(101, 94);
            this.substractionButton.TabIndex = 14;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalsButton.Location = new System.Drawing.Point(449, 317);
            this.equalsButton.Margin = new System.Windows.Forms.Padding(5);
            this.equalsButton.Name = "equalsButton";
            this.tableLayoutPanel1.SetRowSpan(this.equalsButton, 2);
            this.equalsButton.Size = new System.Drawing.Size(101, 201);
            this.equalsButton.TabIndex = 15;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.button15_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zeroButton.Location = new System.Drawing.Point(5, 421);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(5);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(101, 97);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.button16_Click);
            // 
            // changeSignButton
            // 
            this.changeSignButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeSignButton.Location = new System.Drawing.Point(116, 421);
            this.changeSignButton.Margin = new System.Windows.Forms.Padding(5);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(101, 97);
            this.changeSignButton.TabIndex = 17;
            this.changeSignButton.Text = "+/-";
            this.changeSignButton.UseVisualStyleBackColor = true;
            this.changeSignButton.Click += new System.EventHandler(this.button17_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decimalButton.Location = new System.Drawing.Point(227, 421);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(5);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(101, 97);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.button18_Click);
            // 
            // additionButton
            // 
            this.additionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.additionButton.Location = new System.Drawing.Point(338, 421);
            this.additionButton.Margin = new System.Windows.Forms.Padding(5);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(101, 97);
            this.additionButton.TabIndex = 19;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.button19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 527);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
    }
}

