/*
 *  Subject: JasperSerial&Network App
    Author: Dodo / rabbit.white@daum.net
    Created Date: 2019-10-19
    FileName: MainFrm.cs
    Description:

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasperSerialApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SerialCommunication serialFrm = new SerialCommunication();
            serialFrm.Show();
            serialFrm.MdiParent = this;

        }

        private void 시리얼통신SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialCommunication serialFrm = new SerialCommunication();
            serialFrm.Show();
            serialFrm.MdiParent = this;
        }

        private void 네트워크ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkFrm networkFrm = new NetworkFrm();
            networkFrm.Show();
            networkFrm.MdiParent = this;
        }
    }
}
