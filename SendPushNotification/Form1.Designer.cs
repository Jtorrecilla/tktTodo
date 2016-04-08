namespace SendPushNotification
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGoogleApiKey = new System.Windows.Forms.TextBox();
            this.btnSendPush = new System.Windows.Forms.Button();
            this.txtNotificationMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGoogleApiKey
            // 
            this.txtGoogleApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoogleApiKey.Location = new System.Drawing.Point(12, 27);
            this.txtGoogleApiKey.Name = "txtGoogleApiKey";
            this.txtGoogleApiKey.Size = new System.Drawing.Size(582, 29);
            this.txtGoogleApiKey.TabIndex = 0;
            this.txtGoogleApiKey.Text = "AIzaSyBRxUJbuPKTYmrZj0HEpuT9Eaheu7Em_CQ";
            // 
            // btnSendPush
            // 
            this.btnSendPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPush.Location = new System.Drawing.Point(12, 255);
            this.btnSendPush.Name = "btnSendPush";
            this.btnSendPush.Size = new System.Drawing.Size(148, 47);
            this.btnSendPush.TabIndex = 1;
            this.btnSendPush.Text = "Send Push";
            this.btnSendPush.UseVisualStyleBackColor = true;
            this.btnSendPush.Click += new System.EventHandler(this.btnSendPush_Click);
            // 
            // txtNotificationMessage
            // 
            this.txtNotificationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationMessage.Location = new System.Drawing.Point(12, 74);
            this.txtNotificationMessage.Multiline = true;
            this.txtNotificationMessage.Name = "txtNotificationMessage";
            this.txtNotificationMessage.Size = new System.Drawing.Size(582, 175);
            this.txtNotificationMessage.TabIndex = 2;
            this.txtNotificationMessage.Text = "This is a notification message!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 314);
            this.Controls.Add(this.txtNotificationMessage);
            this.Controls.Add(this.btnSendPush);
            this.Controls.Add(this.txtGoogleApiKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoogleApiKey;
        private System.Windows.Forms.Button btnSendPush;
        private System.Windows.Forms.TextBox txtNotificationMessage;
    }
}

