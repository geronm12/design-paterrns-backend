namespace DesignPatterns.CreationalPatternsForms
{
    partial class AbstractFactory
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
            this.cmbSO = new System.Windows.Forms.ComboBox();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wb_ui = new DesignPatterns.CreationalPatternsForms.WebBrowserCustom();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSO
            // 
            this.cmbSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSO.FormattingEnabled = true;
            this.cmbSO.Location = new System.Drawing.Point(47, 177);
            this.cmbSO.Name = "cmbSO";
            this.cmbSO.Size = new System.Drawing.Size(121, 23);
            this.cmbSO.TabIndex = 0;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(47, 239);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(57, 27);
            this.btn_Cargar.TabIndex = 1;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione un SO:";
            // 
            // wb_ui
            // 
            this.wb_ui.Location = new System.Drawing.Point(287, 12);
            this.wb_ui.Name = "wb_ui";
            this.wb_ui.Size = new System.Drawing.Size(482, 413);
            this.wb_ui.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(111, 239);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(57, 27);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // AbstractFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.wb_ui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.cmbSO);
            this.Name = "AbstractFactory";
            this.Text = "AbstractFactory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbSO;
        private Button btn_Cargar;
        private Label label2;
        private WebBrowserCustom wb_ui;
        private Button btnLimpiar;
    }
}