using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.Models;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private readonly DBService dBService;
        public Form1()
        {
            InitializeComponent();
             dBService = new DBService("Data Source = Cab109,49172;" +
                "Initial Catalog = Nedviga;" +
                "Integrated Security = True");
            dgvProperties.DataSource = dBService.GetAvailableProperties();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Address = txtAddress.Text;
            string Type = txtType.Text;
            decimal Price = Convert.ToDecimal(txtPrice.Text);
            decimal Area = Convert.ToDecimal(txtArea.Text);
            bool Available = chkIsAvailable.Checked;
           
            
            var newProperties = new Property()
            {
                PropertyId = 0,
                Address = Address,
                Type = Type,
                Price = Price,
                Area = Area,
                IsAvailable = Available,
            };
            List<Property> properties = new List<Property>();
            dBService.AddProperty(newProperties);
            properties = dBService.GetAvailableProperties();
            
            dgvProperties.DataSource = properties;
            panel.Visible = false;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvhistory.Visible = true ;
        }

        private void dgvProperties_SelectionChanged(object sender, EventArgs e)
        {
            var data = dgvProperties.CurrentRow.DataBoundItem;
            dgvhistory.DataSource = dBService.GetViewingsByProperty(((Property)data).PropertyId);
        }

        
    }
}
