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
    public partial class ShowDetailsForm : Form
    {
        List<Person> people = new List<Person>();
        public ShowDetailsForm()
        {
            InitializeComponent();
        }

        public ShowDetailsForm(string FirstName, string LastName)
        {
            InitializeComponent();
            detailsFormFNRetrieveLabel.Text = FirstName;
            detailsFormLNRetrieveLabel.Text = LastName;

            DataAccess db = new DataAccess();
            people = db.GetPersonByFirstNameAndLastName(FirstName,LastName);

            detailsFormIDRetrieveLabel.Text = people[0].id.ToString();
            detailsFormEmailRetrieveLabel.Text = people[0].EmailAddress;
            detailsFormPhoneRetrieveLabel.Text = people[0].PhoneNumber;

        }

        private void detailsFormSearchButton_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.ShowDialog();

        }

        private void detailsFormUpdateButton_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(detailsFormIDRetrieveLabel.Text,detailsFormFNRetrieveLabel.Text, detailsFormLNRetrieveLabel.Text, 
                                        detailsFormEmailRetrieveLabel.Text, detailsFormPhoneRetrieveLabel.Text);
            d.ShowDialog();
        }

        private void detailsFormDeleteButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.Person_Delete(detailsFormIDRetrieveLabel.Text);
        }
    }
}
