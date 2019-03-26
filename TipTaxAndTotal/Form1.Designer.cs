namespace TipTaxAndTotal
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
            this.Bill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bill
            // 
            this.Bill.Location = new System.Drawing.Point(154, 13);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(100, 20);
            this.Bill.TabIndex = 0;
            this.Bill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type the bill before taxes:";
            // 
            // Tip
            // 
            this.Tip.AutoSize = true;
            this.Tip.Location = new System.Drawing.Point(154, 36);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(34, 13);
            this.Tip.TabIndex = 2;
            this.Tip.Text = "$0.00";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(154, 57);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(34, 13);
            this.Tax.TabIndex = 3;
            this.Tax.Text = "$0.00";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(154, 80);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 4;
            this.Total.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "15% Tip:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "7% Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(27, 108);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(262, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Please make sure there is  only numbers in the texbox.";
            this.errorLabel.Visible = false;
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.Location = new System.Drawing.Point(30, 125);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(186, 13);
            this.emptyLabel.TabIndex = 9;
            this.emptyLabel.Text = "Make sure there is something the box.";
            this.emptyLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 170);
            this.Controls.Add(this.emptyLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bill);
            this.Name = "Form1";
            this.Text = "Tip Tax And Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tip;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label emptyLabel;
    }
}

