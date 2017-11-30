namespace WindowsFormsApp1
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
            this.txtElement = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtCabohydrat = new System.Windows.Forms.TextBox();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProtein = new System.Windows.Forms.Label();
            this.txtSaturted = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.Label();
            this.txtCholesterol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(157, 43);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(301, 20);
            this.txtElement.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 20);
            this.textBox4.TabIndex = 25;
            // 
            // txtCabohydrat
            // 
            this.txtCabohydrat.Location = new System.Drawing.Point(157, 133);
            this.txtCabohydrat.Name = "txtCabohydrat";
            this.txtCabohydrat.Size = new System.Drawing.Size(301, 20);
            this.txtCabohydrat.TabIndex = 26;
            // 
            // txtEnergy
            // 
            this.txtEnergy.Location = new System.Drawing.Point(157, 89);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(301, 20);
            this.txtEnergy.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fat (Grams) :";
            // 
            // txtProtein
            // 
            this.txtProtein.AutoSize = true;
            this.txtProtein.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProtein.Location = new System.Drawing.Point(11, 184);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(100, 15);
            this.txtProtein.TabIndex = 29;
            this.txtProtein.Text = "Protein (Grams) :";
            // 
            // txtSaturted
            // 
            this.txtSaturted.AutoSize = true;
            this.txtSaturted.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSaturted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaturted.Location = new System.Drawing.Point(11, 326);
            this.txtSaturted.Name = "txtSaturted";
            this.txtSaturted.Size = new System.Drawing.Size(134, 15);
            this.txtSaturted.TabIndex = 30;
            this.txtSaturted.Text = "Saturated Fat (Grams) :";
            // 
            // txtWeight
            // 
            this.txtWeight.AutoSize = true;
            this.txtWeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(11, 277);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(99, 15);
            this.txtWeight.TabIndex = 31;
            this.txtWeight.Text = "Weight (Grams) :";
            // 
            // txtCholesterol
            // 
            this.txtCholesterol.AutoSize = true;
            this.txtCholesterol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCholesterol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCholesterol.Location = new System.Drawing.Point(9, 230);
            this.txtCholesterol.Name = "txtCholesterol";
            this.txtCholesterol.Size = new System.Drawing.Size(141, 15);
            this.txtCholesterol.TabIndex = 32;
            this.txtCholesterol.Text = "Cholesterol (Milligrams):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Carbohydrate (calories):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Food Energy(Grams) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Font = new System.Drawing.Font("Hue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = " Nutrition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 383);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCholesterol);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtSaturted);
            this.Controls.Add(this.txtProtein);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnergy);
            this.Controls.Add(this.txtCabohydrat);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtElement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtCabohydrat;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtProtein;
        private System.Windows.Forms.Label txtSaturted;
        private System.Windows.Forms.Label txtWeight;
        private System.Windows.Forms.Label txtCholesterol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}

