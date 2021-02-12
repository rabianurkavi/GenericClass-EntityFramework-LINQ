using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Nesne_Ve_Event_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btn = new Button(); //butonu oluşturduk
            btn.Text = "Tıkla!";
            btn.Name = "btnTikla";
            btn.Width = 200;
            btn.Height = 50;
            btn.Left = btn.Width + 5;//soldan genişliği
            btn.Click += delegate (object sender, EventArgs e) //click eventi ekledik delegate ile yaptık
            {
                string mesaj = (sender as Button).Text;//senderı buttona dönüştür ve textini al 
                MessageBox.Show(mesaj);//yazan mesaj Tıkla!
            };
            this.Controls.Add(btn);
            //BASİT BİR ŞEKİLDE NASIL YAPARIZ

            button1.Click += delegate
              {
                  MessageBox.Show("Tıklandı! ");
              };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
