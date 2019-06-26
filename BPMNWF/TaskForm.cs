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
    public partial class TaskForm : Form
    {
        Model.RestApp restApp;
        Model.Entity.ProcessInstance processInstance;
        Model.DAO.TaskDAO taskDAO;
        Model.DAO.FormDAO formDAO;
        Model.Entity.FormData newForm = new Model.Entity.FormData();
        public TaskForm()
        {
            InitializeComponent();
        }

        public TaskForm(Model.RestApp restApp, Model.Entity.ProcessInstance processInstance)
        {
            InitializeComponent();

            this.restApp = restApp;
            this.processInstance = processInstance;
            this.taskDAO = new Model.DAO.TaskDAO(restApp);
            formDAO = new Model.DAO.FormDAO(restApp);

            fillListBoxTask();
        }

        private void fillListBoxTask()
        {
            Model.Entity.Tasks tasks = taskDAO.getTasks();
            
            foreach (var task in tasks.data)
                task.form = formDAO.getForm(task.id);

            this.listBoxTask.Items.Clear();

            if (tasks != null)
                foreach (var each in tasks.data)
                    if (each.processInstanceId == processInstance.id)
                        this.listBoxTask.Items.Add(each);
                    else
                        Console.WriteLine("NULL");
        }
        
        private void buttonMake_Click(object sender, EventArgs e)
        {
            Model.Entity.Task task = (Model.Entity.Task)this.listBoxTask.SelectedItem;

            if (this.newForm != null)
                formDAO.postForm(newForm);

            if (task != null)
                taskDAO.endTask(task.id);
            fillListBoxTask();
            
        }


        private void listBoxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Model.Entity.Task)this.listBoxTask.SelectedItem;
            this.panel1.Controls.Clear();

            if (selected != null && selected.form != null && selected.form.FormProperties != null)
            {

                Console.WriteLine("##################");
                newForm = new Model.Entity.FormData();
                newForm.TaskId = selected.form.TaskId;
                newForm.Properties = new List<Model.Entity.NewFormProperty>();
                int y = 0;
                foreach (var prop in selected.form.FormProperties)
                {
                    if (prop.Type == "enum")
                    {
                        AddDropdown(prop, selected.form, y);
                    }
                    else if (prop.Type == "string" || prop.Type == "long")
                    {
                        AddInput(prop, y);
                    }
                    y += 25;
                }
            }
        }
        

        private void AddInput(Model.Entity.FormProperty formProperty, int y)
        {
            var label = new Label();
            label.Text = formProperty.Name;
            label.Location = new Point(0, y);

            var textBox = new TextBox();
            textBox.Location = new Point(150, y);
            textBox.Size = new System.Drawing.Size(319, 21);
            textBox.TabIndex = 2;

            textBox.TextChanged += new EventHandler(delegate (Object o, EventArgs a)
            {

                var value = textBox.Text;
                var property = new Model.Entity.NewFormProperty()
                {
                    Id = formProperty.Id,
                    Value = value
                };
                try
                {
                    var find = this.newForm.Properties.Find(e => e.Id == property.Id);
                    find.Value = property.Value;
                }
                catch (Exception e)
                {
                    this.newForm.Properties.Add(property);
                }

            });
            this.panel1.Controls.Add(textBox);
            this.panel1.Controls.Add(label);
        }

        private void AddDropdown(Model.Entity.FormProperty formProperty, Model.Entity.Form form, int y)
        {
            var label = new Label();
            label.Text = formProperty.Name;
            label.Location = new Point(0, y);
            
            var comboBox = new ComboBox();
            comboBox.Location = new Point(100, y);
            comboBox.Name = formProperty.Id;
            comboBox.Size = new System.Drawing.Size(200, 20);
            comboBox.TabIndex = 2;
            comboBox.Items.Clear();
            foreach (var p in formProperty.EnumValues)
            {
                if (p != null || p.Name != null)
                {
                    comboBox.Items.Add(p);

                }
            }
            comboBox.SelectedIndexChanged += new EventHandler(delegate (Object o, EventArgs a)
            {

                var selected = (Model.Entity.EnumValue)comboBox.SelectedItem;
                var property = new Model.Entity.NewFormProperty()
                {
                    Id = formProperty.Id,
                    Value = selected.Name
                };
                try
                {
                    var find = this.newForm.Properties.Find(e => e.Id == property.Id);
                    find.Value = property.Value;
                }
                catch (Exception e)
                {
                    this.newForm.Properties.Add(property);
                }

            });
            this.panel1.Controls.Add(comboBox);
            this.panel1.Controls.Add(label);
        }
    }
}
