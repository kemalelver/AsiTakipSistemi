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
    public partial class AşısıYaklaşanlarıListele : Form
    {
        static AşıDBContext AşıVeriTabanı = new AşıDBContext();
        Boolean olmalı;
        public AşısıYaklaşanlarıListele()
        {
            InitializeComponent();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (textBox1.TextLength == 0)
                return;
            Hastalar hasta = new Hastalar();
            int i = 0;
            DateTime bugun = DateTime.Now;
            var hastaBilgisi = (from d in AşıVeriTabanı.Hastalar

                                select new { d.TC_Kimlik_No, d.ad, d.soyad, d.doğum_Tarihi, d.olduğu_Aşılar }).ToList();

            var aşıBilgisi = (from d in AşıVeriTabanı.Aşılar
                              select new { d.ID, d.aşı_Adı, d.doz1, d.doz2, d.doz3, d.doz4 }).ToList();

            string aşılar = "";
            int fark;
            foreach (var h in hastaBilgisi)
            {
                olmalı = false;
                aşılar = "";
                foreach (var a in aşıBilgisi)
                {




                    fark = a.doz1 * 30 - (bugun - h.doğum_Tarihi).Days;
                    if (fark <= Int32.Parse(textBox1.Text) && !h.olduğu_Aşılar.Contains(a.aşı_Adı + "_doz1") && fark >= 0)
                    {
                        olmalı = true;
                        aşılar += a.aşı_Adı + "_doz1(" + bugun.AddDays(fark).ToShortDateString() + ") ";
                    }
                    if (a.doz2 != -1)
                    {

                        fark = a.doz2 * 30 - (bugun - h.doğum_Tarihi).Days;
                        if (fark <= Int32.Parse(textBox1.Text) && !h.olduğu_Aşılar.Contains(a.aşı_Adı + "_doz2"))
                        {
                            olmalı = true;
                            aşılar += a.aşı_Adı + "_doz2(" + bugun.AddDays(fark).ToShortDateString() + ") ";
                        }
                        if (a.doz3 != -1)
                        {
                            fark = a.doz3 * 30 - (bugun - h.doğum_Tarihi).Days;
                            if (fark <= Int32.Parse(textBox1.Text) && !h.olduğu_Aşılar.Contains(a.aşı_Adı + "_doz3"))
                            {
                                olmalı = true;
                                aşılar += a.aşı_Adı + "_doz3(" + bugun.AddDays(fark).ToShortDateString() + ") ";
                            }
                            if (a.doz4 != -1)
                            {
                                fark = a.doz4 * 30 - (bugun - h.doğum_Tarihi).Days;
                                if (fark <= Int32.Parse(textBox1.Text) && !h.olduğu_Aşılar.Contains(a.aşı_Adı + "_doz4"))
                                {
                                    olmalı = true;
                                    aşılar += a.aşı_Adı + "_doz4(" + bugun.AddDays(fark).ToShortDateString() + ") ";
                                }
                            }

                        }
                    }

                }
                if (olmalı)
                {

                    ListViewItem yeni = new ListViewItem();

                    yeni.SubItems.Add(h.TC_Kimlik_No.ToString());
                    yeni.SubItems.Add(h.ad);
                    yeni.SubItems.Add(h.soyad);
                    yeni.SubItems.Add(aşılar);
                    listView1.Items.Add(yeni);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
