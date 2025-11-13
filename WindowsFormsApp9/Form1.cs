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
        private bool IsVisibleHistory = false;
        private bool IsVisibleAdd = false;

        public Form1()
        {
            InitializeComponent();
            button3.Text = "Показать историю \n просмотров";
            dBService = new DBService(
                "Data Source = Cab109,49172;"
                    + "Initial Catalog = Nedviga;"
                    + "Integrated Security = True"
            );
            dgvProperties.DataSource = dBService.GetAvailableProperties();
            dgvProperties.Columns["PropertyId"].Visible = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panel.Visible = IsVisibleAdd;
            dgvhistory.Location = new Point(298, 244);
            if (IsVisibleAdd)
            {
                btnadd.Text = "Скрыть добавление \n объекта";
                IsVisibleAdd = false;
            }
            else
            {
                btnadd.Text = "Добавить объект ";
                IsVisibleAdd = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                dgvhistory.Location = new Point(2, 244);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сбой", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel.Visible = false;
                dgvhistory.Location = new Point(2, 244);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsVisibleHistory)
            {
                button3.Text = "Показать историю просмотров";
                IsVisibleHistory = false;
            }
            else
            {
                button3.Text = "Скрыть историю \n просмотров";
                IsVisibleHistory = true;
            }
            dgvhistory.Visible = IsVisibleHistory;
        }

        private void dgvProperties_SelectionChanged(object sender, EventArgs e)
        {
            var data = dgvProperties.CurrentRow.DataBoundItem;
            dgvhistory.DataSource = dBService
                .GetViewingsByProperty(((Property)data).PropertyId)
                .Tables[0];
            dgvhistory.Columns["ViewingId"].Visible = false;
        }

        // ваня спич срочно нужен калькулятор
    }
}
