namespace TplExample
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
            this.itemsNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.threadsNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rangeTo = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.toFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countFinds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsNumber
            // 
            this.itemsNumber.Location = new System.Drawing.Point(137, 37);
            this.itemsNumber.Name = "itemsNumber";
            this.itemsNumber.Size = new System.Drawing.Size(100, 20);
            this.itemsNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ilosc elementow";
            // 
            // threadsNumber
            // 
            this.threadsNumber.Location = new System.Drawing.Point(137, 64);
            this.threadsNumber.Name = "threadsNumber";
            this.threadsNumber.Size = new System.Drawing.Size(100, 20);
            this.threadsNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ilosc watkow";
            // 
            // rangeFrom
            // 
            this.rangeFrom.Location = new System.Drawing.Point(137, 91);
            this.rangeFrom.Name = "rangeFrom";
            this.rangeFrom.Size = new System.Drawing.Size(100, 20);
            this.rangeFrom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "zakresy";
            // 
            // rangeTo
            // 
            this.rangeTo.Location = new System.Drawing.Point(137, 118);
            this.rangeTo.Name = "rangeTo";
            this.rangeTo.Size = new System.Drawing.Size(100, 20);
            this.rangeTo.TabIndex = 6;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(47, 168);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 7;
            this.go.Text = "button1";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // toFind
            // 
            this.toFind.Location = new System.Drawing.Point(137, 145);
            this.toFind.Name = "toFind";
            this.toFind.Size = new System.Drawing.Size(100, 20);
            this.toFind.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "szukane";
            // 
            // countFinds
            // 
            this.countFinds.AutoSize = true;
            this.countFinds.Location = new System.Drawing.Point(273, 36);
            this.countFinds.Name = "countFinds";
            this.countFinds.Size = new System.Drawing.Size(0, 13);
            this.countFinds.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 286);
            this.Controls.Add(this.countFinds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toFind);
            this.Controls.Add(this.go);
            this.Controls.Add(this.rangeTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rangeFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.threadsNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox threadsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rangeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rangeTo;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox toFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label countFinds;
    }
}

