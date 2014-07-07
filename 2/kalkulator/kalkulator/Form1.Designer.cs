namespace kalkulator
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
            this.calc = new System.Windows.Forms.TextBox();
            this.calcSubmit = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(29, 21);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(565, 20);
            this.calc.TabIndex = 0;
            // 
            // calcSubmit
            // 
            this.calcSubmit.Location = new System.Drawing.Point(29, 61);
            this.calcSubmit.Name = "calcSubmit";
            this.calcSubmit.Size = new System.Drawing.Size(75, 23);
            this.calcSubmit.TabIndex = 1;
            this.calcSubmit.Text = "button1";
            this.calcSubmit.UseVisualStyleBackColor = true;
            this.calcSubmit.Click += new System.EventHandler(this.calcSubmit_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Location = new System.Drawing.Point(29, 100);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(35, 13);
            this.wynik.TabIndex = 2;
            this.wynik.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 217);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.calcSubmit);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calc;
        private System.Windows.Forms.Button calcSubmit;
        private System.Windows.Forms.Label wynik;
    }
}

