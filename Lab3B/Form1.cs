using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    public partial class Form_theyji_hair_shop : Form
    {
        List<Hairdresser> hairdressers = new List<Hairdresser>();
        List<Service> services = new List<Service>();
        string hairdresserPick;
        string serviceSelected;
        int clickCount = 0;
        string firstSelect;
        string secondSelect;
        double price;

        public Form_theyji_hair_shop()
        {
            hairdressers.Add(new Hairdresser("Jane", "Samley", 30));
            hairdressers.Add(new Hairdresser("Pat", "Jhonson", 45));
            hairdressers.Add(new Hairdresser("Ron", "Chambers", 40));
            hairdressers.Add(new Hairdresser("Sue", "Pallon", 50));
            hairdressers.Add(new Hairdresser("Laura", "Renkins", 55));

            services.Add(new Service("Cut", 30));
            services.Add(new Service("Wash, Blow-Dry, and Style", 20));
            services.Add(new Service("Color", 40));
            services.Add(new Service("Highlights", 50));
            services.Add(new Service("Extensions", 200));
            services.Add(new Service("Up-do", 60));

            InitializeComponent();
        }

        private void Form_theyji_hair_shop_Load(object sender, EventArgs e)
        {
            comboBox_hairdressers.Items.Add(hairdressers[0].GetFirstname() + " " + hairdressers[0].GetLasname());

            comboBox_hairdressers.Items.Add(hairdressers[1].GetFirstname() + " " + hairdressers[0].GetLasname());

            comboBox_hairdressers.Items.Add(hairdressers[2].GetFirstname() + " " + hairdressers[0].GetLasname());

            comboBox_hairdressers.Items.Add(hairdressers[3].GetFirstname() + " " + hairdressers[0].GetLasname());

            comboBox_hairdressers.Items.Add(hairdressers[4].GetFirstname() + " " + hairdressers[0].GetLasname());

            listBox_selected_services_list.Items.Add(services[0].getType());
            listBox_selected_services_list.Items.Add(services[1].getType());
            listBox_selected_services_list.Items.Add(services[2].getType());
            listBox_selected_services_list.Items.Add(services[3].getType());
            listBox_selected_services_list.Items.Add(services[4].getType());
            listBox_selected_services_list.Items.Add(services[5].getType());

            comboBox_hairdressers.SelectedItem = hairdressers[0].GetFirstname() + " " + hairdressers[0].GetLasname();

        }

        private void button_add_service_Click(object sender, EventArgs e)
        {
            clickCount++;
            hairdresserPick = comboBox_hairdressers.SelectedItem.ToString();
            serviceSelected = listBox_selected_services_list.SelectedItem.ToString();
            if (clickCount > 1)
            {
                secondSelect = serviceSelected;
                textBox_charged_items.Text = firstSelect + Environment.NewLine + secondSelect;
                firstSelect = firstSelect + Environment.NewLine + secondSelect;

            }
            else
            {
                firstSelect = hairdresserPick + Environment.NewLine + serviceSelected;
                textBox_charged_items.Text = firstSelect;

               
            }

            comboBox_hairdressers.Enabled = false;

        }
    }
}
