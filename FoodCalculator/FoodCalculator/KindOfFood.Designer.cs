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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFish = new System.Windows.Forms.Label();
            this.lblMeat = new System.Windows.Forms.Label();
            this.lblEggs = new System.Windows.Forms.Label();
            this.lblVegeta = new System.Windows.Forms.Label();
            this.lblFlour = new System.Windows.Forms.Label();
            this.lblRice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRice, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFlour, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblVegeta, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEggs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMeat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFish, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFish
            // 
            this.lblFish.AutoSize = true;
            this.lblFish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFish.Location = new System.Drawing.Point(3, 0);
            this.lblFish.Name = "lblFish";
            this.lblFish.Size = new System.Drawing.Size(278, 43);
            this.lblFish.TabIndex = 0;
            this.lblFish.Text = "Fish";
            // 
            // lblMeat
            // 
            this.lblMeat.AutoSize = true;
            this.lblMeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeat.Location = new System.Drawing.Point(3, 43);
            this.lblMeat.Name = "lblMeat";
            this.lblMeat.Size = new System.Drawing.Size(278, 43);
            this.lblMeat.TabIndex = 1;
            this.lblMeat.Text = "Meat";
            // 
            // lblEggs
            // 
            this.lblEggs.AutoSize = true;
            this.lblEggs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEggs.Location = new System.Drawing.Point(3, 86);
            this.lblEggs.Name = "lblEggs";
            this.lblEggs.Size = new System.Drawing.Size(278, 43);
            this.lblEggs.TabIndex = 2;
            this.lblEggs.Text = "Eggs";
            // 
            // lblVegeta
            // 
            this.lblVegeta.AutoSize = true;
            this.lblVegeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVegeta.Location = new System.Drawing.Point(3, 129);
            this.lblVegeta.Name = "lblVegeta";
            this.lblVegeta.Size = new System.Drawing.Size(278, 43);
            this.lblVegeta.TabIndex = 3;
            this.lblVegeta.Text = "Vegetable";
            // 
            // lblFlour
            // 
            this.lblFlour.AutoSize = true;
            this.lblFlour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlour.Location = new System.Drawing.Point(3, 172);
            this.lblFlour.Name = "lblFlour";
            this.lblFlour.Size = new System.Drawing.Size(278, 43);
            this.lblFlour.TabIndex = 4;
            this.lblFlour.Text = "Flour";
            // 
            // lblRice
            // 
            this.lblRice.AutoSize = true;
            this.lblRice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRice.Location = new System.Drawing.Point(3, 215);
            this.lblRice.Name = "lblRice";
            this.lblRice.Size = new System.Drawing.Size(278, 46);
            this.lblRice.TabIndex = 5;
            this.lblRice.Text = "Rice";
            // 
            // KindOfFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KindOfFood";
            this.Text = "KindOfFood";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRice;
        private System.Windows.Forms.Label lblFlour;
        private System.Windows.Forms.Label lblVegeta;
        private System.Windows.Forms.Label lblEggs;
        private System.Windows.Forms.Label lblMeat;
        private System.Windows.Forms.Label lblFish;
    }
}