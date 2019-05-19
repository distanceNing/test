namespace Client
{
    partial class Cient
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
            this.connect = new System.Windows.Forms.Button();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.text_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richtext_send = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(496, 104);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 0;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // text_ip
            // 
            this.text_ip.Location = new System.Drawing.Point(124, 51);
            this.text_ip.Name = "text_ip";
            this.text_ip.Size = new System.Drawing.Size(158, 21);
            this.text_ip.TabIndex = 1;
            this.text_ip.Text = "127.0.0.1";
            // 
            // text_port
            // 
            this.text_port.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.text_port.Location = new System.Drawing.Point(124, 106);
            this.text_port.Name = "text_port";
            this.text_port.Size = new System.Drawing.Size(158, 21);
            this.text_port.TabIndex = 1;
            this.text_port.Text = "8000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // richtext_send
            // 
            this.richtext_send.Location = new System.Drawing.Point(124, 250);
            this.richtext_send.Name = "richtext_send";
            this.richtext_send.Size = new System.Drawing.Size(397, 94);
            this.richtext_send.TabIndex = 4;
            this.richtext_send.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 417);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richtext_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_port);
            this.Controls.Add(this.text_ip);
            this.Controls.Add(this.connect);
            this.Name = "Cient";
            this.Text = "Cient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox text_ip;
        private System.Windows.Forms.TextBox text_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtext_send;
        private System.Windows.Forms.Button button2;
    }
}