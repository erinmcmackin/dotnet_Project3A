namespace CustomCalculator
{
    partial class frmTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemp));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigTemp = new System.Windows.Forms.TextBox();
            this.radioCel1 = new System.Windows.Forms.RadioButton();
            this.radioFahr1 = new System.Windows.Forms.RadioButton();
            this.radioKel1 = new System.Windows.Forms.RadioButton();
            this.radioCel2 = new System.Windows.Forms.RadioButton();
            this.radioFahr2 = new System.Windows.Forms.RadioButton();
            this.radioKel2 = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnMenuReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConvTemp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDivide = new System.Windows.Forms.TextBox();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.txtDivideResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Original Temperature:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrigTemp
            // 
            this.txtOrigTemp.Location = new System.Drawing.Point(460, 36);
            this.txtOrigTemp.Name = "txtOrigTemp";
            this.txtOrigTemp.Size = new System.Drawing.Size(124, 38);
            this.txtOrigTemp.TabIndex = 1;
            // 
            // radioCel1
            // 
            this.radioCel1.AutoSize = true;
            this.radioCel1.Location = new System.Drawing.Point(64, 48);
            this.radioCel1.Name = "radioCel1";
            this.radioCel1.Size = new System.Drawing.Size(146, 36);
            this.radioCel1.TabIndex = 0;
            this.radioCel1.TabStop = true;
            this.radioCel1.Text = "Celsius";
            this.radioCel1.UseVisualStyleBackColor = true;
            // 
            // radioFahr1
            // 
            this.radioFahr1.AutoSize = true;
            this.radioFahr1.Location = new System.Drawing.Point(253, 48);
            this.radioFahr1.Name = "radioFahr1";
            this.radioFahr1.Size = new System.Drawing.Size(189, 36);
            this.radioFahr1.TabIndex = 1;
            this.radioFahr1.Text = "Fahrenheit";
            this.radioFahr1.UseVisualStyleBackColor = true;
            // 
            // radioKel1
            // 
            this.radioKel1.AutoSize = true;
            this.radioKel1.Location = new System.Drawing.Point(474, 48);
            this.radioKel1.Name = "radioKel1";
            this.radioKel1.Size = new System.Drawing.Size(131, 36);
            this.radioKel1.TabIndex = 2;
            this.radioKel1.Text = "Kelvin";
            this.radioKel1.UseVisualStyleBackColor = true;
            // 
            // radioCel2
            // 
            this.radioCel2.AutoSize = true;
            this.radioCel2.Location = new System.Drawing.Point(64, 37);
            this.radioCel2.Name = "radioCel2";
            this.radioCel2.Size = new System.Drawing.Size(146, 36);
            this.radioCel2.TabIndex = 0;
            this.radioCel2.TabStop = true;
            this.radioCel2.Text = "Celsius";
            this.radioCel2.UseVisualStyleBackColor = true;
            // 
            // radioFahr2
            // 
            this.radioFahr2.AutoSize = true;
            this.radioFahr2.Location = new System.Drawing.Point(253, 37);
            this.radioFahr2.Name = "radioFahr2";
            this.radioFahr2.Size = new System.Drawing.Size(189, 36);
            this.radioFahr2.TabIndex = 1;
            this.radioFahr2.Text = "Fahrenheit";
            this.radioFahr2.UseVisualStyleBackColor = true;
            // 
            // radioKel2
            // 
            this.radioKel2.AutoSize = true;
            this.radioKel2.Location = new System.Drawing.Point(474, 37);
            this.radioKel2.Name = "radioKel2";
            this.radioKel2.Size = new System.Drawing.Size(131, 36);
            this.radioKel2.TabIndex = 2;
            this.radioKel2.Text = "Kelvin";
            this.radioKel2.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(75, 491);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(304, 71);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnMenuReturn
            // 
            this.btnMenuReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenuReturn.Location = new System.Drawing.Point(419, 491);
            this.btnMenuReturn.Name = "btnMenuReturn";
            this.btnMenuReturn.Size = new System.Drawing.Size(308, 71);
            this.btnMenuReturn.TabIndex = 7;
            this.btnMenuReturn.Text = "Menu";
            this.btnMenuReturn.UseVisualStyleBackColor = true;
            this.btnMenuReturn.Click += new System.EventHandler(this.btnMenuReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Converted Temperature:";
            // 
            // txtConvTemp
            // 
            this.txtConvTemp.Location = new System.Drawing.Point(460, 389);
            this.txtConvTemp.Name = "txtConvTemp";
            this.txtConvTemp.ReadOnly = true;
            this.txtConvTemp.Size = new System.Drawing.Size(124, 38);
            this.txtConvTemp.TabIndex = 5;
            this.txtConvTemp.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioKel1);
            this.groupBox1.Controls.Add(this.radioFahr1);
            this.groupBox1.Controls.Add(this.radioCel1);
            this.groupBox1.Location = new System.Drawing.Point(66, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioCel2);
            this.groupBox2.Controls.Add(this.radioFahr2);
            this.groupBox2.Controls.Add(this.radioKel2);
            this.groupBox2.Location = new System.Drawing.Point(66, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To:";
            // 
            // txtDivide
            // 
            this.txtDivide.Location = new System.Drawing.Point(179, 683);
            this.txtDivide.Name = "txtDivide";
            this.txtDivide.Size = new System.Drawing.Size(124, 38);
            this.txtDivide.TabIndex = 8;
            // 
            // txtBy
            // 
            this.txtBy.Location = new System.Drawing.Point(395, 683);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(124, 38);
            this.txtBy.TabIndex = 9;
            // 
            // txtDivideResult
            // 
            this.txtDivideResult.Location = new System.Drawing.Point(588, 683);
            this.txtDivideResult.Name = "txtDivideResult";
            this.txtDivideResult.ReadOnly = true;
            this.txtDivideResult.Size = new System.Drawing.Size(124, 38);
            this.txtDivideResult.TabIndex = 10;
            this.txtDivideResult.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fun with Division!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 683);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Divide:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "=";
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(248, 762);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(304, 71);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // frmTemp
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMenuReturn;
            this.ClientSize = new System.Drawing.Size(805, 912);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDivideResult);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.txtDivide);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConvTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenuReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOrigTemp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(837, 1000);
            this.Name = "frmTemp";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.frmTemp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigTemp;
        private System.Windows.Forms.RadioButton radioCel1;
        private System.Windows.Forms.RadioButton radioKel1;
        private System.Windows.Forms.RadioButton radioCel2;
        private System.Windows.Forms.RadioButton radioFahr2;
        private System.Windows.Forms.RadioButton radioKel2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnMenuReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConvTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioFahr1;
        private System.Windows.Forms.TextBox txtDivide;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.TextBox txtDivideResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDivide;
    }
}