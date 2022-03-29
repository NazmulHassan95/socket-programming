namespace serverSocket
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.lableServerPort = new System.Windows.Forms.Label();
            this.buttonService = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.AcceptsReturn = true;
            this.textBoxDisplay.Location = new System.Drawing.Point(15, 226);
            this.textBoxDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDisplay.Size = new System.Drawing.Size(610, 171);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // lableServerPort
            // 
            this.lableServerPort.AutoSize = true;
            this.lableServerPort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableServerPort.Location = new System.Drawing.Point(362, 31);
            this.lableServerPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableServerPort.Name = "lableServerPort";
            this.lableServerPort.Size = new System.Drawing.Size(107, 19);
            this.lableServerPort.TabIndex = 1;
            this.lableServerPort.Text = "Assigned Port:";
            this.lableServerPort.Click += new System.EventHandler(this.lableServerPort_Click);
            // 
            // buttonService
            // 
            this.buttonService.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonService.Location = new System.Drawing.Point(239, 86);
            this.buttonService.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(180, 39);
            this.buttonService.TabIndex = 2;
            this.buttonService.Text = "Start Listening";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(473, 28);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(152, 26);
            this.textBoxPort.TabIndex = 3;
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerIP.Location = new System.Drawing.Point(11, 28);
            this.labelServerIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(88, 19);
            this.labelServerIP.TabIndex = 4;
            this.labelServerIP.Text = "IP Address: ";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(103, 28);
            this.labelIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(53, 19);
            this.labelIP.TabIndex = 6;
            this.labelIP.Text = "0.0.0.0";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(15, 145);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(345, 26);
            this.textBoxSend.TabIndex = 9;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonSend.Location = new System.Drawing.Point(366, 145);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(259, 26);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Send Message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonFile.Location = new System.Drawing.Point(15, 177);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(297, 32);
            this.buttonFile.TabIndex = 12;
            this.buttonFile.Text = "Send File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(328, 177);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(297, 32);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close Connection";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(636, 409);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelServerIP);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonService);
            this.Controls.Add(this.lableServerPort);
            this.Controls.Add(this.textBoxDisplay);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Label lableServerPort;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonClose;
    }
}