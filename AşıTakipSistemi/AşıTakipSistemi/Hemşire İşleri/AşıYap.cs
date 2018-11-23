using AşıTakipSistemi.Doktor_İşleri;
using AşıTakipSistemi.Model.Context;
using AşıTakipSistemi.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi.Hemşire_İşleri
{
    public partial class AşıYap : Form
    {
        public AşıYap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AşıBilgisiEkle yeni = new AşıBilgisiEkle();
            yeni.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AşıDBContext AşıVeriTabanı = new AşıDBContext();

             try
             {
             
            Double tc = Convert.ToDouble(textBox1.Text);
                var hastaBilgisi = (from d in AşıVeriTabanı.Hastalar
                                    where d.TC_Kimlik_No == tc
                                    select new { d.TC_Kimlik_No, d.ad, d.soyad, d.doğum_Tarihi, d.olduğu_Aşılar }).Single();
                var hasta = new Hastalar() { TC_Kimlik_No = hastaBilgisi.TC_Kimlik_No, ad = hastaBilgisi.ad, soyad = hastaBilgisi.soyad, olduğu_Aşılar = hastaBilgisi.olduğu_Aşılar +AşıBilgisiEkle.olunan_Aşılar };
                
                AşıVeriTabanı.Hastalar.Attach(hasta);
                AşıVeriTabanı.Entry(hasta).Property(x => x.olduğu_Aşılar).IsModified = true;

                AşıVeriTabanı.SaveChanges();
                MessageBox.Show("Hastanın aşı bilgisi güncellendi.");
         }
           catch
            {
                MessageBox.Show("Bu TC ile kayıtlı kişi yok");
           }


            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastalarıListele yeni = new HastalarıListele();
            yeni.Show();
        }
    }
}
