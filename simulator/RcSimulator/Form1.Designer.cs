namespace RcSimulator
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
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.checkBoxAutolevel = new System.Windows.Forms.CheckBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageBinding = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingCtrl1 = new RcSimulator.BindingCtrl();
            this.bindingCtrl2 = new RcSimulator.BindingCtrl();
            this.bindingCtrl3 = new RcSimulator.BindingCtrl();
            this.bindingCtrl4 = new RcSimulator.BindingCtrl();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingCtrl5 = new RcSimulator.BindingCtrl();
            this.bindingCtrl6 = new RcSimulator.BindingCtrl();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageCalibration = new System.Windows.Forms.TabPage();
            this.calibrationCtrl = new RcSimulator.CalibrationCtrl();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.joystickLeft = new RcSimulator.Joystick();
            this.joystickRight = new RcSimulator.Joystick();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageBinding.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageCalibration.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(7, 12);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 2;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(113, 9);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // timerSend
            // 
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(873, 370);
            this.richTextBoxOutput.TabIndex = 4;
            this.richTextBoxOutput.Text = "";
            // 
            // checkBoxAutolevel
            // 
            this.checkBoxAutolevel.AutoSize = true;
            this.checkBoxAutolevel.Location = new System.Drawing.Point(532, 6);
            this.checkBoxAutolevel.Name = "checkBoxAutolevel";
            this.checkBoxAutolevel.Size = new System.Drawing.Size(77, 17);
            this.checkBoxAutolevel.TabIndex = 11;
            this.checkBoxAutolevel.Text = "Auto Level";
            this.checkBoxAutolevel.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageBinding);
            this.tabControlMain.Controls.Add(this.tabPageCalibration);
            this.tabControlMain.Controls.Add(this.tabPageInput);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Location = new System.Drawing.Point(0, 49);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(893, 454);
            this.tabControlMain.TabIndex = 12;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageBinding
            // 
            this.tabPageBinding.Controls.Add(this.tableLayoutPanel2);
            this.tabPageBinding.Location = new System.Drawing.Point(4, 22);
            this.tabPageBinding.Name = "tabPageBinding";
            this.tabPageBinding.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBinding.Size = new System.Drawing.Size(885, 428);
            this.tabPageBinding.TabIndex = 3;
            this.tabPageBinding.Text = "Binding";
            this.tabPageBinding.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bindingCtrl1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bindingCtrl2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bindingCtrl3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bindingCtrl4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bindingCtrl5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.bindingCtrl6, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(879, 422);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "CH#4";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "CH#3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "CH#2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bindingCtrl1
            // 
            this.bindingCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingCtrl1.Location = new System.Drawing.Point(44, 3);
            this.bindingCtrl1.Name = "bindingCtrl1";
            this.bindingCtrl1.Size = new System.Drawing.Size(832, 26);
            this.bindingCtrl1.TabIndex = 0;
            // 
            // bindingCtrl2
            // 
            this.bindingCtrl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingCtrl2.Location = new System.Drawing.Point(44, 35);
            this.bindingCtrl2.Name = "bindingCtrl2";
            this.bindingCtrl2.Size = new System.Drawing.Size(832, 26);
            this.bindingCtrl2.TabIndex = 1;
            // 
            // bindingCtrl3
            // 
            this.bindingCtrl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingCtrl3.Location = new System.Drawing.Point(44, 67);
            this.bindingCtrl3.Name = "bindingCtrl3";
            this.bindingCtrl3.Size = new System.Drawing.Size(832, 26);
            this.bindingCtrl3.TabIndex = 2;
            // 
            // bindingCtrl4
            // 
            this.bindingCtrl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingCtrl4.Location = new System.Drawing.Point(44, 99);
            this.bindingCtrl4.Name = "bindingCtrl4";
            this.bindingCtrl4.Size = new System.Drawing.Size(832, 26);
            this.bindingCtrl4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "CH#1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bindingCtrl5
            // 
            this.bindingCtrl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingCtrl5.Location = new System.Drawing.Point(44, 131);
            this.bindingCtrl5.Name = "bindingCtrl5";
            this.bindingCtrl5.Size = new System.Drawing.Size(832, 26);
            this.bindingCtrl5.TabIndex = 8;
            // 
            // bindingCtrl6
            // 
            this.bindingCtrl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingCtrl6.Location = new System.Drawing.Point(44, 163);
            this.bindingCtrl6.Name = "bindingCtrl6";
            this.bindingCtrl6.Size = new System.Drawing.Size(832, 26);
            this.bindingCtrl6.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "CH#5";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "CH#6";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageCalibration
            // 
            this.tabPageCalibration.Controls.Add(this.calibrationCtrl);
            this.tabPageCalibration.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalibration.Name = "tabPageCalibration";
            this.tabPageCalibration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalibration.Size = new System.Drawing.Size(885, 428);
            this.tabPageCalibration.TabIndex = 2;
            this.tabPageCalibration.Text = "Calibration";
            this.tabPageCalibration.UseVisualStyleBackColor = true;
            // 
            // calibrationCtrl
            // 
            this.calibrationCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calibrationCtrl.Location = new System.Drawing.Point(3, 3);
            this.calibrationCtrl.Name = "calibrationCtrl";
            this.calibrationCtrl.Size = new System.Drawing.Size(879, 422);
            this.calibrationCtrl.TabIndex = 13;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.joystickLeft);
            this.tabPageInput.Controls.Add(this.checkBoxAutolevel);
            this.tabPageInput.Controls.Add(this.joystickRight);
            this.tabPageInput.Location = new System.Drawing.Point(4, 22);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInput.Size = new System.Drawing.Size(885, 428);
            this.tabPageInput.TabIndex = 0;
            this.tabPageInput.Text = "Input";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // joystickLeft
            // 
            this.joystickLeft.Location = new System.Drawing.Point(8, 6);
            this.joystickLeft.Name = "joystickLeft";
            this.joystickLeft.Size = new System.Drawing.Size(256, 285);
            this.joystickLeft.TabIndex = 9;
            // 
            // joystickRight
            // 
            this.joystickRight.Location = new System.Drawing.Point(270, 6);
            this.joystickRight.Name = "joystickRight";
            this.joystickRight.Size = new System.Drawing.Size(256, 285);
            this.joystickRight.TabIndex = 10;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.buttonClear);
            this.tabPageLog.Controls.Add(this.richTextBoxOutput);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(885, 428);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(8, 382);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonExport);
            this.flowLayoutPanel1.Controls.Add(this.buttonImport);
            this.flowLayoutPanel1.Controls.Add(this.buttonWrite);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 34);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(621, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(540, 3);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 1;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(459, 3);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 2;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 528);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageBinding.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageCalibration.ResumeLayout(false);
            this.tabPageInput.ResumeLayout(false);
            this.tabPageInput.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private Joystick joystickLeft;
        private Joystick joystickRight;
        private System.Windows.Forms.CheckBox checkBoxAutolevel;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabPage tabPageCalibration;
        private System.Windows.Forms.TabPage tabPageBinding;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BindingCtrl bindingCtrl1;
        private BindingCtrl bindingCtrl2;
        private BindingCtrl bindingCtrl3;
        private BindingCtrl bindingCtrl4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private BindingCtrl bindingCtrl5;
        private BindingCtrl bindingCtrl6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private CalibrationCtrl calibrationCtrl;
        private System.Windows.Forms.Button buttonWrite;
    }
}

