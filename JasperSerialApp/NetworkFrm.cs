/*
 *  Subject: JasperSerial&Network App
    Author: Dodo / rabbit.white@daum.net
    Created Date: 2019-10-19
    FileName: NetworkFrm.cs
    Description:

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasperSerialApp
{
    public partial class NetworkFrm : Form
    {
        // Thread signal.  
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        const int DISCONNECTED = 0;
        const int CONNECTED = 1;

        private static int portNum;
        private static int peopleNum;
        private int state;
        private Thread myThread;

        public NetworkFrm()
        {
            InitializeComponent();
            state = DISCONNECTED;

            myThread = null;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtPortNum.Text != "")
            {
                portNum = Convert.ToInt32(txtPortNum.Text);
            }
            else
            {
                portNum = -1;
            }

            if (txtPeopleNum.Text != "")
            {
                peopleNum = Convert.ToInt32(txtPeopleNum.Text);
            }
            else
            {
                peopleNum = -1;
            }

            if (state == DISCONNECTED &&
                portNum != -1 &&
                peopleNum != -1)
            {

                state = CONNECTED;
                myThread = new Thread(th_gui_server);    // worker Thread 생성
                myThread.Start();

                txtMessages.Text = "서버를 시작하였습니다.(The server has started.)" +
                                    Environment.NewLine +
                                    txtMessages.Text;

                btnConnect.Text = "종료(Exit)";

            }
            else
            {
                state = DISCONNECTED;

                if (myThread != null)
                    myThread.Abort();                    // Thread 종료

                btnConnect.Text = "시작(Start)";
                txtMessages.Text = "서버를 종료하였습니다.(The server has been shutdown.)" +
                                    Environment.NewLine +
                                    txtMessages.Text;

            }

        }

        public void th_gui_server()
        {
            StartListening();
        }


        private void txtPortNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }

        }

        private void txtPeopleNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        public void StartListening()
        {
            // Establish the local endpoint for the socket.  
            // The DNS name of the computer  
            // running the listener is "host.contoso.com".  
            //IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            //IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, portNum);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(AddressFamily.InterNetwork,
             SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(peopleNum);

                while (true)
                {
                    // Set the event to nonsignaled state.  
                    allDone.Reset();

                    // 비동기 소켓을 시작하여 연결을 청취하십시오.
                    // (Start an asynchronous socket to listen for connections.)
                    
                    // Console.WriteLine("Waiting for a connection...");

                    txtMessages.Text = "(연결을 기다리는 중)Waiting for a connection..." + 
                                        Environment.NewLine + txtMessages.Text;

                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Wait until a connection is made before continuing.  
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;
            String txtContent = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket.   
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.  
                state.sb.Append(Encoding.UTF8.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read   
                // more data.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // 클라이언트에서 모든 데이터를 읽었습니다.(All the data has been read from the client).
                    // 콘솔에 표시하십시오. (client. Display it on the console.)

                    /*                  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);

                    txtMessages.Text = "Read " + content.Length +
                                       " bytes from socket. \n data : " + content +
                                       Environment.NewLine + txtMessages.Text;

                    */

                    txtContent = content.Replace("<EOF>", "");
                    txtMessages.Text = txtContent + Environment.NewLine + txtMessages.Text;

                    // Echo the data back to the client.  
                    Send(handler, content);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.UTF8.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                /*
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);
                txtMessages.Text = "Sent " + bytesSent + " bytes to clients." +
                                    Environment.NewLine + txtMessages.Text;
                */

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }

    // State object for reading client data asynchronously  
    public class StateObject
    {
        // Client  socket.  
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 1024;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
        // Received data string.  
        public StringBuilder sb = new StringBuilder();
    }


}