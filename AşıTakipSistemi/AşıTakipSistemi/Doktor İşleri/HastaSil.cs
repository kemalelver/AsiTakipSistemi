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

namespace AşıTakipSistemi.Doktor_İşleri
{
    public partial class HastaSil : Form
    {
        public HastaSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AşıDBContext AşıVeriTabanı = new AşıDBContext();
           
                Double TC = Convert.ToDouble(textBox1.Text);
                try
                {
                    var silinecek = (from d in AşıVeriTabanı.Hastalar
                                     where d.TC_Kimlik_No == TC
                                     select d).Single();
                    AşıVeriTabanı.Hastalar.Remove(silinecek);
                    AşıVeriTabanı.SaveChanges();
                    MessageBox.Show("Silme işlemi başarılı");
                }
                catch
                {
                    MessageBox.Show("Bu TC kimlik numarasıyla kayıtlı hasta yok");
                }


            
        }
    }
}
