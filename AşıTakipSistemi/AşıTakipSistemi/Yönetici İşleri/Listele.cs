using AşıTakipSistemi.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi.Yönetici_İşleri
{
  
    public partial class Listele : Form
    {
        static AşıDBContext AşıVeriTabanı;
        public Listele(string label)
        {
            
            InitializeComponent();
            label1.Text = label;

            CreateDBObjects();
            int görev_tipi = 1;
            if (label == "Hemşireler")
                görev_tipi = 2;
           var çalışanBilgisi = (from Çalışanlar in AşıVeriTabanı.Çalışanlar
                                where Çalışanlar.görev_Tipi == görev_tipi
                               select new { Çalışanlar.sicil_No, Çalışanlar.ad, Çalışanlar.soyad }).ToList();
                                           


            foreach(var o in çalışanBilgisi)
            {

                
                ListViewItem yeni = new ListViewItem();

                yeni.SubItems.Add(o.sicil_No.ToString());
                yeni.SubItems.Add(o.ad);                           
                yeni.SubItems.Add(o.soyad);
                listView1.Items.Add(yeni);

                

            }
            
       

        }
        private static void CreateDBObjects()
        {
            AşıVeriTabanı = new AşıDBContext();
            
        }
    }
}
