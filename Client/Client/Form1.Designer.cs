namespace Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientPorttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(52, 33);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(159, 20);
            this.ClientIPtextBox.TabIndex = 2;
            // 
            // ClientPorttextBox
            // 
            this.ClientPorttextBox.Location = new System.Drawing.Point(261, 33);
            this.ClientPorttextBox.Name = "ClientPorttextBox";
            this.ClientPorttextBox.Size = new System.Drawing.Size(159, 20);
            this.ClientPorttextBox.TabIndex = 3;
            this.ClientPorttextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT:";
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(52, 214);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(386, 36);
            this.MessagetextBox.TabIndex = 6;
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChatScreentextBox.Location = new System.Drawing.Point(52, 75);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.ReadOnly = true;
            this.ChatScreentextBox.Size = new System.Drawing.Size(460, 133);
            this.ChatScreentextBox.TabIndex = 7;
            this.ChatScreentextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 328);
            this.Controls.Add(this.ChatScreentextBox);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientPorttextBox);
            this.Controls.Add(this.ClientIPtextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.TextBox ClientPorttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

