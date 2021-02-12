using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delagates
{ //Events
    public partial class Form1 : Form
    {
        delegate int Del(int x);
        delegate void Yaz(string metin);
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.DoubleClick += Form1_DoubleClick;
            Del myDelegate = x => x * x;// x i atayıp karesini almak basit bir işlem olduğu için bunu kullandık.=> önüne yazdığımız değişkeni tanımlamış oluyoruz => bundan sonraki alanda kullanıyoruz.
            int y = myDelegate(3);
            MessageBox.Show(y.ToString());


            Yaz yaz = z => MessageBox.Show(z);
            yaz("Merhaba Yaz!");


            /* this.Click += Form1_Click; */
            this.Click  += (s, e) => { MessageBox.Show(((MouseEventArgs)e).Location.ToString()); };
            
        }

         /* private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((MouseEventArgs)e).Location.ToString());// TIKLADIĞIM X VE Y NİN KONUMLARINI YAZDIRIR.
        } */ //Bunu delegates ve => bunla nasıl yaparım? (kod bloğu 33 te yer alıyor)

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba !");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba !");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
