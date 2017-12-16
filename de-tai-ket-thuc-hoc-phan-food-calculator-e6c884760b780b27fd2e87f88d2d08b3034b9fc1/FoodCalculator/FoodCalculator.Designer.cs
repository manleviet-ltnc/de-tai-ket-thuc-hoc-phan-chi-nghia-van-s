namespace FoodCalculator
{
    partial class FoodCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodCalculator));
            this.btnFoodCalories = new System.Windows.Forms.Button();
            this.btnBurnedCalories = new System.Windows.Forms.Button();
            this.btnPWS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFoodCalories
            // 
            this.btnFoodCalories.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFoodCalories.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodCalories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFoodCalories.Location = new System.Drawing.Point(15, 134);
            this.btnFoodCalories.Name = "btnFoodCalories";
            this.btnFoodCalories.Size = new System.Drawing.Size(333, 115);
            this.btnFoodCalories.TabIndex = 0;
            this.btnFoodCalories.Text = "Calories in Food Products";
            this.btnFoodCalories.UseVisualStyleBackColor = false;
            this.btnFoodCalories.Click += new System.EventHandler(this.btnFoodCalories_Click);
            // 
            // btnBurnedCalories
            // 
            this.btnBurnedCalories.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBurnedCalories.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurnedCalories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBurnedCalories.Location = new System.Drawing.Point(15, 255);
            this.btnBurnedCalories.Name = "btnBurnedCalories";
            this.btnBurnedCalories.Size = new System.Drawing.Size(333, 115);
            this.btnBurnedCalories.TabIndex = 1;
            this.btnBurnedCalories.Text = "Burned Calories";
            this.btnBurnedCalories.UseVisualStyleBackColor = false;
            this.btnBurnedCalories.Click += new System.EventHandler(this.btnBurnedCalories_Click);
            // 
            // btnPWS
            // 
            this.btnPWS.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPWS.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPWS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPWS.Location = new System.Drawing.Point(12, 376);
            this.btnPWS.Name = "btnPWS";
            this.btnPWS.Size = new System.Drawing.Size(333, 115);
            this.btnPWS.TabIndex = 2;
            this.btnPWS.Text = "Personal Weight Statistic";
            this.btnPWS.UseVisualStyleBackColor = false;
            this.btnPWS.Click += new System.EventHandler(this.btnPWS_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 115);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FoodCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPWS);
            this.Controls.Add(this.btnBurnedCalories);
            this.Controls.Add(this.btnFoodCalories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FoodCalculator";
            this.Text = "Food Calculator";
            this.Load += new System.EventHandler(this.FoodCalculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFoodCalories;
        private System.Windows.Forms.Button btnBurnedCalories;
        private System.Windows.Forms.Button btnPWS;
        private System.Windows.Forms.Label label1;
    }
}

