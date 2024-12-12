using System;
using System.Windows.Forms;

namespace _2024._12._12.pingvin
{
    internal class pingvin : UserControl
    {
        private Label neve;
        private Button helloButton;
        private Label kora;

        public string pingvinName { get; private set; }
        public int pingvinAge { get; set; }
        public pingvin(string name, int age)
        {
            InitializeComponent();
            if(name.Length > 0)
            {
                this.pingvinName = name;
            }
            else
            {
                throw new Exception("Nincs neve a pingvinnek");
            }
            this.pingvinAge = age;
            neve.Text += name;
            kora.Text += age;
            helloButton.Click += HelloEvent;
        }
        void HelloEvent(Object s, EventArgs e)
        {
            MessageBox.Show($"Szia, {pingvinName} vagyok");
        }
        private void InitializeComponent()
        {
            this.neve = new System.Windows.Forms.Label();
            this.kora = new System.Windows.Forms.Label();
            this.helloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // neve
            // 
            this.neve.AutoSize = true;
            this.neve.Location = new System.Drawing.Point(13, 9);
            this.neve.Name = "neve";
            this.neve.Size = new System.Drawing.Size(33, 13);
            this.neve.TabIndex = 0;
            this.neve.Text = "Név: ";
            // 
            // kora
            // 
            this.kora.AutoSize = true;
            this.kora.Location = new System.Drawing.Point(115, 8);
            this.kora.Name = "kora";
            this.kora.Size = new System.Drawing.Size(26, 13);
            this.kora.TabIndex = 1;
            this.kora.Text = "Kor:";
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(182, 3);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(75, 23);
            this.helloButton.TabIndex = 2;
            this.helloButton.Text = "Szia";
            this.helloButton.UseVisualStyleBackColor = true;
            // 
            // pingvin
            // 
            this.Controls.Add(this.helloButton);
            this.Controls.Add(this.kora);
            this.Controls.Add(this.neve);
            this.Name = "pingvin";
            this.Size = new System.Drawing.Size(269, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
