namespace RcSimulator
{
    partial class Joystick
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxLock = new System.Windows.Forms.CheckBox();
            this.labelXy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 256);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // checkBoxLock
            // 
            this.checkBoxLock.AutoSize = true;
            this.checkBoxLock.Location = new System.Drawing.Point(3, 259);
            this.checkBoxLock.Name = "checkBoxLock";
            this.checkBoxLock.Size = new System.Drawing.Size(50, 17);
            this.checkBoxLock.TabIndex = 1;
            this.checkBoxLock.Text = "Lock";
            this.checkBoxLock.UseVisualStyleBackColor = true;
            this.checkBoxLock.CheckedChanged += new System.EventHandler(this.checkBoxLock_CheckedChanged);
            // 
            // labelXy
            // 
            this.labelXy.AutoSize = true;
            this.labelXy.Location = new System.Drawing.Point(59, 259);
            this.labelXy.Name = "labelXy";
            this.labelXy.Size = new System.Drawing.Size(35, 13);
            this.labelXy.TabIndex = 2;
            this.labelXy.Text = "label1";
            // 
            // Joystick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelXy);
            this.Controls.Add(this.checkBoxLock);
            this.Controls.Add(this.panel1);
            this.Name = "Joystick";
            this.Size = new System.Drawing.Size(256, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxLock;
        private System.Windows.Forms.Label labelXy;
    }
}
