namespace DesignPatterns.CreationalPatternsForms
{
    partial class Builder
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
            this.cmbAuto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbAuto
            // 
            this.cmbAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.Location = new System.Drawing.Point(109, 50);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(121, 23);
            this.cmbAuto.TabIndex = 1;
            this.cmbAuto.SelectedIndexChanged += new System.EventHandler(this.cmbAuto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un auto:";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(3, 92);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.ShortcutsEnabled = false;
            this.rTextBox.Size = new System.Drawing.Size(340, 263);
            this.rTextBox.TabIndex = 3;
            this.rTextBox.Text = "";
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 351);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAuto);
            this.Name = "Builder";
            this.Text = "Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbAuto;
        private Label label1;
        private RichTextBox rTextBox;
    }
}