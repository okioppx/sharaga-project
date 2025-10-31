using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.Models;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        private readonly DBService dBService;
        public Form2()
        {
            InitializeComponent();
            dBService = new DBService("Data Source = Cab109,49172;" +
               "Initial Catalog = Nedviga;" +
               "Integrated Security = True");
            List<Property> properties = dBService.GetAvailableProperties();
            cmbaddress.DataSource = properties;
            cmbaddress.DisplayMember = "Address";
            List<Agent> agents = dBService.GetAllAgents();
            cmbagent.DataSource = agents;
            cmbagent.DisplayMember = "FullName";
            List<Client> clients = dBService.GetAllClients();
            cmbclient.DataSource = clients;
            cmbclient.DisplayMember = "FullName";
        }

       
        private void cmbb_SelectedIndexChanged(object sender, EventArgs e)
        {  
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Viewing newViewing = new Viewing();
            newViewing.ViewingId = 0;
            newViewing.PropertyId = ((Property)cmbaddress.SelectedItem).PropertyId;
            newViewing.AgentId = ((Agent)cmbagent.SelectedItem).AgentId;
            newViewing.ClientId = ((Client)cmbclient.SelectedItem).ClientId;
            newViewing.ScheduledDate = dtp.Value;
  
            dBService.AddViewing(newViewing);
            
        }
    }
}
