using ServiceMtk_P1_015;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Muhammad_Dzalfiqri_S_015
{
    public partial class formServer : Form
    {
        private ServiceHost hostObj;

        public formServer()
        {
            InitializeComponent();
        }

        private void formServer_Load(object sender, EventArgs e)
        {

            btnON.Enabled = true;
            btnOFF.Enabled = false;
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            try
            {
                
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                Console.WriteLine("Server Jalan Boss");
                lblServer.Text = "Server ON";
                lblKet.Text = "Klik OFF untuk Mematikan Server";
                btnON.Enabled = false;
                btnOFF.Enabled = true;


            }
            catch (Exception ex)
            {
                hostObj = null;
                lblServer.Text = ex.Message;
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            try
            {

                ServiceHost hostObj = null;
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Close();
                lblServer.Text = "Server OFF";
                lblKet.Text = "Klik ON untuk Menjalankan Server";
                btnON.Enabled = true;
                btnOFF.Enabled = false;

            }

            catch (Exception ex)
            {
                hostObj = null;
                lblServer.Text = ex.Message;
            }
        }
    }
}
