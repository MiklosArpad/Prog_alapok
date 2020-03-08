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
using Forma1.repository;

namespace Forma1
{
    public partial class Form1Form : Form
    {

        private void listBoxRacer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRacer.SelectedIndex < 0)               
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerName = listBoxRacer.SelectedItem.ToString();
            try
            {
                Racer selectedRacer = controller.searchRacerByName(teamName, racerName);
                if (selectedRacer != null)
                {
                    textBoxRacerName.Text = selectedRacer.getName();
                    textBoxRacerAge.Text = selectedRacer.getAge().ToString();
                    textBoxRacerSalary.Text = selectedRacer.getSalary().ToString();
                }
            }
            catch (ControllerException ce)
            {
            }
        }

        private void buttonAddRacer_Click(object sender, EventArgs e)
        {
            errorProviderAddRacer.Clear();
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            string racerSalary = textBoxRacerSalary.Text;
            try
            {
                controller.addRacerToTeam(teamName, racerName, racerAge, racerSalary);
                listBoxRacer.DataSource = null;
                listBoxRacer.DataSource = controller.getTeamRacersName(teamName);
            }
            catch (ControllerException ce)
            {
                errorProviderAddRacer.SetError(buttonAddRacer, ce.Message);
            }
        }

        private void buttonUpdateRacer_Click(object sender, EventArgs e)
        {
            errorProviderUpdateRacer.Clear();
            if (listBoxTeam.SelectedIndex < 0 || listBoxRacer.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerToModify = listBoxRacer.SelectedItem.ToString();
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            string racerSalary = textBoxRacerSalary.Text;
            try
            {
                controller.updateRacerInTeam(teamName, racerToModify, racerName, racerAge, racerSalary);
                listBoxRacer.DataSource = null;
                listBoxRacer.DataSource = controller.getTeamRacersName(teamName);
            }
            catch (ControllerException ce)
            {
                errorProviderUpdateRacer.SetError(buttonUpdateRacer, ce.Message);
            }
        }

        private void buttonDeleteRacer_Click(object sender, EventArgs e)
        {
            errorProviderUpdateRacer.Clear();
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            try
            {
                controller.deleteRacerInTeam(teamName, racerName, racerAge);
                listBoxRacer.DataSource = null;                
                textBoxRacerName.Text = string.Empty;
                textBoxRacerAge.Text = string.Empty;
                textBoxRacerSalary.Text = string.Empty;
                List<string> racerNames= controller.getTeamRacersName(teamName);
                if (racerNames.Count > 0)
                {
                    listBoxRacer.DataSource = racerNames;
                    listBoxRacer.SelectedIndex = 0;
                }

            }
            catch (ControllerException ce)
            {
                errorProviderUpdateRacer.SetError(buttonDeleteRacer, ce.Message);
            }
        }

        private void buttonComputeTeamSalary_Click(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            textBoxTeamSalary.Text = controller.computeTeamSalary(teamName).ToString();
        }

        private void buttonMoveToTeam_Click(object sender, EventArgs e)
        {
            errorProviderMoveToTeam.Clear();
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string fromTeamName = listBoxTeam.SelectedItem.ToString();
            if (comboBoxTeamMove.SelectedIndex < 0)
                return;
            string toTeamName = comboBoxTeamMove.SelectedItem.ToString();
            if (listBoxRacer.SelectedIndex < 0)
                return;
            string movedRacerName = listBoxRacer.SelectedItem.ToString();
            try
            {
                controller.moveToTeam(fromTeamName, toTeamName, movedRacerName);
                listBoxRacer.DataSource = null;
                listBoxRacer.DataSource = controller.getTeamRacersName(fromTeamName);
            }
            catch(ControllerException ce)
            {
                errorProviderMoveToTeam.SetError(buttonMoveToTeam, ce.Message);
            }
        }
    }
}
