namespace clientSocket
{
    partial class Form1
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelServerIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.lableServerPort = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerIP.Location = new System.Drawing.Point(50, 16);
            this.labelServerIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(80, 19);
            this.labelServerIP.TabIndex = 0;
            this.labelServerIP.Text = "Server\'s IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxIP.Location = new System.Drawing.Point(134, 14);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(161, 26);
            this.textBoxIP.TabIndex = 1;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPort.Location = new System.Drawing.Point(134, 46);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(99, 26);
            this.textBoxPort.TabIndex = 3;
            // 
            // lableServerPort
            // 
            this.lableServerPort.AutoSize = true;
            this.lableServerPort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableServerPort.Location = new System.Drawing.Point(33, 48);
            this.lableServerPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableServerPort.Name = "lableServerPort";
            this.lableServerPort.Size = new System.Drawing.Size(97, 19);
            this.lableServerPort.TabIndex = 2;
            this.lableServerPort.Text = "Server\'s Port";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConnect.Location = new System.Drawing.Point(263, 46);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(172, 30);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect to this server";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDisplay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(11, 165);
            this.textBoxDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDisplay.Size = new System.Drawing.Size(424, 259);
            this.textBoxDisplay.TabIndex = 5;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSend.Location = new System.Drawing.Point(222, 87);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(213, 26);
            this.textBoxSend.TabIndex = 6;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonSend.Location = new System.Drawing.Point(11, 87);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(207, 26);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send this message to server:";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(164, 119);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(168, 40);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close Connection";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 436);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.lableServerPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelServerIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label lableServerPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClose;
    }
}