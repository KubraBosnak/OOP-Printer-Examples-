using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_OOP_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EvYazicisi evYazicisi = new EvYazicisi();
            //evYazicisi.KagitHaznesi = new Dictionary<Type, int>();
            //evYazicisi.KagitHaznesi.Add(typeof(KagitA5), 0);

            evYazicisi.Ac();
            //evYazicisi.Kapat();

            evYazicisi.KagitEkle<KagitA4>(10);
            evYazicisi.KagitCikar<KagitA4>(3);

            //KagitA4 kagit = (KagitA4)evYazicisi.Yazdir(typeof(KagitA4));
            KagitA4 kagit = (KagitA4)evYazicisi.Yazdir<KagitA4>();

            // ===========================================================================

            ProfesyonelYazici profesyonelYazicisi = new ProfesyonelYazici();
            profesyonelYazicisi.Ac();

            profesyonelYazicisi.KagitEkle<KagitA4>(5);
            profesyonelYazicisi.KagitEkle<KagitA5>(15);

            KagitA5 kagit2 = (KagitA5)profesyonelYazicisi.Yazdir<KagitA5>();
        }
    }
}
