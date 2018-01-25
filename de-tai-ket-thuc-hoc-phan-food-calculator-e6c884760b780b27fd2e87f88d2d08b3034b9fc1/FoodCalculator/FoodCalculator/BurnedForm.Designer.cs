namespace CaloriesCalculatorVer2
{
    partial class BurnedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurnedForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.lblBurnedCalories = new System.Windows.Forms.Label();
            this.btnShowCalories = new System.Windows.Forms.Button();
            this.grpTimespent = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmSecond = new System.Windows.Forms.NumericUpDown();
            this.nmMinute = new System.Windows.Forms.NumericUpDown();
            this.grpActivities = new System.Windows.Forms.GroupBox();
            this.fplActivities = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCalculation.SuspendLayout();
            this.grpTimespent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinute)).BeginInit();
            this.grpActivities.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(230, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.Controls.Add(this.lblBurnedCalories);
            this.pnlCalculation.Controls.Add(this.btnShowCalories);
            this.pnlCalculation.Location = new System.Drawing.Point(200, 109);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(141, 65);
            this.pnlCalculation.TabIndex = 6;
            // 
            // lblBurnedCalories
            // 
            this.lblBurnedCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBurnedCalories.AutoSize = true;
            this.lblBurnedCalories.Location = new System.Drawing.Point(63, 11);
            this.lblBurnedCalories.Name = "lblBurnedCalories";
            this.lblBurnedCalories.Size = new System.Drawing.Size(13, 13);
            this.lblBurnedCalories.TabIndex = 1;
            this.lblBurnedCalories.Text = "0";
            this.lblBurnedCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowCalories
            // 
            this.btnShowCalories.Location = new System.Drawing.Point(21, 39);
            this.btnShowCalories.Name = "btnShowCalories";
            this.btnShowCalories.Size = new System.Drawing.Size(99, 23);
            this.btnShowCalories.TabIndex = 0;
            this.btnShowCalories.Text = "Show Calories";
            this.btnShowCalories.UseVisualStyleBackColor = true;
            this.btnShowCalories.Click += new System.EventHandler(this.btnShowCalories_Click);
            // 
            // grpTimespent
            // 
            this.grpTimespent.Controls.Add(this.label3);
            this.grpTimespent.Controls.Add(this.label2);
            this.grpTimespent.Controls.Add(this.label1);
            this.grpTimespent.Controls.Add(this.nmSecond);
            this.grpTimespent.Controls.Add(this.nmMinute);
            this.grpTimespent.Location = new System.Drawing.Point(200, 15);
            this.grpTimespent.Name = "grpTimespent";
            this.grpTimespent.Size = new System.Drawing.Size(141, 88);
            this.grpTimespent.TabIndex = 5;
            this.grpTimespent.TabStop = false;
            this.grpTimespent.Text = "Time spent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seconds";
            // 
            // nmSecond
            // 
            this.nmSecond.Location = new System.Drawing.Point(79, 55);
            this.nmSecond.Name = "nmSecond";
            this.nmSecond.Size = new System.Drawing.Size(44, 20);
            this.nmSecond.TabIndex = 2;
            // 
            // nmMinute
            // 
            this.nmMinute.Location = new System.Drawing.Point(19, 55);
            this.nmMinute.Name = "nmMinute";
            this.nmMinute.Size = new System.Drawing.Size(44, 20);
            this.nmMinute.TabIndex = 1;
            // 
            // grpActivities
            // 
            this.grpActivities.Controls.Add(this.fplActivities);
            this.grpActivities.Location = new System.Drawing.Point(12, 15);
            this.grpActivities.Name = "grpActivities";
            this.grpActivities.Size = new System.Drawing.Size(165, 250);
            this.grpActivities.TabIndex = 4;
            this.grpActivities.TabStop = false;
            this.grpActivities.Text = "Activities";
            // 
            // fplActivities
            // 
            this.fplActivities.Location = new System.Drawing.Point(6, 19);
            this.fplActivities.Name = "fplActivities";
            this.fplActivities.Size = new System.Drawing.Size(153, 225);
            this.fplActivities.TabIndex = 0;
            // 
            // BurnedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(353, 277);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.grpTimespent);
            this.Controls.Add(this.grpActivities);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BurnedForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burned Calories";
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.grpTimespent.ResumeLayout(false);
            this.grpTimespent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinute)).EndInit();
            this.grpActivities.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.Label lblBurnedCalories;
        private System.Windows.Forms.Button btnShowCalories;
        private System.Windows.Forms.GroupBox grpTimespent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmSecond;
        private System.Windows.Forms.NumericUpDown nmMinute;
        private System.Windows.Forms.GroupBox grpActivities;
        private System.Windows.Forms.FlowLayoutPanel fplActivities;
    }
}