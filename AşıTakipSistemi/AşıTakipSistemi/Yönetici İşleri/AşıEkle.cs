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
    public partial class AşıEkle : Form
    {
        TextBox[] textBoxes = new TextBox[6];
        Label[] labels = new Label[6];
        public AşıEkle()
        {
            InitializeComponent();
            Aşılar aşı = new Aşılar();

            int i = 0;

            int x = 20;
            int y = 20;

            foreach (var prop in aşı.GetType().GetProperties())
            {
                
                
                    labels[i] = new Label();
                    labels[i].Text = prop.Name;
                    labels[i].Location = new Point(x, y);
                    labels[i].Width = 50;
                    x = x + 60;
                    this.Controls.Add(labels[i]);

                    textBoxes[i] = new TextBox();
                if(i>2)
                     textBoxes[i].Text = "-1";
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
           
            AşıVeriTabanı.Aşılar.Add(new Aşılar
            {
                ID = Int32.Parse(textBoxes[i].Text),
                aşı_Adı = textBoxes[++i].Text,
                doz1 = Int32.Parse(textBoxes[++i].Text),
                doz2 = Int32.Parse(textBoxes[++i].Text),
                doz3 = Int32.Parse(textBoxes[++i].Text),
                doz4 = Int32.Parse(textBoxes[++i].Text),
                
            });
            AşıVeriTabanı.SaveChanges();
            MessageBox.Show("Aşı Eklendi");
        }
    }
}
