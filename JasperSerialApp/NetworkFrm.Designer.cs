namespace JasperSerialApp
{
    partial class NetworkFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeopleNum = new System.Windows.Forms.TextBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "서버(Server)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPeopleNum);
            this.groupBox1.Controls.Add(this.lblPeople);
            this.groupBox1.Controls.Add(this.txtPortNum);
            this.groupBox1.Controls.Add(this.lblPortNumber);
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정(Settings)";
            // 
            // txtPeopleNum
            // 
            this.txtPeopleNum.Location = new System.Drawing.Point(185, 53);
            this.txtPeopleNum.Name = "txtPeopleNum";
            this.txtPeopleNum.Size = new System.Drawing.Size(140, 21);
            this.txtPeopleNum.TabIndex = 3;
            this.txtPeopleNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeopleNum_KeyPress);
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(15, 51);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(164, 24);
            this.lblPeople.TabIndex = 2;
            this.lblPeople.Text = "허용인원\r\n(Number of people allowed)";
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(185, 23);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(140, 21);
            this.txtPortNum.TabIndex = 1;
            this.txtPortNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortNum_KeyPress);
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Location = new System.Drawing.Point(15, 26);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(134, 12);
            this.lblPortNumber.TabIndex = 0;
            this.lblPortNumber.Text = "포트번호(Port Number)";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 337);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(336, 31);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "시작(Start)";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(364, 64);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessages.Size = new System.Drawing.Size(354, 266);
            this.txtMessages.TabIndex = 3;
            // 
            // NetworkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 380);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkFrm";
            this.Text = "Network";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.Windows.Forms.TextBox txtPeopleNum;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessages;
    }
}