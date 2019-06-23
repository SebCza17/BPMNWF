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
    public partial class ProcessDefForm : Form
    {
        private Model.RestApp restApp;
        public ProcessDefForm()
        {
            InitializeComponent();
        }

        public ProcessDefForm(Model.RestApp restApp, Model.Entity.ProcessDefinitions processDefinitionsList)
        {
            InitializeComponent();

            this.restApp = restApp;

            fillListBoxProcess(processDefinitionsList);

        }

        private void fillListBoxProcess(Model.Entity.ProcessDefinitions processDefinitionsList)
        {
            foreach (var each in processDefinitionsList.data)
                this.listBoxProcess.Items.Add(each);
        }

        private void listBoxProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessForm processForm = new ProcessForm(restApp, (Model.Entity.ProcessDefinition)listBoxProcess.SelectedItem);
            processForm.Show();
        }
    }
}
