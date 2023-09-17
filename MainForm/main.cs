﻿using DesignPatterns.CreationalPatternsForms;

namespace DesignPatterns
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_factory_Click(object sender, EventArgs e)
        {
            var factory = new Factory();
            factory.ShowDialog();
        }
    }
}