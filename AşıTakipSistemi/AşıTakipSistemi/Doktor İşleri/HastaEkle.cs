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
    public partial class HastaEkle : Form
    {
        TextBox[] textBoxes = new TextBox[3];
        Label[] labels = new Label[3];
        
        public HastaEkle()
        {
            InitializeComponent();

            Hastalar hasta = new Hastalar();

            int i = 0;

            int x = 20;
            int y = 20;

            foreach (var prop in hasta.GetType().GetProperties())
            {
                if (i == 3)
                    break;
                
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            AşıDBContext AşıVeriTabanı = new AşıDBContext();
            int i = 0;
            AşıVeriTabanı.Hastalar.Add(new Hastalar
            {
                TC_Kimlik_No = Double.Parse(textBoxes[i].Text),
                ad = textBoxes[++i].Text,
                soyad = textBoxes[++i].Text,
                doğum_Tarihi = dateTimePicker1.Value,
                olduğu_Aşılar = AşıBilgisiEkle.olunan_Aşılar
            });
            AşıVeriTabanı.SaveChanges();
            MessageBox.Show("Hasta Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AşıBilgisiEkle yeni=new AşıBilgisiEkle();
            yeni.Show();
        }
    }
}
