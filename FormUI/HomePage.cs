using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class HomePage : Form
    {

        List<Person> people = new List<Person>();
        public HomePage()
        {
            InitializeComponent();
        }

        private void homepageRegisterButton_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.ShowDialog();
        }

        private void homepageConfirmButton_Click(object sender, EventArgs e)
        {
            ShowDetailsForm s = new ShowDetailsForm(homepageFirstNameTextBox.Text, homepageLastNameTextBox.Text);
            s.ShowDialog();


                                   
        }
    }
}
