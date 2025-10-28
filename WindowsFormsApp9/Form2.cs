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
    public partial class Form2 : Form
    {
        private readonly DBService dBService;
        public Form2()
        {
            InitializeComponent();
            dBService = new DBService("Data Source = Cab109,49172;" +
               "Initial Catalog = Nedviga;" +
               "Integrated Security = True");
            List<Viewing> viewings = dBService.GetViewings();
            cmbb.DataSource = dBService.GetViewings();
        }

       
        private void cmbb_SelectedIndexChanged(object sender, EventArgs e)
        {  
        }
    }
}
