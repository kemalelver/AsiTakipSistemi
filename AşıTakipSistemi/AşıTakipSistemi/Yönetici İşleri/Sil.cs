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
    public partial class Sil : Form
    {
        public Sil(string label)
        {
            InitializeComponent();
            label1.Text = "Silinecek" + label;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AşıDBContext AşıVeriTabanı = new AşıDBContext();
            if (Int32.Parse(textBox1.Text) == 1)
            { MessageBox.Show("1 sicil nolu yönetici silinemez"); }
            else
            {
                int sicil_no = Int32.Parse(textBox1.Text);
                try
                {
                    var silinecek = (from d in AşıVeriTabanı.Çalışanlar
                                     where d.sicil_No == sicil_no
                                     select d).Single();
                    AşıVeriTabanı.Çalışanlar.Remove(silinecek);
                    AşıVeriTabanı.SaveChanges();
                    MessageBox.Show("Silme işlemi başarılı");
                } catch
                {
                    MessageBox.Show("Bu sicil numarasıyla kayıtlı kişi yok");
                }
                
                
            }
        }
    }
}
