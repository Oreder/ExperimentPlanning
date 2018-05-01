namespace Expert01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genBtn = new System.Windows.Forms.Button();
            this.bEdt = new System.Windows.Forms.TextBox();
            this.aEdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calulateBtn = new System.Windows.Forms.Button();
            this.b1Edt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.b3Edt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b2Edt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b0Edt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.s2Edt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.s1Edt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.varEdt = new System.Windows.Forms.TextBox();
            this.mEdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.AllowUserToAddRows = false;
            this.tab.AllowUserToDeleteRows = false;
            this.tab.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tab.ColumnHeadersHeight = 21;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.tab.Location = new System.Drawing.Point(3, 69);
            this.tab.Name = "tab";
            this.tab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tab.RowHeadersVisible = false;
            this.tab.RowHeadersWidth = 21;
            this.tab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tab.Size = new System.Drawing.Size(640, 145);
            this.tab.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Index";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "X0";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "X1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "X2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "X3 = X1.X2";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Y";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Y1";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "|Y1 - Y|";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 75;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Y2";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "|Y2 - Y|";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.varEdt);
            this.panel1.Controls.Add(this.mEdt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.genBtn);
            this.panel1.Controls.Add(this.bEdt);
            this.panel1.Controls.Add(this.aEdt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 63);
            this.panel1.TabIndex = 1;
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genBtn.Location = new System.Drawing.Point(181, 4);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(77, 54);
            this.genBtn.TabIndex = 2;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // bEdt
            // 
            this.bEdt.Location = new System.Drawing.Point(23, 35);
            this.bEdt.Name = "bEdt";
            this.bEdt.Size = new System.Drawing.Size(59, 20);
            this.bEdt.TabIndex = 1;
            this.bEdt.Text = "3";
            // 
            // aEdt
            // 
            this.aEdt.Location = new System.Drawing.Point(23, 9);
            this.aEdt.Name = "aEdt";
            this.aEdt.Size = new System.Drawing.Size(59, 20);
            this.aEdt.TabIndex = 1;
            this.aEdt.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.calulateBtn);
            this.panel2.Controls.Add(this.b1Edt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.b3Edt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.b2Edt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.b0Edt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(268, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 63);
            this.panel2.TabIndex = 2;
            // 
            // calulateBtn
            // 
            this.calulateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calulateBtn.Location = new System.Drawing.Point(181, 4);
            this.calulateBtn.Name = "calulateBtn";
            this.calulateBtn.Size = new System.Drawing.Size(72, 53);
            this.calulateBtn.TabIndex = 3;
            this.calulateBtn.Text = "Calculate";
            this.calulateBtn.UseVisualStyleBackColor = false;
            this.calulateBtn.Click += new System.EventHandler(this.calulateBtn_Click);
            // 
            // b1Edt
            // 
            this.b1Edt.Location = new System.Drawing.Point(119, 9);
            this.b1Edt.Name = "b1Edt";
            this.b1Edt.Size = new System.Drawing.Size(56, 20);
            this.b1Edt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "B1 = ";
            // 
            // b3Edt
            // 
            this.b3Edt.Location = new System.Drawing.Point(119, 36);
            this.b3Edt.Name = "b3Edt";
            this.b3Edt.Size = new System.Drawing.Size(56, 20);
            this.b3Edt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "B3 = ";
            // 
            // b2Edt
            // 
            this.b2Edt.Location = new System.Drawing.Point(33, 36);
            this.b2Edt.Name = "b2Edt";
            this.b2Edt.Size = new System.Drawing.Size(56, 20);
            this.b2Edt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "B2 = ";
            // 
            // b0Edt
            // 
            this.b0Edt.Location = new System.Drawing.Point(33, 8);
            this.b0Edt.Name = "b0Edt";
            this.b0Edt.Size = new System.Drawing.Size(56, 20);
            this.b0Edt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "B0 = ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.s2Edt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.s1Edt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(527, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OLS results ";
            // 
            // s2Edt
            // 
            this.s2Edt.BackColor = System.Drawing.Color.White;
            this.s2Edt.Location = new System.Drawing.Point(32, 38);
            this.s2Edt.Name = "s2Edt";
            this.s2Edt.ReadOnly = true;
            this.s2Edt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.s2Edt.Size = new System.Drawing.Size(78, 20);
            this.s2Edt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "S2 = ";
            // 
            // s1Edt
            // 
            this.s1Edt.BackColor = System.Drawing.Color.White;
            this.s1Edt.Location = new System.Drawing.Point(32, 16);
            this.s1Edt.Name = "s1Edt";
            this.s1Edt.ReadOnly = true;
            this.s1Edt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.s1Edt.Size = new System.Drawing.Size(78, 20);
            this.s1Edt.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "S1 = ";
            // 
            // varEdt
            // 
            this.varEdt.Location = new System.Drawing.Point(116, 35);
            this.varEdt.Name = "varEdt";
            this.varEdt.Size = new System.Drawing.Size(59, 20);
            this.varEdt.TabIndex = 5;
            this.varEdt.Text = "2";
            // 
            // mEdt
            // 
            this.mEdt.Location = new System.Drawing.Point(116, 9);
            this.mEdt.Name = "mEdt";
            this.mEdt.Size = new System.Drawing.Size(59, 20);
            this.mEdt.TabIndex = 6;
            this.mEdt.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "var";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 217);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Expert 01";
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.TextBox bEdt;
        private System.Windows.Forms.TextBox aEdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button calulateBtn;
        private System.Windows.Forms.TextBox b1Edt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox b3Edt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox b2Edt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox b0Edt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox s2Edt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox s1Edt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox varEdt;
        private System.Windows.Forms.TextBox mEdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

