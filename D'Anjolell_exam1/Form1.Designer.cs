
namespace D_Anjolell_exam1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblTitle.Location = new System.Drawing.Point(133, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(516, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Investment Calculator";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblName.Location = new System.Drawing.Point(198, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(214, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Product\'s Name:";
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblMonths.Location = new System.Drawing.Point(198, 197);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(222, 31);
            this.lblMonths.TabIndex = 2;
            this.lblMonths.Text = "Months Invested:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblCost.Location = new System.Drawing.Point(198, 134);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(199, 31);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Product\'s Cost:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtName.Location = new System.Drawing.Point(446, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 37);
            this.txtName.TabIndex = 4;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtCost.Location = new System.Drawing.Point(446, 134);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(160, 37);
            this.txtCost.TabIndex = 5;
            // 
            // txtMonths
            // 
            this.txtMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtMonths.Location = new System.Drawing.Point(446, 197);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(160, 37);
            this.txtMonths.TabIndex = 6;
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 30;
            this.lstResults.Location = new System.Drawing.Point(204, 269);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(402, 184);
            this.lstResults.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnExit.Location = new System.Drawing.Point(472, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 49);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSubmit.Location = new System.Drawing.Point(224, 459);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 49);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
    }
}

