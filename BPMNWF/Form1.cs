using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMNWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Model.RestApp restApp = null;
            Model.DAO.ProcessDAO processDAO = null;
            Model.Entity.ProcessDefinitions processDefinitionsList = null;

            if (!textBoxUsername.Text.Equals("") || !textBoxPassword.Text.Equals(""))
                restApp = new Model.RestApp(textBoxUsername.Text, textBoxPassword.Text);

            if (restApp != null)
                processDAO = new Model.DAO.ProcessDAO(restApp);

            if (processDAO != null)
                processDefinitionsList = processDAO.getProcessDefinitions();

            if (processDefinitionsList != null)
            {
                Console.WriteLine("Good");
                ProcessDefForm processForm = new ProcessDefForm(restApp, processDefinitionsList);
                processForm.Show();

                this.Hide();
            }
            else
                Console.WriteLine("Wrong Username or Password");

        }
    }
}
