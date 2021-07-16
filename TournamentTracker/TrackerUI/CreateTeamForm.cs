using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();

            WireUpList();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Essa", LastName = "Khan" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Joe", LastName = "Rogz" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Xandar", LastName = "Dee" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Joseph", LastName = "Jogi" });
        }

        private void WireUpList()
        {
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;  

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
             
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {

                PersonModel person = new PersonModel(
                    firstNameValue.Text, lastNameValue.Text, emailValue.Text, cellphoneValue.Text);

                //send person to db and retrieve one with the ID

                person = GlobalConfig.Connection.CreatePerson(person);

                selectedTeamMembers.Add(person);

                WireUpList();

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

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel) selectTeamMemberDropdown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpList();  
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpList(); 
            }

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;

            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            // TODO - if we arent closing this form after creation then reset the form.

        }
    }
}
