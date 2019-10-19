namespace JasperSerialApp
{
    partial class SerialCommunication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHandShake = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbData = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.btnSPortRefresh = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHandShake);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.lblBaudRate);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings(설정)";
            // 
            // cmbHandShake
            // 
            this.cmbHandShake.FormattingEnabled = true;
            this.cmbHandShake.Location = new System.Drawing.Point(171, 118);
            this.cmbHandShake.Name = "cmbHandShake";
            this.cmbHandShake.Size = new System.Drawing.Size(149, 20);
            this.cmbHandShake.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "핸드쉐이크(Handshake)";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(171, 94);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(149, 20);
            this.cmbParity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "패리티(Parity)";
            // 
            // cmbData
            // 
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Location = new System.Drawing.Point(171, 69);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(149, 20);
            this.cmbData.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "데이타(Data)";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(171, 45);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(149, 20);
            this.cmbBaudRate.TabIndex = 3;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(15, 50);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(141, 12);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "보오드레이트(BaudRate)";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(171, 20);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(149, 20);
            this.cmbPort.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(15, 25);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(61, 12);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "포트(Port)";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 199);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(164, 37);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "연결(Connect)";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "메시지(Messages)";
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 12;
            this.lstMessages.Location = new System.Drawing.Point(363, 50);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(268, 148);
            this.lstMessages.TabIndex = 5;
            // 
            // btnSPortRefresh
            // 
            this.btnSPortRefresh.Location = new System.Drawing.Point(184, 199);
            this.btnSPortRefresh.Name = "btnSPortRefresh";
            this.btnSPortRefresh.Size = new System.Drawing.Size(164, 37);
            this.btnSPortRefresh.TabIndex = 6;
            this.btnSPortRefresh.Text = "포트 새로고침\r\n(Serial Port Refresh)";
            this.btnSPortRefresh.UseVisualStyleBackColor = true;
            this.btnSPortRefresh.Click += new System.EventHandler(this.btnSPortRefresh_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(363, 212);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(162, 21);
            this.txtMessages.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(531, 211);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "전송(Send)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // SerialCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 247);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnSPortRefresh);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialCommunication";
            this.Text = "SerialCommunication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbHandShake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Button btnSPortRefresh;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnSend;
    }
}