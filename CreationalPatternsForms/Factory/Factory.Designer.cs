namespace DesignPatterns.CreationalPatternsForms
{
    partial class Factory
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
            this.cmb_uber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_miles = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_miles)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_uber
            // 
            this.cmb_uber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_uber.FormattingEnabled = true;
            this.cmb_uber.Location = new System.Drawing.Point(44, 74);
            this.cmb_uber.Name = "cmb_uber";
            this.cmb_uber.Size = new System.Drawing.Size(121, 23);
            this.cmb_uber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un tipo de uber";
            // 
            // nud_miles
            // 
            this.nud_miles.Location = new System.Drawing.Point(47, 168);
            this.nud_miles.Name = "nud_miles";
            this.nud_miles.Size = new System.Drawing.Size(120, 23);
            this.nud_miles.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese las millas";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(47, 248);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(52, 28);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calc";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(115, 248);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(52, 28);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(274, 69);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(221, 207);
            this.rtb_result.TabIndex = 6;
            this.rtb_result.Text = "";
            // 
            // Factory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 333);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_miles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_uber);
            this.Name = "Factory";
            this.Text = "Factory";
            ((System.ComponentModel.ISupportInitialize)(this.nud_miles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_uber;
        private Label label1;
        private NumericUpDown nud_miles;
        private Label label2;
        private Button btn_calculate;
        private Button btn_clear;
        private RichTextBox rtb_result;
    }
}