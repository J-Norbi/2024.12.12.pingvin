using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2024._12._12.pingvin
{
    public partial class Form1 : Form
    {
        List<pingvin> pingvins = new List<pingvin>();
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            addButton.Click += AddPingvin;
        }
        void AddPingvin(object sender, EventArgs e)
        {
            try
            {
                pingvin onePingvin = new pingvin(textBoxName.Text, int.Parse(textBoxAge.Text));
                groupBox2.Controls.Add(onePingvin);
                onePingvin.Top = onePingvin.Height * pingvins.Count;
                pingvins.Add(onePingvin);
                textBoxAge.Text = "";
                textBoxName.Text = "";
                textBoxName.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                textBoxAge.Text = "";
                textBoxAge.Focus();
            }
        }
    }
}
