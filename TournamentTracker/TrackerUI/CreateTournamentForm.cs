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
using TrackerUI.Requesters;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {

        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All(); //get from db: TeamName to display.
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void TeamOneScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)  selectTeamDropdown.SelectedItem;

            if (team != null)
            {
                selectedTeams.Add(team);
                availableTeams.Remove(team);
                WireUpList();

            }
        }

        private void deleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (team != null)
            {
                availableTeams.Add(team);
                selectedTeams.Remove(team);
                WireUpList();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //call the create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show(); 

           
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm form = new CreateTeamForm(this);
            form.Show();
        }


        public void SetPrize(PrizeModel model)
        {
            //get back a PrizeModel from the form

            //take the PrizeModel and put it into our list of selected prizes.
            selectedPrizes.Add(model);
            WireUpList();

        }

        public void SetTeam(TeamModel model)
        {
            availableTeams.Add(model);
            WireUpList();
        }

        private void deleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel pm = (PrizeModel)prizesListBox.SelectedItem;

            if (pm != null)
            {
                selectedPrizes.Remove(pm);

                WireUpList();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {


                //Create tournament
                //Create tournamentEntry
                //Create tournamentPrize
                TournamentModel tournamentModel = new TournamentModel(tournamentNameValue.Text, entryFeeValue.Text, selectedTeams, selectedPrizes);

            
                GlobalConfig.Connection.CreateTournament(tournamentModel);

                TournamentLogic.CreateRounds(tournamentModel);
           

            }
            else
            {
                MessageBox.Show("Form input incorrect.");
            }
           
        }

        private bool isValid()
        {
            bool output = true;

            if (!(tournamentNameValue.Text.Length > 0))
            {
                output = false;
            }


            if (!(entryFeeValue.Text.Length > 0))
            {
                output = false;
            }

            decimal entryFee = 0;

            if (!decimal.TryParse(entryFeeValue.Text, out entryFee))
            {
                output = false;
            }

            if (entryFee <= 0)
            {
                output = false;
            }

            if (!(selectedTeams.Count > 0))
            {
                output = false;
            }

            if (!(selectedPrizes.Count > 0))
            {
                output = false;
            }

            if (!(roundsValue.Text.Length > 0))
            {
                output = false;
            }

            int rounds = 0;
            if (!int.TryParse(roundsValue.Text, out rounds))
            {
                output = false;
            }

            if (!(rounds >= 1))
            {
                output = false;
            }

            return output;

        }
    }
}
