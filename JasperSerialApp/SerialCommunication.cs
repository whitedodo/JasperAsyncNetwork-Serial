/*
 * Created Date: 2019-10-18
 * Subject: 시리얼포트 프로그램
 * FileName: SerialCommunication.cs
 * Author: Dodo (rabbit.white@daum.net)
 * Description:
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasperSerialApp
{
    public partial class SerialCommunication : Form
    {
        const int CONNECTED = 1;
        const int DISCONNECTED = 2;
        const int SEND = 3;
        const int RECV = 4;
        const int SUCCESS = 5;
        const int FAILOVER = 6;

        private int state;

        private SerialPort sp;

        public SerialCommunication()
        {
            InitializeComponent();
            initGetValue();

            state = DISCONNECTED;
            sp = new SerialPort();
        }

        public void initGetValue()
        {

            // cmbBaudRate
            cmbBaudRate.Items.Add(115200);
            cmbBaudRate.Items.Add(57600);
            cmbBaudRate.Items.Add(38400);
            cmbBaudRate.Items.Add(19200);
            cmbBaudRate.Items.Add(9600);

            // cmbData
            cmbData.Items.Add(8);
            cmbData.Items.Add(7);
            cmbData.Items.Add(6);

            // cmbParity
            cmbParity.Items.Add("none");
            cmbParity.Items.Add("even");
            cmbParity.Items.Add("mark");
            cmbParity.Items.Add("odd");
            cmbParity.Items.Add("space");

            // cmbHandShake
            cmbHandShake.Items.Add("none");
            cmbHandShake.Items.Add("Xon/Xoff");
            cmbHandShake.Items.Add("request to send");
            cmbHandShake.Items.Add("request to send Xon/Xoff");

            // 시리얼포트 목록 갱신
            cmbPort.DataSource = SerialPort.GetPortNames();
            if (cmbPort.SelectedIndex != -1)
            {
                cmbPort.SelectedIndex = 0;
            }

            cmbBaudRate.SelectedIndex = 4;
            cmbData.SelectedIndex = 0;
            cmbParity.SelectedIndex = 0;
            cmbHandShake.SelectedIndex = 0;
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbPort.Text == "")
            {
                MessageBox.Show("포트를 선택하세요.\n(Please select a port.)", "메시지(Messages)");
            }
            else if ( cmbPort.Enabled == true )
            {
                sp.PortName = cmbPort.Text;
                sp.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                sp.DataBits = Convert.ToInt32(cmbData.Text);

                if (cmbParity.Text.Equals("none") == true)
                {
                    sp.Parity = Parity.None;
                }
                else if (cmbParity.Text.Equals("even") == true)
                {
                    sp.Parity = Parity.Even;
                }
                else if (cmbParity.Text.Equals("mark") == true)
                {
                    sp.Parity = Parity.Mark;
                }
                else if (cmbParity.Text.Equals("odd") == true)
                {
                    sp.Parity = Parity.Odd;
                }
                else if (cmbParity.Text.Equals("space") == true)
                {
                    sp.Parity = Parity.Space;
                }

                if (cmbHandShake.Text.Equals("none") == true)
                {
                    sp.Handshake = Handshake.None;
                }
                else if (cmbHandShake.Text.Equals("Xon/Xoff") == true)
                {
                    sp.Handshake = Handshake.XOnXOff;
                }
                else if (cmbHandShake.Text.Equals("request to send") == true)
                {
                    sp.Handshake = Handshake.RequestToSend;
                }
                else if (cmbHandShake.Text.Equals("request to send Xon/Xoff") == true)
                {
                    sp.Handshake = Handshake.RequestToSendXOnXOff;
                }

                // 시리얼 포트 열기
                try
                {
                    sp.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                    sp.Open();
                    cmbPort.Enabled = false;
                    cmbBaudRate.Enabled = false;
                    cmbData.Enabled = false;
                    cmbParity.Enabled = false;
                    cmbHandShake.Enabled = false;

                    btnConnect.Text = "연결끊기(Disconnect)";
                    state = CONNECTED;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "메시지(Messages)");
                    state = DISCONNECTED;
                }

            }
            else if ( cmbPort.Enabled == false )
            {
                cmbPort.Enabled = true;
                cmbBaudRate.Enabled = true;
                cmbData.Enabled = true;
                cmbParity.Enabled = true;
                cmbHandShake.Enabled = true;

                btnConnect.Text = "연결(Connect) ";
                sp.Close();
                state = DISCONNECTED;
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                sp.WriteLine(txtMessages.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                String data = sp.ReadLine();
                lstMessages.Items.Add(data);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSPortRefresh_Click(object sender, EventArgs e)
        {
            // 시리얼포트 목록 갱신
            cmbPort.DataSource = SerialPort.GetPortNames();
            if (cmbPort.SelectedIndex != -1)
            {
                cmbPort.SelectedIndex = 0;
            }

        }
    }
}
