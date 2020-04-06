namespace RcSimulator
{
    partial class CalibrationCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownZero = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.checkBoxInverted = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 697F));
            this.tableLayoutPanel1.Controls.Add(this.buttonZero, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonMax, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonMin, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownZero, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxChannel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMax, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxInverted, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 506);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(227, 135);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(75, 23);
            this.buttonZero.TabIndex = 9;
            this.buttonZero.Text = "Edit";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(227, 106);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(75, 23);
            this.buttonMax.TabIndex = 8;
            this.buttonMax.Text = "Edit";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(227, 77);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(75, 23);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.Text = "Edit";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownZero
            // 
            this.numericUpDownZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownZero.Location = new System.Drawing.Point(55, 135);
            this.numericUpDownZero.Name = "numericUpDownZero";
            this.numericUpDownZero.Size = new System.Drawing.Size(166, 20);
            this.numericUpDownZero.TabIndex = 3;
            this.numericUpDownZero.ValueChanged += new System.EventHandler(this.numericUpDownZero_ValueChanged);
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Location = new System.Drawing.Point(55, 3);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.Size = new System.Drawing.Size(166, 21);
            this.comboBoxChannel.TabIndex = 4;
            this.comboBoxChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxChannel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMin.Location = new System.Drawing.Point(55, 77);
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(166, 20);
            this.numericUpDownMin.TabIndex = 1;
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMax.Location = new System.Drawing.Point(55, 106);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(166, 20);
            this.numericUpDownMax.TabIndex = 2;
            this.numericUpDownMax.ValueChanged += new System.EventHandler(this.numericUpDownMax_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zero";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mode";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Inverted";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(55, 30);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(166, 21);
            this.comboBoxMode.TabIndex = 12;
            // 
            // checkBoxInverted
            // 
            this.checkBoxInverted.AutoSize = true;
            this.checkBoxInverted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxInverted.Location = new System.Drawing.Point(55, 57);
            this.checkBoxInverted.Name = "checkBoxInverted";
            this.checkBoxInverted.Size = new System.Drawing.Size(166, 14);
            this.checkBoxInverted.TabIndex = 13;
            this.checkBoxInverted.UseVisualStyleBackColor = true;
            // 
            // CalibrationCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CalibrationCtrl";
            this.Size = new System.Drawing.Size(921, 506);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownZero;
        private System.Windows.Forms.ComboBox comboBoxChannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.CheckBox checkBoxInverted;
    }
}
