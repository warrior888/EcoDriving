namespace obdLibWrapper
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
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baudTextBox = new System.Windows.Forms.TextBox();
            this.pidListView = new System.Windows.Forms.ListView();
            this.pidTextBox = new System.Windows.Forms.TextBox();
            this.addPidbutton = new System.Windows.Forms.Button();
            this.removePidButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(67, 68);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(67, 97);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(42, 16);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud";
            // 
            // baudTextBox
            // 
            this.baudTextBox.Location = new System.Drawing.Point(42, 42);
            this.baudTextBox.Name = "baudTextBox";
            this.baudTextBox.Size = new System.Drawing.Size(100, 20);
            this.baudTextBox.TabIndex = 6;
            this.baudTextBox.Text = "115200";
            // 
            // pidListView
            // 
            this.pidListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.pidListView.Location = new System.Drawing.Point(148, 12);
            this.pidListView.Name = "pidListView";
            this.pidListView.Size = new System.Drawing.Size(294, 246);
            this.pidListView.TabIndex = 7;
            this.pidListView.UseCompatibleStateImageBehavior = false;
            this.pidListView.View = System.Windows.Forms.View.Details;
            // 
            // pidTextBox
            // 
            this.pidTextBox.Location = new System.Drawing.Point(148, 264);
            this.pidTextBox.Name = "pidTextBox";
            this.pidTextBox.Size = new System.Drawing.Size(178, 20);
            this.pidTextBox.TabIndex = 8;
            // 
            // addPidbutton
            // 
            this.addPidbutton.Location = new System.Drawing.Point(148, 290);
            this.addPidbutton.Name = "addPidbutton";
            this.addPidbutton.Size = new System.Drawing.Size(86, 23);
            this.addPidbutton.TabIndex = 9;
            this.addPidbutton.Text = "Add PID";
            this.addPidbutton.UseVisualStyleBackColor = true;
            this.addPidbutton.Click += new System.EventHandler(this.addPidbutton_Click);
            // 
            // removePidButton
            // 
            this.removePidButton.Location = new System.Drawing.Point(240, 290);
            this.removePidButton.Name = "removePidButton";
            this.removePidButton.Size = new System.Drawing.Size(86, 23);
            this.removePidButton.TabIndex = 10;
            this.removePidButton.Text = "Remove PID";
            this.removePidButton.UseVisualStyleBackColor = true;
            this.removePidButton.Click += new System.EventHandler(this.removePidButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mode Pid";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 135;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 316);
            this.Controls.Add(this.removePidButton);
            this.Controls.Add(this.addPidbutton);
            this.Controls.Add(this.pidTextBox);
            this.Controls.Add(this.pidListView);
            this.Controls.Add(this.baudTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baudTextBox;
        private System.Windows.Forms.ListView pidListView;
        private System.Windows.Forms.TextBox pidTextBox;
        private System.Windows.Forms.Button addPidbutton;
        private System.Windows.Forms.Button removePidButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}

