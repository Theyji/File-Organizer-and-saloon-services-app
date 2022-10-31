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
        double basePrice;
        double servPrice;
        string firstPriceSelect;
        string secondPriceSelect;
        double SecondClickSum;
        double TotalPrice;


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

            comboBox_hairdressers.Items.Add(hairdressers[1].GetFirstname() + " " + hairdressers[1].GetLasname());

            comboBox_hairdressers.Items.Add(hairdressers[2].GetFirstname() + " " + hairdressers[2].GetLasname());

            comboBox_hairdressers.Items.Add(hairdressers[3].GetFirstname() + " " + hairdressers[3].GetLasname());

            comboBox_hairdressers.Items.Add(hairdressers[4].GetFirstname() + " " + hairdressers[4].GetLasname());

            listBox_selected_services_list.Items.Add(services[0].getType());
            listBox_selected_services_list.Items.Add(services[1].getType());
            listBox_selected_services_list.Items.Add(services[2].getType());
            listBox_selected_services_list.Items.Add(services[3].getType());
            listBox_selected_services_list.Items.Add(services[4].getType());
            listBox_selected_services_list.Items.Add(services[5].getType());

            comboBox_hairdressers.SelectedItem = hairdressers[0].GetFirstname() + " " + hairdressers[0].GetLasname();

            button_add_service.Enabled = false;
            button_calculate_total_price.Enabled = false;

        }

        public double BasePayCalc()
        {
            for (int i = 0; i < comboBox_hairdressers.Items.Count; i++)
            {
                if (hairdresserPick == hairdressers[i].GetFirstname() + " " + hairdressers[i].GetLasname())
                {
                    basePrice = hairdressers[i].GetBase();
                }
            }
            return basePrice;
        }

        public double ServPayCalc()
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (serviceSelected == services[i].getType())
                {
                    servPrice = services[i].getServiceRate();
                }
               
            }
            return servPrice;
        }

        private void button_add_service_Click(object sender, EventArgs e)
        {
            button_calculate_total_price.Enabled = true;
            clickCount++;
            hairdresserPick = comboBox_hairdressers.SelectedItem.ToString();
            serviceSelected = listBox_selected_services_list.SelectedItem.ToString();
            if (clickCount > 1)
            {
                secondSelect = serviceSelected;
                textBox_charged_items.Text = firstSelect + Environment.NewLine + secondSelect;
                firstSelect = firstSelect + Environment.NewLine + secondSelect;

                secondPriceSelect = string.Format("{0:C}", ServPayCalc());
                textBox_price.Text = firstPriceSelect + Environment.NewLine + secondPriceSelect;
                firstPriceSelect = firstPriceSelect + Environment.NewLine + secondPriceSelect;

                SecondClickSum = TotalPrice + ServPayCalc();
                TotalPrice = TotalPrice + ServPayCalc();

            }
            else
            {
                firstSelect = hairdresserPick + Environment.NewLine + serviceSelected;
                textBox_charged_items.Text = firstSelect;

                firstPriceSelect = string.Format("{0:C}", BasePayCalc()) + Environment.NewLine + string.Format("{0:C}", ServPayCalc());
                textBox_price.Text = firstPriceSelect;

                TotalPrice = BasePayCalc() + ServPayCalc();
                
            }

            comboBox_hairdressers.Enabled = false;

        }

        private void button_calculate_total_price_Click(object sender, EventArgs e)
        {
            textBox_totalPrice_display.Text = string.Format("{0:C}", TotalPrice);
        }

        private void listBox_selected_services_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add_service.Enabled = true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_totalPrice_display.Clear();
            textBox_price.Clear();
            textBox_charged_items.Clear();
            comboBox_hairdressers.Enabled = true;
            comboBox_hairdressers.SelectedItem = hairdressers[0].GetFirstname() + " " + hairdressers[0].GetLasname();
            comboBox_hairdressers.Focus();
            button_calculate_total_price.Enabled = false;
            listBox_selected_services_list.ClearSelected();
            button_add_service.Enabled = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
