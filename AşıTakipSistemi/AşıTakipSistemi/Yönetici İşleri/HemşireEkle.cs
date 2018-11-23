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

namespace AşıTakipSistemi.Yönetici_İşleri
{
    public partial class HemşireEkle : Form
    {
        TextBox[] textBoxes = new TextBox[4];
        Label[] labels = new Label[4];
        public HemşireEkle()
        {
            InitializeComponent();
            Çalışanlar çalışan = new Çalışanlar();
            int i = 0;

            int x = 20;
            int y = 20;

            foreach (var prop in çalışan.GetType().GetProperties())
            {
                if (prop.Name != "görev_Tipi")
                {
                    labels[i] = new Label();
                    labels[i].Text = prop.Name;
                    labels[i].Location = new Point(x, y);
                    labels[i].Width = 50;
                    x = x + 60;
                    this.Controls.Add(labels[i]);

                    textBoxes[i] = new TextBox();
                    textBoxes[i].Location = new Point(x, y);
                    this.Controls.Add(textBoxes[i]);
                    i++;
                    y = y + 30;
                    x = 20;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AşıDBContext AşıVeriTabanı = new AşıDBContext();
            int i = 0;
            AşıVeriTabanı.Çalışanlar.Add(new Çalışanlar
            {
                sicil_No = Int32.Parse(textBoxes[i].Text),
                ad = textBoxes[++i].Text,
                soyad = textBoxes[++i].Text,
                görev_Tipi = 2,
                şifre = textBoxes[++i].Text
            });
            AşıVeriTabanı.SaveChanges();
            MessageBox.Show("Hemşire Eklendi");
        }
    }
}
