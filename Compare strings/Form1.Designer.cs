namespace Compare_strings
{
    partial class StringComparer
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
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(140, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 76);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "String Comparer";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(75, 143);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(45, 13);
            this.lblx.TabIndex = 1;
            this.lblx.Text = "String x:";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(75, 193);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(45, 13);
            this.lbly.TabIndex = 2;
            this.lbly.Text = "String y:";
            this.lbly.Click += new System.EventHandler(this.lbly_Click);
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(175, 143);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(427, 20);
            this.txtx.TabIndex = 3;
            this.txtx.TextChanged += new System.EventHandler(this.txtx_TextChanged);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(175, 190);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(427, 20);
            this.txty.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(343, 245);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 49);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(75, 333);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(471, 13);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Enter two strings, the program will return the longest sequnce of characters cont" +
    "ained in both string";
            this.lblInstruction.Click += new System.EventHandler(this.lbly_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(663, 389);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(125, 49);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // StringComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lblTitle);
            this.Name = "StringComparer";
            this.Text = "String Comparer";
            this.Load += new System.EventHandler(this.StringComparer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnHelp;
    }
}

