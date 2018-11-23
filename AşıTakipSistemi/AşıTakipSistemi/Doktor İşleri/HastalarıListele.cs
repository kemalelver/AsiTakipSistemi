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

namespace AşıTakipSistemi.Doktor_İşleri
{
    public partial class HastalarıListele : Form
    {
        
        public HastalarıListele()
        {
            InitializeComponent();

            Listele("x");
           
           
        }

        private void Listele(string soyad)
        {
            AşıDBContext AşıVeriTabanı = new AşıDBContext();
            Hastalar hasta = new Hastalar();
            int i = 0;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.MaximumSize = new Size(450, 250);
            foreach (var prop in hasta.GetType().GetProperties())
            {
                tableLayoutPanel1.Controls.Add(new Label() { Text = prop.Name }, i, 0);
                i++;
            }
            var hastaBilgisi = (from d in AşıVeriTabanı.Hastalar

                                select new { d.TC_Kimlik_No, d.ad, d.soyad, d.doğum_Tarihi, d.olduğu_Aşılar }).ToList();



            foreach (var o in hastaBilgisi)
            {
                if (soyad == "x" || o.soyad.Contains(soyad))
                {
                    i = 0;
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                    tableLayoutPanel1.Controls.Add(new Label() { Text = o.TC_Kimlik_No.ToString() }, i++, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = o.ad }, i++, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = o.soyad }, i++, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = o.doğum_Tarihi.ToString() }, i++, tableLayoutPanel1.RowCount - 1);
                    Button yeni = new Button() { Text = "Aşılar", Name = o.TC_Kimlik_No.ToString() };
                    yeni.Click += button_Click;
                    tableLayoutPanel1.Controls.Add(yeni, i++, tableLayoutPanel1.RowCount - 1);
                }

            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            AşıDBContext AşıVeriTabanı = new AşıDBContext();
            Button yeni = (Button)sender;
            double TC = Convert.ToDouble(yeni.Name);
            var hastaBilgisi = (from d in AşıVeriTabanı.Hastalar
                                where d.TC_Kimlik_No == TC 
                                select new { d.olduğu_Aşılar }).ToList();
            string bilgiler="";
            foreach (var o in hastaBilgisi)
                bilgiler = o.olduğu_Aşılar;
            AşıBilgisiGöster aşıBilgisiGöster = new AşıBilgisiGöster(bilgiler);

            aşıBilgisiGöster.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele(textBox1.Text);
        }
    }

    
}
