namespace CaloriesCalculatorVer2
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBurnedCalories = new System.Windows.Forms.Label();
            this.lblFoodCalories = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkDay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblBurnedCalories);
            this.groupBox1.Controls.Add(this.lblFoodCalories);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(130, 105);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // lblBurnedCalories
            // 
            this.lblBurnedCalories.AutoSize = true;
            this.lblBurnedCalories.Location = new System.Drawing.Point(130, 80);
            this.lblBurnedCalories.Name = "lblBurnedCalories";
            this.lblBurnedCalories.Size = new System.Drawing.Size(13, 13);
            this.lblBurnedCalories.TabIndex = 4;
            this.lblBurnedCalories.Text = "0";
            // 
            // lblFoodCalories
            // 
            this.lblFoodCalories.AutoSize = true;
            this.lblFoodCalories.Location = new System.Drawing.Point(130, 51);
            this.lblFoodCalories.Name = "lblFoodCalories";
            this.lblFoodCalories.Size = new System.Drawing.Size(13, 13);
            this.lblFoodCalories.TabIndex = 3;
            this.lblFoodCalories.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burned Calories :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Calories :";
            // 
            // dtpkDay
            // 
            this.dtpkDay.Location = new System.Drawing.Point(42, 6);
            this.dtpkDay.Name = "dtpkDay";
            this.dtpkDay.Size = new System.Drawing.Size(200, 20);
            this.dtpkDay.TabIndex = 5;
            this.dtpkDay.ValueChanged += new System.EventHandler(this.dtpkDay_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(35, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 37);
            this.panel1.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(3, 8);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(68, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(77, 8);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(62, 23);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(145, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpkDay);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBurnedCalories;
        private System.Windows.Forms.Label lblFoodCalories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnNext;
    }
}