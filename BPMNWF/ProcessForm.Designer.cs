namespace BPMNWF
{
    partial class ProcessForm
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
            this.listBoxProcess = new System.Windows.Forms.ListBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProcess
            // 
            this.listBoxProcess.FormattingEnabled = true;
            this.listBoxProcess.Location = new System.Drawing.Point(12, 29);
            this.listBoxProcess.Name = "listBoxProcess";
            this.listBoxProcess.Size = new System.Drawing.Size(776, 173);
            this.listBoxProcess.TabIndex = 0;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(13, 13);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(35, 13);
            this.labelProcess.TabIndex = 1;
            this.labelProcess.Text = "label1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(366, 208);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.listBoxProcess);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcess;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Button buttonAdd;
    }
}