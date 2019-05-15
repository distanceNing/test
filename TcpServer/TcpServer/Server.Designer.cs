namespace TcpServer
{
    partial class Server
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
            this.button1 = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_ip_addr = new System.Windows.Forms.TextBox();
            this.text_port = new System.Windows.Forms.TextBox();
            this.rich_text_recv_data = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_data = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "listen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(74, 47);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(23, 12);
            this.IP.TabIndex = 1;
            this.IP.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port：";
            // 
            // text_ip_addr
            // 
            this.text_ip_addr.Location = new System.Drawing.Point(179, 47);
            this.text_ip_addr.Name = "text_ip_addr";
            this.text_ip_addr.Size = new System.Drawing.Size(179, 21);
            this.text_ip_addr.TabIndex = 2;
            this.text_ip_addr.Text = "127.0.0.1";
            // 
            // text_port
            // 
            this.text_port.Location = new System.Drawing.Point(179, 78);
            this.text_port.Name = "text_port";
            this.text_port.Size = new System.Drawing.Size(179, 21);
            this.text_port.TabIndex = 2;
            this.text_port.Text = "8000";
            // 
            // rich_text_recv_data
            // 
            this.rich_text_recv_data.Location = new System.Drawing.Point(76, 297);
            this.rich_text_recv_data.Name = "rich_text_recv_data";
            this.rich_text_recv_data.ReadOnly = true;
            this.rich_text_recv_data.Size = new System.Drawing.Size(504, 80);
            this.rich_text_recv_data.TabIndex = 5;
            this.rich_text_recv_data.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "recv data:";
            // 
            // clear_data
            // 
            this.clear_data.Location = new System.Drawing.Point(219, 203);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(75, 23);
            this.clear_data.TabIndex = 8;
            this.clear_data.Text = "清空数据";
            this.clear_data.UseVisualStyleBackColor = true;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "数据解析";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clear_data);
            this.Controls.Add(this.rich_text_recv_data);
            this.Controls.Add(this.text_port);
            this.Controls.Add(this.text_ip_addr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.button1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ip_addr;
        private System.Windows.Forms.TextBox text_port;
        private System.Windows.Forms.RichTextBox rich_text_recv_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_data;
        private System.Windows.Forms.Button button2;
    }
}