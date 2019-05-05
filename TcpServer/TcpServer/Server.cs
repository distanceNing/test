using System;
using System.Xml;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
namespace TcpServer
{
    public partial class Server : Form
    {
        private TcpClient client;
        private TcpListener server;
        const int buffer_size = 4096;
        private String recv_buffer;
        public Server()
        {
            InitializeComponent();
            recv_buffer = "";
        }
        struct AddrInfo {
            public string ip;
            public string port;
        }
        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddrInfo addr_info = new AddrInfo();
            if (text_ip_addr.Text.Trim() != string.Empty)
            {
                addr_info.ip = this.text_ip_addr.Text;
            } else {
                MessageBox.Show("ip addr is empty ! ");
                return;
            }
            
            if (text_port.Text.Trim() != string.Empty)
            {
                addr_info.port = this.text_port.Text;
            }
            else
            {
                MessageBox.Show("port is empty ! ");
                return;
            }

            Thread thread = new Thread(reciveAndListener);
            //如果线程绑定的方法带有参数的话，那么这个参数的类型必须是object类型，所以讲ip,和端口号 写成一个结构体进行传递
            thread.Start(addr_info);


        }

        private void reciveAndListener(object ipAndPort)
        {
            AddrInfo addr_info = (AddrInfo)ipAndPort;
            IPAddress ip = IPAddress.Parse(addr_info.ip);
            try
            {
                server = new TcpListener(ip, int.Parse(addr_info.port));
                server.Start();//启动监听
                MessageBox.Show("服务端开启侦听....\n ");
            }
            catch {
                MessageBox.Show("服务端侦听失败 ");
            }
            // rtboxkehu.Invoke(new showData(rtboxkehu.AppendText), "服务端开启侦听....\n");
            while (true) { 
                //获取连接的客户端对象
                client = server.AcceptTcpClient();
                MessageBox.Show("有客户端请求连接，连接已建立！");
                NetworkStream reciveStream = client.GetStream();
                #region 循环监听客户端发来的信息
                do
                {
                    byte[] buffer = new byte[buffer_size];                        //  前面已定义buffersize=8000,类型为int
                    int msgsize;
                    try

                    {
                        lock (reciveStream)
                        {
                            msgsize = reciveStream.Read(buffer, 0, buffer_size);
                        }
                        if (msgsize == 0)
                        {
                            MessageBox.Show("客户端关闭连接");
                            break;
                        }
                        recv_buffer = Encoding.Unicode.GetString(buffer, 0, msgsize);
                        MessageBox.Show("接收到数据，请点击显示方式");
                    }
                    catch
                    {
                        MessageBox.Show("出现异常：连接已关闭 ! ");
                        // rtboxkehu.Invoke(new showData(rtboxkehu.AppendText), "\n 出现异常：连接已关闭");
                        break;
                    }
                } while (true);
                #endregion
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            rich_text_recv_data.Text = recv_buffer;
        }

        private void clear_data_Click(object sender, EventArgs e)
        {
            this.rich_text_recv_data.Clear();
            recv_buffer = "";
        }

        private void hex_button_Click(object sender, EventArgs e)
        {

            //System.Convert.ToString(0xa,10);
            if (recv_buffer == "")
            {
                return;

            }
            string[] sArray = recv_buffer.Split(' ');
            string hex_content = "";
            foreach (string str in sArray) { 
                Int64 num = 0;
                try
                {
                    num = System.Convert.ToInt64(str, 16);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(" 转换失败 ");
                }
                // Int64 x = IPAddress.HostToNetworkOrder(num);

                //StringBuilder recBuffer16 = new StringBuilder();               //定义16进制接收缓存
                hex_content  += "十六进制 ：" + String.Format("{0:X}", num).ToLower() + "\t 十进制 ：" + num.ToString() + "\n";
            }
            rich_text_recv_data.Text = hex_content;

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (text_send_data.Text.Trim() != string.Empty)
            {
                NetworkStream sendStream = client.GetStream();//获得用于数据传输的流
                byte[] buffer = Encoding.Unicode.GetBytes(text_send_data.Text.Trim());//将数据存进缓存中
                sendStream.Write(buffer, 0, buffer.Length);//最终写入流中                                                         
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
           
            rich_text_recv_data.Text = Proto.parseJson(recv_buffer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rich_text_recv_data.Text =  Proto.parseXML(recv_buffer);
           
        }
    }
}
