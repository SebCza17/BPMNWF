namespace BPMNWF
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTask = new System.Windows.Forms.ListBox();
            this.buttonMake = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBoxTask
            // 
            this.listBoxTask.FormattingEnabled = true;
            this.listBoxTask.Location = new System.Drawing.Point(13, 13);
            this.listBoxTask.Name = "listBoxTask";
            this.listBoxTask.Size = new System.Drawing.Size(775, 147);
            this.listBoxTask.TabIndex = 0;
            this.listBoxTask.SelectedIndexChanged += new System.EventHandler(this.listBoxTask_SelectedIndexChanged);
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(13, 166);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(75, 23);
            this.buttonMake.TabIndex = 1;
            this.buttonMake.Text = "Make";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(419, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 100);
            this.panel1.TabIndex = 2;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.listBoxTask);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTask;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Panel panel1;
    }
}