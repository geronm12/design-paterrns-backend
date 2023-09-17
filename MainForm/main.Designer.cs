﻿namespace DesignPatterns
{
    partial class main
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
            this.btn_factory = new System.Windows.Forms.Button();
            this.btn_abstractFactory = new System.Windows.Forms.Button();
            this.btn_builder = new System.Windows.Forms.Button();
            this.btn_singleton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_factory
            // 
            this.btn_factory.Location = new System.Drawing.Point(67, 61);
            this.btn_factory.Name = "btn_factory";
            this.btn_factory.Size = new System.Drawing.Size(105, 34);
            this.btn_factory.TabIndex = 0;
            this.btn_factory.Text = "Factory";
            this.btn_factory.UseVisualStyleBackColor = true;
            this.btn_factory.Click += new System.EventHandler(this.btn_factory_Click);
            // 
            // btn_abstractFactory
            // 
            this.btn_abstractFactory.Location = new System.Drawing.Point(67, 117);
            this.btn_abstractFactory.Name = "btn_abstractFactory";
            this.btn_abstractFactory.Size = new System.Drawing.Size(105, 34);
            this.btn_abstractFactory.TabIndex = 1;
            this.btn_abstractFactory.Text = "Abstract Factory";
            this.btn_abstractFactory.UseVisualStyleBackColor = true;
            this.btn_abstractFactory.Click += new System.EventHandler(this.btn_abstractFactory_Click);
            // 
            // btn_builder
            // 
            this.btn_builder.Location = new System.Drawing.Point(67, 182);
            this.btn_builder.Name = "btn_builder";
            this.btn_builder.Size = new System.Drawing.Size(105, 34);
            this.btn_builder.TabIndex = 2;
            this.btn_builder.Text = "Builder";
            this.btn_builder.UseVisualStyleBackColor = true;
            this.btn_builder.Click += new System.EventHandler(this.btn_builder_Click);
            // 
            // btn_singleton
            // 
            this.btn_singleton.Location = new System.Drawing.Point(67, 326);
            this.btn_singleton.Name = "btn_singleton";
            this.btn_singleton.Size = new System.Drawing.Size(105, 34);
            this.btn_singleton.TabIndex = 4;
            this.btn_singleton.Text = "Factory";
            this.btn_singleton.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RebeccaPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_singleton);
            this.Controls.Add(this.btn_builder);
            this.Controls.Add(this.btn_abstractFactory);
            this.Controls.Add(this.btn_factory);
            this.Name = "main";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_factory;
        private Button btn_abstractFactory;
        private Button btn_builder;
        private Button btn_singleton;
    }
}