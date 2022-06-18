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

namespace KumarClientApp
{
    public partial class dtCountriesTableForm : Form
    {

        localhost.WebService1 proxy = new localhost.WebService1();




        public dtCountriesTableForm()
        {
            InitializeComponent();
        }

        private void dtCountriesTableForm_Load(object sender, EventArgs e)
        {
            string dtCountriesJason = proxy.Countries();

            DataTable dtCountriesString = JsonConvert.DeserializeObject<DataTable>(dtCountriesJason);

            dataGridViewdtCountries.DataSource = dtCountriesString;


        }

        private void lblUserTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dtUserSocialNetwork dtUsersTable = new dtUserSocialNetwork();
            dtUsersTable.Show();
        }
    }
}
