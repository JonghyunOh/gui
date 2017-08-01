namespace BMICalculatorJack
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioBtn = new System.Windows.Forms.RadioButton();
            this.metricRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metricRadioBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.heightBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.weightBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.submitBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.01197F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 294);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ImperialRadioBtn
            // 
            this.ImperialRadioBtn.AutoSize = true;
            this.ImperialRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioBtn.Name = "ImperialRadioBtn";
            this.ImperialRadioBtn.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioBtn.TabIndex = 0;
            this.ImperialRadioBtn.TabStop = true;
            this.ImperialRadioBtn.Text = "Imperial";
            this.ImperialRadioBtn.UseVisualStyleBackColor = true;
            // 
            // metricRadioBtn
            // 
            this.metricRadioBtn.AutoSize = true;
            this.metricRadioBtn.Location = new System.Drawing.Point(143, 3);
            this.metricRadioBtn.Name = "metricRadioBtn";
            this.metricRadioBtn.Size = new System.Drawing.Size(106, 35);
            this.metricRadioBtn.TabIndex = 1;
            this.metricRadioBtn.TabStop = true;
            this.metricRadioBtn.Text = "Metric";
            this.metricRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(3, 89);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(134, 38);
            this.heightBox.TabIndex = 4;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(3, 168);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(134, 38);
            this.weightBox.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(143, 212);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(106, 38);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(15, 338);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(92, 31);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "BMI Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialRadioBtn;
        private System.Windows.Forms.RadioButton metricRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

