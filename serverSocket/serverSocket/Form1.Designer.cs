namespace serverSocket
{
    partial class Server
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Required method for Designer support - do not modify the contents of this method with the code editor.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.DisplayMessagesTextBox = new System.Windows.Forms.TextBox();
            this.TheServerIPAddress = new System.Windows.Forms.Label();
            this.StartServiceButton = new System.Windows.Forms.Button();
            this.PortOfServerTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressofServer = new System.Windows.Forms.Label();
            this.IPAddLable = new System.Windows.Forms.Label();
            this.SendingMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendToServerButton = new System.Windows.Forms.Button();
            this.SendFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // DisplayMessagesTextBox
            this.DisplayMessagesTextBox.AcceptsReturn = true;
            this.DisplayMessagesTextBox.Location = new System.Drawing.Point(15, 226);
            this.DisplayMessagesTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DisplayMessagesTextBox.Multiline = true;
            this.DisplayMessagesTextBox.Name = "DisplayMessagesTextBox";
            this.DisplayMessagesTextBox.ReadOnly = true;
            this.DisplayMessagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayMessagesTextBox.Size = new System.Drawing.Size(610, 171);
            this.DisplayMessagesTextBox.TabIndex = 0;

            // TheServerIPAddress
            this.TheServerIPAddress.AutoSize = true;
            this.TheServerIPAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheServerIPAddress.Location = new System.Drawing.Point(362, 31);
            this.TheServerIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TheServerIPAddress.Name = "TheServerIPAddress";
            this.TheServerIPAddress.Size = new System.Drawing.Size(107, 19);
            this.TheServerIPAddress.TabIndex = 1;
            this.TheServerIPAddress.Text = "Assigned Port:";

            // StartServiceButton
            this.StartServiceButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServiceButton.Location = new System.Drawing.Point(239, 86);
            this.StartServiceButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StartServiceButton.Name = "StartServiceButton";
            this.StartServiceButton.Size = new System.Drawing.Size(180, 39);
            this.StartServiceButton.TabIndex = 2;
            this.StartServiceButton.Text = "Start Listening";
            this.StartServiceButton.UseVisualStyleBackColor = true;
            this.StartServiceButton.Click += new System.EventHandler(this.buttonService_Click);

            // PortOfServerTextBox
            this.PortOfServerTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortOfServerTextBox.Location = new System.Drawing.Point(473, 28);
            this.PortOfServerTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortOfServerTextBox.Name = "PortOfServerTextBox";
            this.PortOfServerTextBox.Size = new System.Drawing.Size(152, 26);
            this.PortOfServerTextBox.TabIndex = 3;

            // IPAddressofServer
            this.IPAddressofServer.AutoSize = true;
            this.IPAddressofServer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressofServer.Location = new System.Drawing.Point(11, 28);
            this.IPAddressofServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPAddressofServer.Name = "IPAddressofServer";
            this.IPAddressofServer.Size = new System.Drawing.Size(88, 19);
            this.IPAddressofServer.TabIndex = 4;
            this.IPAddressofServer.Text = "IP Address: ";
            
            // IPAddLable
            this.IPAddLable.AutoSize = true;
            this.IPAddLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddLable.Location = new System.Drawing.Point(103, 28);
            this.IPAddLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPAddLable.Name = "IPAddLable";
            this.IPAddLable.Size = new System.Drawing.Size(53, 19);
            this.IPAddLable.TabIndex = 6;
            this.IPAddLable.Text = "0.0.0.0";

            // SendingMessageTextBox
            this.SendingMessageTextBox.Location = new System.Drawing.Point(15, 145);
            this.SendingMessageTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendingMessageTextBox.Multiline = true;
            this.SendingMessageTextBox.Name = "SendingMessageTextBox";
            this.SendingMessageTextBox.Size = new System.Drawing.Size(345, 26);
            this.SendingMessageTextBox.TabIndex = 9;

            // SendToServerButton
            this.SendToServerButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.SendToServerButton.Location = new System.Drawing.Point(366, 145);
            this.SendToServerButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendToServerButton.Name = "SendToServerButton";
            this.SendToServerButton.Size = new System.Drawing.Size(259, 26);
            this.SendToServerButton.TabIndex = 10;
            this.SendToServerButton.Text = "Send Message";
            this.SendToServerButton.UseVisualStyleBackColor = true;
            this.SendToServerButton.Click += new System.EventHandler(this.ClickSend);

            // SendFileButton
            this.SendFileButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.SendFileButton.Location = new System.Drawing.Point(15, 177);
            this.SendFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendFileButton.Name = "SendFileButton";
            this.SendFileButton.Size = new System.Drawing.Size(297, 32);
            this.SendFileButton.TabIndex = 12;
            this.SendFileButton.Text = "Send File";
            this.SendFileButton.UseVisualStyleBackColor = true;
            this.SendFileButton.Click += new System.EventHandler(this.SendAFileToClient);

            // Server
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(636, 409);
            this.Controls.Add(this.SendFileButton);
            this.Controls.Add(this.SendToServerButton);
            this.Controls.Add(this.SendingMessageTextBox);
            this.Controls.Add(this.IPAddLable);
            this.Controls.Add(this.IPAddressofServer);
            this.Controls.Add(this.PortOfServerTextBox);
            this.Controls.Add(this.StartServiceButton);
            this.Controls.Add(this.TheServerIPAddress);
            this.Controls.Add(this.DisplayMessagesTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox DisplayMessagesTextBox;
        private System.Windows.Forms.Label TheServerIPAddress;
        private System.Windows.Forms.Button StartServiceButton;
        private System.Windows.Forms.TextBox PortOfServerTextBox;
        private System.Windows.Forms.Label IPAddressofServer;
        private System.Windows.Forms.Label IPAddLable;
        private System.Windows.Forms.TextBox SendingMessageTextBox;
        private System.Windows.Forms.Button SendToServerButton;
        private System.Windows.Forms.Button SendFileButton;
    }
}