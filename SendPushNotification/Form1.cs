using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendPushNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendPush_Click(object sender, EventArgs e)
        {
            var jGcmData = new JObject();
            var jData = new JObject();

            jData.Add("message", this.txtNotificationMessage.Text);
            jGcmData.Add("to", "/topics/global");
            jGcmData.Add("data", jData);

            var url = new Uri("https://gcm-http.googleapis.com/gcm/send");
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.TryAddWithoutValidation(
                        "Authorization", "key=" + this.txtGoogleApiKey.Text);

                    Task.WaitAll(client.PostAsync(url,
                        new StringContent(jGcmData.ToString(), Encoding.Default, "application/json"))
                            .ContinueWith(response =>
                            {
                                MessageBox.Show("Message sent: check the client device notification tray.\r\n" + response);
                            }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to send GCM message: \r\n" + ex.StackTrace);
            }
        }
    }
}
