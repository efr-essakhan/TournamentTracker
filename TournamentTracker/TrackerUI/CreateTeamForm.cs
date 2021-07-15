using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {

                PersonModel person = new PersonModel(
                    firstNameValue.Text, lastNameValue.Text, emailValue.Text, cellphoneValue.Text);

                //send person to db

                GlobalConfig.Connection.CreatePerson(person);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }

        }


        private bool ValidateForm()
        {
            bool output = true;

            if (!(firstNameValue.Text.Length>0))
            {
                output = false;
            }

            if (!(lastNameValue.Text.Length > 0))
            {
                output = false;
            }
            if (!(emailValue.Text.Length > 0))
            {
                output = false;
            }
            return output;

        }

    }
}
