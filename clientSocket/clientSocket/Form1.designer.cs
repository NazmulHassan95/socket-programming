namespace clientSocket
{
    partial class Form1
    {
        // Required designer variable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IpServerAddLable = new System.Windows.Forms.Label();
            this.IpAddTextBox = new System.Windows.Forms.TextBox();
            this.PortToConnectTextBox = new System.Windows.Forms.TextBox();
            this.PortOfServerLabel = new System.Windows.Forms.Label();
            this.ClickConnectButton = new System.Windows.Forms.Button();
            this.DisplayMsgBoxText = new System.Windows.Forms.TextBox();
            this.SendMsgToServerBoxText = new System.Windows.Forms.TextBox();
            this.ClickToSendButton = new System.Windows.Forms.Button();
            this.CLoseTheFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // IpServerAddLable
            this.IpServerAddLable.AutoSize = true;
            this.IpServerAddLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpServerAddLable.Location = new System.Drawing.Point(11, 26);
            this.IpServerAddLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IpServerAddLable.Name = "IpServerAddLable";
            this.IpServerAddLable.Size = new System.Drawing.Size(80, 19);
            this.IpServerAddLable.TabIndex = 0;
            this.IpServerAddLable.Text = "Server\'s IP";

            // IpAddTextBox
            this.IpAddTextBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IpAddTextBox.Location = new System.Drawing.Point(95, 24);
            this.IpAddTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IpAddTextBox.Name = "IpAddTextBox";
            this.IpAddTextBox.Size = new System.Drawing.Size(272, 26);
            this.IpAddTextBox.TabIndex = 1;

            // PortToConnectTextBox
            this.PortToConnectTextBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortToConnectTextBox.Location = new System.Drawing.Point(485, 24);
            this.PortToConnectTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortToConnectTextBox.Name = "PortToConnectTextBox";
            this.PortToConnectTextBox.Size = new System.Drawing.Size(139, 26);
            this.PortToConnectTextBox.TabIndex = 3;

            // PortOfServerLabel
            this.PortOfServerLabel.AutoSize = true;
            this.PortOfServerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortOfServerLabel.Location = new System.Drawing.Point(384, 26);
            this.PortOfServerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortOfServerLabel.Name = "PortOfServerLabel";
            this.PortOfServerLabel.Size = new System.Drawing.Size(97, 19);
            this.PortOfServerLabel.TabIndex = 2;
            this.PortOfServerLabel.Text = "Server\'s Port";

            // ClickConnectButton
            this.ClickConnectButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ClickConnectButton.Location = new System.Drawing.Point(245, 71);
            this.ClickConnectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClickConnectButton.Name = "ClickConnectButton";
            this.ClickConnectButton.Size = new System.Drawing.Size(172, 30);
            this.ClickConnectButton.TabIndex = 4;
            this.ClickConnectButton.Text = "Connect to this server";
            this.ClickConnectButton.UseVisualStyleBackColor = true;
            this.ClickConnectButton.Click += new System.EventHandler(this.ClickToConnect);

            // DisplayMsgBoxText
            this.DisplayMsgBoxText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayMsgBoxText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMsgBoxText.Location = new System.Drawing.Point(11, 237);
            this.DisplayMsgBoxText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DisplayMsgBoxText.Multiline = true;
            this.DisplayMsgBoxText.Name = "DisplayMsgBoxText";
            this.DisplayMsgBoxText.ReadOnly = true;
            this.DisplayMsgBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayMsgBoxText.Size = new System.Drawing.Size(613, 163);
            this.DisplayMsgBoxText.TabIndex = 5;

            // SendMsgToServerBoxText
            this.SendMsgToServerBoxText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMsgToServerBoxText.Location = new System.Drawing.Point(11, 138);
            this.SendMsgToServerBoxText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendMsgToServerBoxText.Multiline = true;
            this.SendMsgToServerBoxText.Name = "SendMsgToServerBoxText";
            this.SendMsgToServerBoxText.Size = new System.Drawing.Size(356, 25);
            this.SendMsgToServerBoxText.TabIndex = 6;

            // ClickToSendButton
            this.ClickToSendButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.ClickToSendButton.Location = new System.Drawing.Point(375, 137);
            this.ClickToSendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClickToSendButton.Name = "ClickToSendButton";
            this.ClickToSendButton.Size = new System.Drawing.Size(249, 26);
            this.ClickToSendButton.TabIndex = 7;
            this.ClickToSendButton.Text = "Send Message to Server";
            this.ClickToSendButton.UseVisualStyleBackColor = true;
            this.ClickToSendButton.Click += new System.EventHandler(this.ClickToSend_Button);

            // CLoseTheFormButton
            this.CLoseTheFormButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLoseTheFormButton.Location = new System.Drawing.Point(245, 181);
            this.CLoseTheFormButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CLoseTheFormButton.Name = "CLoseTheFormButton";
            this.CLoseTheFormButton.Size = new System.Drawing.Size(158, 40);
            this.CLoseTheFormButton.TabIndex = 8;
            this.CLoseTheFormButton.Text = "Close Connection";
            this.CLoseTheFormButton.UseVisualStyleBackColor = true;
            this.CLoseTheFormButton.Click += new System.EventHandler(this.ClickToCloseButton);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(635, 409);
            this.Controls.Add(this.CLoseTheFormButton);
            this.Controls.Add(this.ClickToSendButton);
            this.Controls.Add(this.SendMsgToServerBoxText);
            this.Controls.Add(this.DisplayMsgBoxText);
            this.Controls.Add(this.ClickConnectButton);
            this.Controls.Add(this.PortToConnectTextBox);
            this.Controls.Add(this.PortOfServerLabel);
            this.Controls.Add(this.IpAddTextBox);
            this.Controls.Add(this.IpServerAddLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label IpServerAddLable;
        private System.Windows.Forms.TextBox IpAddTextBox;
        private System.Windows.Forms.TextBox PortToConnectTextBox;
        private System.Windows.Forms.Label PortOfServerLabel;
        private System.Windows.Forms.Button ClickConnectButton;
        private System.Windows.Forms.TextBox DisplayMsgBoxText;
        private System.Windows.Forms.TextBox SendMsgToServerBoxText;
        private System.Windows.Forms.Button ClickToSendButton;
        private System.Windows.Forms.Button CLoseTheFormButton;
    }
}