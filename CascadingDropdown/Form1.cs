using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CascadingDropdown
{
    public partial class Form1 : Form
    {
        Database1Entities db = new Database1Entities();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           

            var country = from c in db.countries select c;
            cCountry.DataSource = country.ToList();
            cCountry.ValueMember = "countryID";
            cCountry.DisplayMember = "countryName";

            cCountry.SelectedItem = null;
            cCountry.Text = "---select an item---";
           
         
        }

        private void cCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                int countyID = Convert.ToInt32(cCountry.SelectedValue.ToString());
                var state = from s in db.states where s.countryID == countyID select s;
                cState.DataSource = state.ToList();
                cState.ValueMember = "stateID";
                cState.DisplayMember = "stateName";
                cState.SelectedItem = null;
                cState.Text = "---select an item---";
                
            }
            catch (Exception)
            {
                
            }
            
         
        }

        private void cState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                int stateID = Int32.Parse(cState.SelectedValue.ToString());
               
                var city = from c in db.cities where c.stateID == stateID select c;
                cCity.DataSource = city.ToList();
                cCity.Enabled = true;
                cCity.ValueMember = "cityID";
                cCity.DisplayMember = "cityName";
                cCity.SelectedItem = null;
                cCity.Text = "---select an item---";
            }
            catch (Exception)
            {
               
            }
           
        }
    }
}

