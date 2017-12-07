namespace FoodCalculator
{
    partial class Calories
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
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.lblCross = new System.Windows.Forms.Label();
            this.lblResultCross = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lblOunces = new System.Windows.Forms.Label();
            this.numbUpDown = new System.Windows.Forms.NumericUpDown();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.Location = new System.Drawing.Point(12, 12);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(272, 237);
            this.flpMenu.TabIndex = 0;
            // 
            // btnCaculate
            // 
            this.btnCaculate.Location = new System.Drawing.Point(191, 53);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(120, 23);
            this.btnCaculate.TabIndex = 1;
            this.btnCaculate.Text = "Caculate";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // lblCross
            // 
            this.lblCross.AutoSize = true;
            this.lblCross.Location = new System.Drawing.Point(188, 100);
            this.lblCross.Name = "lblCross";
            this.lblCross.Size = new System.Drawing.Size(64, 13);
            this.lblCross.TabIndex = 2;
            this.lblCross.Text = "Crossirants :";
            // 
            // lblResultCross
            // 
            this.lblResultCross.AutoSize = true;
            this.lblResultCross.Location = new System.Drawing.Point(298, 100);
            this.lblResultCross.Name = "lblResultCross";
            this.lblResultCross.Size = new System.Drawing.Size(13, 13);
            this.lblResultCross.TabIndex = 3;
            this.lblResultCross.Text = "0";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.dtgvInfo);
            this.pnlInfo.Location = new System.Drawing.Point(305, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(478, 100);
            this.pnlInfo.TabIndex = 5;
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(4, 4);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.Size = new System.Drawing.Size(471, 77);
            this.dtgvInfo.TabIndex = 0;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblOunces);
            this.pnlResult.Controls.Add(this.numbUpDown);
            this.pnlResult.Controls.Add(this.btnCaculate);
            this.pnlResult.Controls.Add(this.lblCross);
            this.pnlResult.Controls.Add(this.lblResultCross);
            this.pnlResult.Location = new System.Drawing.Point(305, 118);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(475, 131);
            this.pnlResult.TabIndex = 7;
            // 
            // lblOunces
            // 
            this.lblOunces.AutoSize = true;
            this.lblOunces.Location = new System.Drawing.Point(267, 17);
            this.lblOunces.Name = "lblOunces";
            this.lblOunces.Size = new System.Drawing.Size(44, 13);
            this.lblOunces.TabIndex = 8;
            this.lblOunces.Text = "Ounces";
            // 
            // numbUpDown
            // 
            this.numbUpDown.Location = new System.Drawing.Point(191, 15);
            this.numbUpDown.Name = "numbUpDown";
            this.numbUpDown.Size = new System.Drawing.Size(61, 20);
            this.numbUpDown.TabIndex = 7;
            this.numbUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Calories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 261);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.flpMenu);
            this.Name = "Calories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calories";
            this.pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnCaculate;
        private System.Windows.Forms.Label lblCross;
        private System.Windows.Forms.Label lblResultCross;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.NumericUpDown numbUpDown;
        private System.Windows.Forms.Label lblOunces;
    }
}