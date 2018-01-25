namespace CaloriesCalculatorVer2
{
    partial class foodCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodCalculator));
            this.btnCaloriesProducts = new System.Windows.Forms.Button();
            this.btnBurnedCalories = new System.Windows.Forms.Button();
            this.btnStatics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaloriesProducts
            // 
            this.btnCaloriesProducts.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCaloriesProducts.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaloriesProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaloriesProducts.Location = new System.Drawing.Point(15, 134);
            this.btnCaloriesProducts.Name = "btnCaloriesProducts";
            this.btnCaloriesProducts.Size = new System.Drawing.Size(333, 115);
            this.btnCaloriesProducts.TabIndex = 0;
            this.btnCaloriesProducts.Text = "Calories in Food Products";
            this.btnCaloriesProducts.UseVisualStyleBackColor = false;
            this.btnCaloriesProducts.Click += new System.EventHandler(this.btnCaloriesProducts_Click);
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
            // btnStatics
            // 
            this.btnStatics.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStatics.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatics.Location = new System.Drawing.Point(12, 376);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(333, 115);
            this.btnStatics.TabIndex = 2;
            this.btnStatics.Text = "Personal Weight Statistic";
            this.btnStatics.UseVisualStyleBackColor = false;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
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
            // foodCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatics);
            this.Controls.Add(this.btnBurnedCalories);
            this.Controls.Add(this.btnCaloriesProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "foodCalculator";
            this.Text = "Food Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.foodCalculator_FormClosing);
            this.Load += new System.EventHandler(this.foodCalculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaloriesProducts;
        private System.Windows.Forms.Button btnBurnedCalories;
        private System.Windows.Forms.Button btnStatics;
        private System.Windows.Forms.Label label1;
    }
}

