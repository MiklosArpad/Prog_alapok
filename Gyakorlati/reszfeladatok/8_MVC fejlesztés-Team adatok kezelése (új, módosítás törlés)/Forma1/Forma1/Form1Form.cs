using Forma1.Controller;
using Forma1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        F1Controller controller;
        public Form1Form()
        {
            controller = new F1Controller();
            InitializeComponent();
        }

        private void buttonInitializeData_Click(object sender, EventArgs e)
        {
            controller.provideTestData();
            listBoxTeam.DataSource = controller.getTeamNames();
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            textBoxTeamName.Text = teamName;
            listBoxRacer.DataSource = controller.getRacerNames(teamName);
        }

        private void listBoxRacer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0 || listBoxRacer.SelectedIndex<0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerName = listBoxRacer.SelectedItem.ToString();
            Racer selectedRacer = controller.searchRacerByName(teamName, racerName);
            textBoxRacerName.Text = selectedRacer.getName();
            textBoxRacerAge.Text = selectedRacer.getAge().ToString();
            textBoxRacerSalary.Text = selectedRacer.getSalary().ToString();
        }
    }
}
