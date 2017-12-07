namespace FoodCalculator
{
    partial class KindOfFood
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
            this.flpKindOfFood = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose a kind of food";
            // 
            // flpKindOfFood
            // 
            this.flpKindOfFood.Location = new System.Drawing.Point(12, 53);
            this.flpKindOfFood.Name = "flpKindOfFood";
            this.flpKindOfFood.Size = new System.Drawing.Size(287, 243);
            this.flpKindOfFood.TabIndex = 7;
            // 
            // KindOfFood
            // 
            this.ClientSize = new System.Drawing.Size(311, 308);
            this.Controls.Add(this.flpKindOfFood);
            this.Controls.Add(this.label1);
            this.Name = "KindOfFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpKindOfFood;
    }
}