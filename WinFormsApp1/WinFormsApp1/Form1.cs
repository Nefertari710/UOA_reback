using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private IPAddress ipAddr;
        private int port;
        public Form1()
        {

            InitializeComponent();
            labelShowStatus.Text = "Wait Connecting....";
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());

            ipAddr = ipHost.AddressList[0];

            port = 8081;

            try
            {
                
                labelShowStatus.Text = "Connect to Cache";
            }catch(Exception ex)
            {
                labelShowStatus.Text = "EOF " + ex.Message;
            }

        }

        // buttonShow: Show all file in the Server
        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                byte command = 0;
                client = new TcpClient(ipAddr.ToString(), port);
                using (NetworkStream stream = client.GetStream())
                {
                    stream.WriteByte(command);
                    stream.Flush();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    string response = reader.ReadToEnd();
                    string[] response_list = response.Split(",");
                    foreach (string item in response_list)
                    {
                        // 检查 listBoxShowList 中是否已经存在该元素
                        bool itemExists = false;
                        foreach (string listBoxItem in listBoxShowList.Items)
                        {
                            if (listBoxItem == item)
                            {
                                itemExists = true;
                                break;
                            }
                        }

                        // 如果 listBoxShowList 中不存在该元素，则将其添加到 listBoxShowList
                        if (!itemExists)
                        {
                            listBoxShowList.Items.Add(item);
                        }
                    }

                }
            }catch(Exception ex)
            {

            }
        }

        private void buttonDownload1_Click(object sender, EventArgs e)
        {
            try
            {
                byte command = 1;

                // 获取在listBox中选中的文件名
                string selectedItem = listBoxShowList.SelectedItem as string ?? string.Empty;

                

                // 将选择的文件名转换成字节数组
                byte[] fileNameBytes = Encoding.UTF8.GetBytes(selectedItem);

                // 将文件名的字节数组长度作为Int32（4个字节）传递给Cache
                byte[] fileNameLengthBytes = BitConverter.GetBytes(fileNameBytes.Length);   

                // 前面两位是用来存储操作码的，后面的9位最高支持在511位的windows文件夹，但是实际上最高就支持到260位
                byte[] data = new byte[5 + fileNameBytes.Length];

                data[0] = command;

                // 将fileNameLengthBytes中的文件复制到data中 源索引0 目标索引1，后面要的是长度
                Array.Copy(fileNameLengthBytes, 0, data, 1, fileNameLengthBytes.Length);

                Array.Copy(fileNameBytes, 0, data, 5, fileNameBytes.Length);

                labelDownloadFIleName.Text = selectedItem;

                TcpClient client1 = new TcpClient(ipAddr.ToString(), port);
                using (NetworkStream stream = client1.GetStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                    labelDownloadFIleName.Text = selectedItem;

                    byte[] data1_length = new byte[4];
                    stream.Read(data1_length, 0, data1_length.Length);
                    int fileNameBytesLength1 = BitConverter.ToInt32(data1_length, 0);
                    
                    // 文件内容
                    byte[] data2 = new byte[fileNameBytesLength1];
                    stream.Read(data2, 0, fileNameBytesLength1);
                    string fileContent = Encoding.UTF8.GetString(data2);
                    textBoxShowFIle.Text = fileContent;
                }
            }
            catch (Exception ex)
            {

            }
        }


        // 隔离!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void buttonDownload2_Click(object sender, EventArgs e)
        {
            try
            {
                // 操作指示码是三个时候用分片传递
                byte command = 3;

                // 获取在listBox中选中的文件名
                string selectedItem = listBoxShowList.SelectedItem as string ?? string.Empty;



                // 将选择的文件名转换成字节数组
                byte[] fileNameBytes = Encoding.UTF8.GetBytes(selectedItem);

                // 将文件名的字节数组长度作为Int32（4个字节）传递给Cache
                byte[] fileNameLengthBytes = BitConverter.GetBytes(fileNameBytes.Length);

                // 前面两位是用来存储操作码的，后面的9位最高支持在511位的windows文件夹，但是实际上最高就支持到260位
                byte[] data = new byte[5 + fileNameBytes.Length];

                data[0] = command;

                // 将fileNameLengthBytes中的文件复制到data中 源索引0 目标索引1，后面要的是长度
                Array.Copy(fileNameLengthBytes, 0, data, 1, fileNameLengthBytes.Length);

                Array.Copy(fileNameBytes, 0, data, 5, fileNameBytes.Length);

                labelDownloadFIleName.Text = selectedItem;

                TcpClient client1 = new TcpClient(ipAddr.ToString(), port);
                using (NetworkStream stream = client1.GetStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                    labelDownloadFIleName.Text = selectedItem;

                    byte[] data1_length = new byte[4];
                    stream.Read(data1_length, 0, data1_length.Length);
                    int fileNameBytesLength1 = BitConverter.ToInt32(data1_length, 0);

                    // 文件内容
                    byte[] data2 = new byte[fileNameBytesLength1];
                    stream.Read(data2, 0, fileNameBytesLength1);
                    string fileContent = Encoding.UTF8.GetString(data2);
                    textBoxShowFIle.Text = fileContent;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}