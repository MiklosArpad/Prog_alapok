using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Forma1.controller;
using Forma1.myexeption;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        /// <summary>
        /// A megfelelő helyen a kódban jelenítse meg a kijelölt csapat versenyzőit a listBox-ban
        /// </summary>
        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0)
            {
                textBoxNewTeamName.Text = string.Empty;
                comboBoxTeamMove.DataSource = null;
                return;
            }
            string teamName = listBoxTeam.SelectedItem.ToString();
            //Ide írja a kifejlesztendő kód folytatását! A null nem jó!

            List<string> racerNames = controller.getTeamRacersName(teamName);

            listBoxRacer.DataSource = null;
            listBoxRacer.DataSource = racerNames; //controller.getTeamRacersName(teamName)


            if (racerNames.Count > 0)
            {
                textBoxNewTeamName.Text = teamName;
                comboBoxTeamMove.DataSource = controller.getTeamNameListExclude(teamName);
            }
            else
            {
                textBoxNewTeamName.Text = string.Empty;
                comboBoxTeamMove.DataSource = null;
            }
        }

        /// <summary>
        /// A kódot a megfelelő helyen folytassa!
        /// Vegye fel az új csapat nevét és frissítse a listát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = textBoxNewTeamName.Text;
            errorProviderAddTeam.Clear();
            try
            {
                controller.addTeamToF1(teamName);

                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
            }
            catch (ControllerException ce)
            {
                errorProviderAddTeam.SetError(buttonAddTeam, ce.Message);
            }
        }

        private void buttonUpdateTeam_Click(object sender, EventArgs e)

        {
            errorProviderUpdateTeam.Clear();
            try
            {
                string newTeamName = textBoxNewTeamName.Text;
                string oldTeamName = listBoxTeam.SelectedItem.ToString();
                controller.modifyTeamName(oldTeamName, newTeamName);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
            }
            catch (ControllerException ce)
            {
                errorProviderUpdateTeam.SetError(buttonUpdateTeam, ce.Message);
            }
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            errorProviderDeleteTeam.Clear();
            try
            {
                string teamNameToDelete = listBoxTeam.SelectedItem.ToString();
                controller.deleteTeam(teamNameToDelete);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
                if (listBoxTeam.SelectedIndex>=0)
                {
                    string teamName = listBoxTeam.SelectedItem.ToString();
                    List<string> teamsExcludeSelected= controller.getTeamNameListExclude(teamName);
                    if (teamsExcludeSelected.Count > 0)
                        comboBoxTeamMove.DataSource = teamsExcludeSelected;
                    else
                        comboBoxTeamMove.Text = string.Empty;
                }
                else
                    comboBoxTeamMove.Text = string.Empty;
            }
            catch (ControllerException ce)
            {
                errorProviderUpdateTeam.SetError(buttonDeleteTeam, ce.Message);
            }
        }
     }
}
