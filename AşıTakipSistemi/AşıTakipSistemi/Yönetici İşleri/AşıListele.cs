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
    public partial class AşıListele : Form
    {
        public AşıListele()
        {
            InitializeComponent();
           

            AşıDBContext AşıVeriTabanı = new AşıDBContext();
            
            var aşıBilgisi = (from d in AşıVeriTabanı.Aşılar
                                  
                                  select new {d.ID , d.aşı_Adı,d.doz1,d.doz2,d.doz3,d.doz4 }).ToList();



            foreach (var o in aşıBilgisi)
            {


                ListViewItem yeni = new ListViewItem();

                yeni.SubItems.Add(o.ID.ToString());
                yeni.SubItems.Add(o.aşı_Adı);
                yeni.SubItems.Add(o.doz1.ToString());
                yeni.SubItems.Add(o.doz2.ToString());
                yeni.SubItems.Add(o.doz3.ToString());
                yeni.SubItems.Add(o.doz4.ToString());

                listView1.Items.Add(yeni);



            }


        }
    }
}
