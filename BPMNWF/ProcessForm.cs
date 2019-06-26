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
    public partial class ProcessForm : Form
    {
        private Model.RestApp restApp;
        private Model.DAO.ProcessDAO processDAO;
        private Model.Entity.ProcessDefinition processDefinition;
        public ProcessForm()
        {
            InitializeComponent();
        }

        public ProcessForm(Model.RestApp restApp, Model.Entity.ProcessDefinition processDefinition)
        {
            InitializeComponent();

            this.restApp = restApp;
            this.processDAO = new Model.DAO.ProcessDAO(restApp);
            this.processDefinition = processDefinition;

            fillListBoxProcess();
        }

        private void fillListBoxProcess()
        {
            Model.Entity.ProcessInstances processInstances = processDAO.getProcessInstances();

            this.listBoxProcess.Items.Clear();

            if (processInstances != null)
                foreach (var each in processInstances.data)
                    if (each.processDefinitionId == processDefinition.id)
                        this.listBoxProcess.Items.Add(each);
            else
                Console.WriteLine("NULL");
            //foreach (var each in processDefinitionsList.data)
            //    this.listBoxProcess.Items.Add(each);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            processDAO.addProcessInstance(processDefinition.id);
            fillListBoxProcess();
        }

        private void listBoxProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(restApp, (Model.Entity.ProcessInstance)listBoxProcess.SelectedItem);
            taskForm.Show();
        }
    }
}
