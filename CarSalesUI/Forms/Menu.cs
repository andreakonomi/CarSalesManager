using CarSalesUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSalesUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            bool openedForm = PromptFormIfAlreadyOpen("Settings");

            if (!openedForm)
            {
                Settings settings = new Settings();
                settings.Show();
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            bool openedForm = PromptFormIfAlreadyOpen("Sales");

            if (!openedForm)
            {
                Sales sales = new Sales();
                sales.Show();
            }
        }

        private bool PromptFormIfAlreadyOpen(string requestedForm)
        {
            FormCollection forms = Application.OpenForms;

            //Check if form is already open, if yes prompt it to user
            foreach (Form frm in forms)
            {
                if (frm.Name == requestedForm)
                {
                    frm.WindowState = FormWindowState.Normal;
                    frm.Show();
                    frm.Focus();

                    return true;
                }
            }

            return false;
        }
    }
}
