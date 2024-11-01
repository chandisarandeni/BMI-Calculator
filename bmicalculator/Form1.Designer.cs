namespace bmicalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_personHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_personWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pnl_calculatedBMI = new System.Windows.Forms.Panel();
            this.lbl_showBmiValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_frameTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_calculatedBMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_personWeight);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_personHeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(53, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 211);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "cm";
            // 
            // txt_personHeight
            // 
            this.txt_personHeight.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personHeight.Location = new System.Drawing.Point(222, 25);
            this.txt_personHeight.Name = "txt_personHeight";
            this.txt_personHeight.Size = new System.Drawing.Size(144, 45);
            this.txt_personHeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "kg";
            // 
            // txt_personWeight
            // 
            this.txt_personWeight.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personWeight.Location = new System.Drawing.Point(222, 98);
            this.txt_personWeight.Name = "txt_personWeight";
            this.txt_personWeight.Size = new System.Drawing.Size(144, 45);
            this.txt_personWeight.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Weight";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(142, 337);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(160, 49);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(361, 337);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(160, 49);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pnl_calculatedBMI
            // 
            this.pnl_calculatedBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_calculatedBMI.Controls.Add(this.lbl_showBmiValue);
            this.pnl_calculatedBMI.Controls.Add(this.label9);
            this.pnl_calculatedBMI.Controls.Add(this.label10);
            this.pnl_calculatedBMI.Location = new System.Drawing.Point(53, 429);
            this.pnl_calculatedBMI.Name = "pnl_calculatedBMI";
            this.pnl_calculatedBMI.Size = new System.Drawing.Size(562, 174);
            this.pnl_calculatedBMI.TabIndex = 10;
            // 
            // lbl_showBmiValue
            // 
            this.lbl_showBmiValue.AutoSize = true;
            this.lbl_showBmiValue.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showBmiValue.Location = new System.Drawing.Point(215, 78);
            this.lbl_showBmiValue.Name = "lbl_showBmiValue";
            this.lbl_showBmiValue.Size = new System.Drawing.Size(244, 46);
            this.lbl_showBmiValue.TabIndex = 9;
            this.lbl_showBmiValue.Text = "Sample Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 37);
            this.label9.TabIndex = 7;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 46);
            this.label10.TabIndex = 6;
            this.label10.Text = "BMI";
            // 
            // lbl_frameTitle
            // 
            this.lbl_frameTitle.AutoSize = true;
            this.lbl_frameTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frameTitle.Location = new System.Drawing.Point(68, 416);
            this.lbl_frameTitle.Name = "lbl_frameTitle";
            this.lbl_frameTitle.Size = new System.Drawing.Size(112, 23);
            this.lbl_frameTitle.TabIndex = 10;
            this.lbl_frameTitle.Text = "BMI Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Enter values to calculate your BMI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 650);
            this.Controls.Add(this.lbl_frameTitle);
            this.Controls.Add(this.pnl_calculatedBMI);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_calculatedBMI.ResumeLayout(false);
            this.pnl_calculatedBMI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_personHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_personWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel pnl_calculatedBMI;
        private System.Windows.Forms.Label lbl_showBmiValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_frameTitle;
        private System.Windows.Forms.Label label8;
    }
}

