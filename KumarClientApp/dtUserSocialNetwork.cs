using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace KumarClientApp
{
    public partial class dtUserSocialNetwork : Form
    {

        HttpClient client = new HttpClient();


        public dtUserSocialNetwork()
        {
            InitializeComponent();
        }

        private void WebServicesSettings()
        {
            client.BaseAddress = new Uri("http://localhost:51340/WebService1.asmx/");
        }

        private void lblDtCountries_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dtCountriesTableForm dtCountriesForm = new dtCountriesTableForm();
            dtCountriesForm.Show();
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            HttpResponseMessage message = client.GetAsync("UserSocial?id="+txtUserID+"").Result;
            string UserJson = message.Content.ReadAsStringAsync().Result;

            MessageBox.Show(UserJson);
        }

        private void dtUserSocialNetwork_Load(object sender, EventArgs e)
        {
            WebServicesSettings();
        }
    }
}
