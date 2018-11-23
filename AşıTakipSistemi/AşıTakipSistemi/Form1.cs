using AşıTakipSistemi.Model.Context;
using AşıTakipSistemi.Model.Entity;
using AşıTakipSistemi.XML_işleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi
{
    
    public partial class Form1 : Form
    {
         static AşıDBContext AşıVeriTabanı;
        public Form1()
        {
            InitializeComponent();
            CreateDBObjects();

            ///yönetici eklemek için
           /* AşıVeriTabanı.Çalışanlar.Add(new Çalışanlar
            {
                sicil_No = 1,
                ad = "Ahmet",
                soyad = "Düzgiden",
                görev_Tipi = 0,
                şifre = "12345"
            });*/
            AşıVeriTabanı.SaveChanges();
        }

        private static void CreateDBObjects()
        {
            AşıVeriTabanı = new AşıDBContext();

           if( !AşıVeriTabanı.Database.Exists())
            {
                AşıVeriTabanı.Database.Create();
                DosyaYardımcısı.Database_doldur();      
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sicil_No = Int32.Parse(textBox1.Text);
            string şifre = textBox2.Text;
            var çalışan = AşıVeriTabanı.Çalışanlar.Find(sicil_No);
           
            if(çalışan==null)
            { MessageBox.Show("Sicil no/Şifre yanlış"); }
            else if(String.Compare(çalışan.şifre,şifre)==0) {
                    switch (çalışan.görev_Tipi)
                    {
                          case 0:
                        Form yeni = new Yönetici();
                        yeni.Show();  
                          break;

                    case 1:
                        Form yeni1 = new Doktor();
                        yeni1.Show();
                        break;

                    case 2:
                        Form yeni2 = new Hemşire();
                        yeni2.Show();
                        break;

                    default: break; 
                    }
                } else MessageBox.Show("Sicil no/Şifre yanlış");
        }
    }
}
