using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static WinFormsApp2.Cache;
using Microsoft.VisualBasic.Logging;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace WinFormsApp2
{
    public partial class Cache : Form
    {
        public Cache()
        {
            InitializeComponent();

            labelShowStatus.Text = "Wait Connecting...";
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];

            // use to connect with Client
            int port1 = 8081;

            // use to connect with Server
            int port2 = 8082;

            Thread cacheThread = new Thread(() => RunCacheServer(ipAddr, port1, port2));
            cacheThread.IsBackground = true;
            cacheThread.Start();

            string logFilePath1 = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../requestLog.txt"));
            if (File.Exists(logFilePath1))
            {
                string fileContent = File.ReadAllText(logFilePath1);
                // 将文件内容设置为 textBox 的文本
                textBoxLog.Text = fileContent;
            }
            
        }

        private void RunCacheServer(IPAddress ipAddr, int port1, int port2)
        {
            // 创造对象
            string logFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../requestLog.txt"));

            Logger logger1 = new Logger(logFilePath);

            TcpListener tcpListenerCache = new TcpListener(ipAddr, port1); 
            
            Invoke((Action)(() => labelShowStatus.Text = "Connect to Server"));

            tcpListenerCache.Start();
            string t = "12";
            while (true)
            {
                // receive
                var client = tcpListenerCache.AcceptTcpClient();
                

                NetworkStream streamClient = client.GetStream();

                // 读一位
                byte command = (byte)streamClient.ReadByte();
                Invoke((Action)(() => labelTest.Text = t));
                t = t + "ss";

                // command == 0
                if (command == 0)
                {
                    
                    Invoke((Action)(() => labelShowStatus1.Text = "Client connected"));
                    try
                    {
                        byte command1 = 0;
                        TcpClient tcpClientCache = new TcpClient(ipAddr.ToString(), port2);
                        using (NetworkStream streamServer = tcpClientCache.GetStream())
                        {
                            streamServer.WriteByte(command1);
                            streamServer.Flush();
                            // 从服务器获取数据
                            StreamReader reader = new StreamReader(streamServer, Encoding.UTF8);
                            string response = reader.ReadToEnd();

                            
                            StreamWriter writer = new StreamWriter(streamClient, Encoding.UTF8);
                            writer.Write(response);
                            writer.Flush();
                            Invoke((Action)(() => labelShowStatus2.Text = "Send back message to Client"));
                            writer.Close();
                        }
                        

                    }
                    catch (Exception ex)
                    {

                    }
                    
                }

                // command == 1
                if (command == 1) 
                { 
                    
                    byte[] data1 = new byte[4];
                    
                    streamClient.Read(data1,0, data1.Length);

                    int fileNameBytesLength = BitConverter.ToInt32(data1, 0);

                    // 创建一个副本用来保存原来的文件
                    byte[] data1_copy = new byte[data1.Length];
                    Array.Copy(data1, data1_copy, data1.Length);

                    data1 = new byte[fileNameBytesLength];

                    streamClient.Read(data1, 0, fileNameBytesLength);

                    // 创建一个副本用来保存原来的文件
                    byte[] data2_copy = new byte[data1.Length];
                    Array.Copy(data1, data2_copy, data1.Length);

                  
                    Invoke((Action)(() => labelShowStatus2.Text = data2_copy.Length.ToString() ));
                    string fileName = Encoding.UTF8.GetString(data1);   

                    string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(),"../../../CacheData"));

                    Invoke((Action)(() => labelShowStatus3.Text = path));

                    string fileNamePath = Path.Combine(path, fileName);

                    if (File.Exists(fileNamePath)) {
                        logger1.Log("cached file " + fileName,fileName);
                        Log1("cached file " + fileName, fileName);
                        Invoke((Action)(() => labelShowStatus3.Text = "huancunlaide")); 
                    }
                    else
                    {
                        Log1("file " + fileName + " downloaded from the server", fileName);
                        logger1.Log("file " + fileName + " downloaded from the server",fileName);
                    }

                    // 创造一个流将请求信息向Server传递
                    byte[] data0 = { 1 };
                    byte[] combinedData = new byte[data0.Length + data1_copy.Length + data2_copy.Length];
                    Buffer.BlockCopy(data0, 0, combinedData, 0, data0.Length);
                    Buffer.BlockCopy(data1_copy, 0, combinedData, data0.Length, data1_copy.Length);
                    Buffer.BlockCopy(data2_copy, 0, combinedData, data1_copy.Length + data0.Length, data2_copy.Length);


                    string dataPath1 = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CacheData",fileName));

                    TcpClient tcpClientCache1 = new TcpClient(ipAddr.ToString(), port2);
                    using (NetworkStream stream = tcpClientCache1.GetStream())
                    {
                        stream.Write(combinedData, 0, combinedData.Length);
                        stream.Flush();


                        // 开始接收
                        byte[] data1_length = new byte[4];
                        stream.Read(data1_length, 0, data1_length.Length);
                        int fileNameBytesLength1 = BitConverter.ToInt32(data1_length, 0);

                        // 文件内容
                        byte[] data2 = new byte[fileNameBytesLength1];
                        stream.Read(data2, 0, fileNameBytesLength1);
                        string fileContent = Encoding.UTF8.GetString(data2);

                        string pathCacheData = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CacheData"));

                        string dataPath = Path.Combine(pathCacheData, fileName);
                        if (File.Exists(dataPath))
                        {
                            Invoke((Action)(() => labelShowStatus3.Text = "Exist"));
                        }
                        else
                        {
                              
                            File.WriteAllBytes(dataPath, data2);

                        }

                    }
                    // 将Cache中的副本传递回去
                    byte[] fileContentCopy = File.ReadAllBytes(dataPath1);

                    byte[] fileContentLengthCopy = BitConverter.GetBytes(fileContentCopy.Length);

                    byte[] dataCombineCopy = new byte[4 + fileContentCopy.Length];
                    Array.Copy(fileContentLengthCopy, 0, dataCombineCopy, 0, fileContentLengthCopy.Length);
                    Array.Copy(fileContentCopy, 0, dataCombineCopy, fileContentLengthCopy.Length, fileContentCopy.Length);

                    streamClient.Write(dataCombineCopy, 0, dataCombineCopy.Length);
                    streamClient.Flush();
                    streamClient.Close();
                    Invoke((Action)(() => labelShowStatus3.Text = "TO CLient"));


                }
                if (command == 3) {
                    Invoke((Action)(() => labelShowStatus3.Text = "3"));

                    byte[] data1 = new byte[4];

                    streamClient.Read(data1, 0, data1.Length);

                    int fileNameBytesLength = BitConverter.ToInt32(data1, 0);

                    // 创建一个副本用来保存原来的文件
                    byte[] data1_copy = new byte[data1.Length];
                    Array.Copy(data1, data1_copy, data1.Length);

                    data1 = new byte[fileNameBytesLength];

                    streamClient.Read(data1, 0, fileNameBytesLength);

                    // 创建一个副本用来保存原来的文件
                    byte[] data2_copy = new byte[data1.Length];
                    Array.Copy(data1, data2_copy, data1.Length);


                    Invoke((Action)(() => labelShowStatus2.Text = data2_copy.Length.ToString()));
                    string fileName = Encoding.UTF8.GetString(data1);

                    string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CacheData"));

                    Invoke((Action)(() => labelShowStatus3.Text = path));

                    string fileNamePath = Path.Combine(path, fileName);

                    // 没什么用就是单纯的处理维护一下
                    if (File.Exists(fileNamePath))
                    {
                        logger1.Log("cached file " + fileName, fileName);
                        Log1("cached file " + fileName, fileName);
                        Invoke((Action)(() => labelShowStatus3.Text = "huancunlaide"));
                    }
                    else
                    {
                        Log1("file " + fileName + " downloaded from the server", fileName);
                        logger1.Log("file " + fileName + " downloaded from the server", fileName);
                    }


                    // 创造一个流将请求信息向Server传递，请求信息在combinedData中，相当于复制了一个流传到server
                    byte[] data0 = { 3 };
                    byte[] combinedData = new byte[data0.Length + data1_copy.Length + data2_copy.Length];
                    Buffer.BlockCopy(data0, 0, combinedData, 0, data0.Length);
                    Buffer.BlockCopy(data1_copy, 0, combinedData, data0.Length, data1_copy.Length);
                    Buffer.BlockCopy(data2_copy, 0, combinedData, data1_copy.Length + data0.Length, data2_copy.Length);
                    // 获取当前CacheData文件夹的位置，文件
                    string dataPath1 = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CacheData", fileName));

                    // 创建一个新的TCP链接，目标地址是服务器
                    TcpClient tcpClientCache3 = new TcpClient(ipAddr.ToString(), port2);
                    using (NetworkStream stream = tcpClientCache3.GetStream())
                    {
                        stream.Write(combinedData, 0, combinedData.Length);
                        stream.Flush();
                        

                        // 开始接收 -- 接收开始变得不同
                        // 开始需要接收回来的文件的
                        // 最后获得的就是一共传回来的信息数
                        byte[] pieceLength = new byte[4];
                        stream.Read(pieceLength, 0, pieceLength.Length);
                        int PieceLengthBytes = BitConverter.ToInt32(pieceLength, 0);

                        // 保安来了 -- 通

                        int notttt = 0;

                        for (int i = 0; i < PieceLengthBytes; i++)
                        {
                            // 接收文件类型指示符(确定是哈希还是文件块，0就是哈希，1就是文件快)
                            
                            byte PieceType = (byte)stream.ReadByte();

                            Invoke((Action)(() => labelTest.Text = PieceType.ToString()));

                            // 在这个地方我们需要接收文件的长度 HashPieceLengthInt
                            byte[] HashPieceLength = new byte[4];
                            stream.Read(HashPieceLength, 0, HashPieceLength.Length);
                            int HashPieceLengthInt = BitConverter.ToInt32(HashPieceLength, 0);

                            // 接收文件内容
                            byte[] HashPieceContentBytes = new byte[HashPieceLengthInt];
                            stream.Read(HashPieceContentBytes, 0, HashPieceContentBytes.Length);

                            // 表示这是一个hash，也就代表在Cache中可以找到块
                            if (PieceType == 0)
                            {
                                string PieceDataFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CachePieceData"));
                                string[] subdirectoryEntries = Directory.GetDirectories(PieceDataFilePath);

                                // 遍历子文件夹
                                foreach (string subdirectory in subdirectoryEntries)
                                {
                                    // 处理子文件夹中的文件
                                    string[] fileEntries = Directory.GetFiles(subdirectory);
                                    foreach (string filePath in fileEntries)
                                    {
                                        string HashPieceContentString = Encoding.UTF8.GetString(HashPieceContentBytes);

                                        if (Path.GetFileName(filePath) == HashPieceContentString)
                                        {
                                            //相同hash应该将文件块传回来
                                            Invoke((Action)(() => labelShowStatus3.Text = "应该将文件写回Client"));

                                        }
                                        
                                    }
                                }
                            }
                            // 表示这是一个块，也就代表在Cache中找不到，但是Server会传回来
                            if (PieceType == 1)
                            {
                                notttt++;
                                // 写到临时txt文件中
                                // string HashPieceContentString1 = Encoding.UTF8.GetString(HashPieceContentBytes);
                                string TemptextFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Temptext.txt"));
                                
                                File.WriteAllBytes(TemptextFilePath, HashPieceContentBytes);
                                string TempHash = ComputeFileHashCache(TemptextFilePath);

                                Invoke((Action)(() => labelShowStatus3.Text = notttt.ToString()));
                                
                                string PieceDataFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CachePieceData/Temptext.txt"));
                                // 将临时文件转移到CachePieceData中
                                File.Copy(TemptextFilePath,PieceDataFilePath, true);

                                // 将文件名修改成哈希
                                string PieceDataFileNewNamePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CachePieceData" , TempHash + ".txt"));
                                File.Move(PieceDataFilePath, PieceDataFileNewNamePath);
                            }

                        }
                        


                    }


                }
            }
        }

        // 记录日志可以使用这一点
        public class Logger
        {
            private readonly string logFilePath;
            public Logger(string logFilePath)
            {
                this.logFilePath = logFilePath;
            }
            public void Log(string message,string fileNameCopy)
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string logMessage = $"user request: file {fileNameCopy} at {timestamp} \nResponse: {message}";
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
        }

        public void Log1(string message, string fileNameCopy)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string logMessage = $"user request: file {fileNameCopy} at {timestamp} \nResponse: {message}";
            Invoke((Action)(() =>
            {
                textBoxLog.AppendText(logMessage + Environment.NewLine);
                textBoxLog.SelectionStart = textBoxLog.Text.Length;
                textBoxLog.ScrollToCaret();
            }));
        }

        private void buttonDeleteAllFile_Click(object sender, EventArgs e)
        {
            
            string folderPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CacheData"));
            string folderPiecePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../CachePieceData"));
            // 获取文件夹中的所有文件
            string[] files = Directory.GetFiles(folderPath);
            string[] files1 = Directory.GetFiles(folderPiecePath);

            bool flagHaveFile = false;
            // 遍历文件数组并逐个删除

            // 删除整个
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                    labelDeleteFIleStatus.Text = "Complete Delete all files";
                    flagHaveFile = true;
                }
                catch (Exception ex)
                {
                    // 处理删除文件时可能发生的异常
                    labelDeleteFIleStatus.Text = "Error" + ex.ToString();
                }
            }
            if (!flagHaveFile) { labelDeleteFIleStatus.Text = "Do not have files in" + folderPath; }

            // 删除碎片
            foreach (string file in files1)
            {
                try
                {
                    File.Delete(file);
                    labelDeleteFIleStatus.Text = "Complete Delete all files";
                    flagHaveFile = true;
                }
                catch (Exception ex)
                {
                    // 处理删除文件时可能发生的异常
                    labelDeleteFIleStatus.Text = "Error" + ex.ToString();
                }
            }
            if (!flagHaveFile) { labelDeleteFIleStatus.Text = "Do not have files in" + folderPath; }

            // 创建一个新的连接，目的是告诉Server删除缓存中所有文件了
            // 删除所有文件的操作码是2
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];

            // use to connect with Server
            int port2 = 8082;
            TcpClient tcpClientCacheDelete = new TcpClient(ipAddr.ToString(), port2);
            try
            {
                byte command = 2;
                using (NetworkStream stream = tcpClientCacheDelete.GetStream())
                {
                    stream.WriteByte(command);
                    stream.Flush();
                }
                labelDeleteFIleStatus.Text = "Hahah";
            }
            catch (Exception ex)
            {

            }

        }
        public static string ComputeFileHashCache(string filePath)
        {
            using (FileStream fileStream = File.OpenRead(filePath))
            using (SHA256 hashAlgorithm = SHA256.Create())
            {
                byte[] hashBytes = hashAlgorithm.ComputeHash(fileStream);
                StringBuilder hashStringBuilder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashStringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return hashStringBuilder.ToString();
            }
        }
    }
}
