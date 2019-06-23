namespace BPMNWF
{
    partial class ProcessDefForm
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
            this.SuspendLayout();
            // 
            // listBoxProcess
            // 
            this.listBoxProcess.FormattingEnabled = true;
            this.listBoxProcess.Location = new System.Drawing.Point(13, 13);
            this.listBoxProcess.Name = "listBoxProcess";
            this.listBoxProcess.Size = new System.Drawing.Size(775, 186);
            this.listBoxProcess.TabIndex = 0;
            this.listBoxProcess.SelectedIndexChanged += new System.EventHandler(this.listBoxProcess_SelectedIndexChanged);
            // 
            // ProcessDefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 212);
            this.Controls.Add(this.listBoxProcess);
            this.Name = "ProcessDefForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcess;
    }
}