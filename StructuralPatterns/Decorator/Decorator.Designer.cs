namespace DesignPatterns.StructuralPatterns
{
    partial class Decorator
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
            this.dgvLeche = new System.Windows.Forms.DataGridView();
            this.cmbLeche = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeche)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeche
            // 
            this.dgvLeche.AllowUserToAddRows = false;
            this.dgvLeche.AllowUserToDeleteRows = false;
            this.dgvLeche.AllowUserToResizeColumns = false;
            this.dgvLeche.AllowUserToResizeRows = false;
            this.dgvLeche.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvLeche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeche.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLeche.Location = new System.Drawing.Point(12, 120);
            this.dgvLeche.Name = "dgvLeche";
            this.dgvLeche.ReadOnly = true;
            this.dgvLeche.RowTemplate.Height = 25;
            this.dgvLeche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeche.Size = new System.Drawing.Size(407, 254);
            this.dgvLeche.TabIndex = 0;
            this.dgvLeche.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeche_CellClick);
            this.dgvLeche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeche_CellContentClick);
            this.dgvLeche.Click += new System.EventHandler(this.dgvLeche_Click);
            // 
            // cmbLeche
            // 
            this.cmbLeche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeche.FormattingEnabled = true;
            this.cmbLeche.Location = new System.Drawing.Point(93, 48);
            this.cmbLeche.Name = "cmbLeche";
            this.cmbLeche.Size = new System.Drawing.Size(121, 23);
            this.cmbLeche.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(259, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un tipo de leche";
            // 
            // Decorator
            // 
            this.ClientSize = new System.Drawing.Size(430, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbLeche);
            this.Controls.Add(this.dgvLeche);
            this.Name = "Decorator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvLeche;
        private ComboBox cmbLeche;
        private Button btnAgregar;
        private Label label1;
    }
}