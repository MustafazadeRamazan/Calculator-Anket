using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class Form1 : Form
    {
        public class UserFile
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string fathername { get; set; }
            public string country { get; set; }
            public string city { get; set; }
            public string phone { get; set; }
            public DateTime DOT { get; set; }
            public bool gender { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void AddUser(object sender, EventArgs e)
        {
            name_textbox.Text = "";
            surname_textbox.Text = "";
            fathername_textbox.Text = "";
            country_textbox.Text = "";
            city_textbox.Text = "";
            phone_textbox.Text = "";
            filename_textbox.Text = "";
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            UserFile file = new UserFile();

            var jsonStr = File.ReadAllText(filename_textbox.Text + ".json");
            file = JsonConvert.DeserializeObject<UserFile>(jsonStr);

            if (filename_textbox.Text == file.name && filename_textbox.Text != null)
            {

                name_textbox.Text = file.name;
                surname_textbox.Text = file.surname;
                fathername_textbox.Text = file.fathername;
                country_textbox.Text = file.country;
                city_textbox.Text = file.city;
                phone_textbox.Text = file.phone;
                DateBox.Value = file.DOT;

                if (file.gender == true)
                {
                    c_male.Checked = false;
                    c_female.Checked = true;
                }

                else
                {
                    c_male.Checked = true;
                    c_female.Checked = false;
                }
            }

            else
            {
                MessageBox.Show("Textbox is empty or Name not finded", "NOT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UserFile file = new UserFile();
            file.name   = name_textbox.Text;
            file.surname = surname_textbox.Text;
            file.fathername = fathername_textbox.Text;
            file.country = country_textbox.Text;
            file.city   = city_textbox.Text;
            file.phone  = phone_textbox.Text;
            file.DOT  = DateBox.Value;

            if (c_female.Checked)
            {
                file.gender = true;
            }

            else
            {
                file.gender=false;
            }

            var str = JsonConvert.SerializeObject(file, Newtonsoft.Json.Formatting.Indented);           
            File.WriteAllText(name_textbox.Text+".json", str);

            MessageBox.Show("Your info was saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            name_textbox.Text = "";
            surname_textbox.Text = "";
            fathername_textbox.Text = "";
            country_textbox.Text = "";
            city_textbox.Text = "";
            phone_textbox.Text = "";
            filename_textbox.Text = "";
        }
    }
}
