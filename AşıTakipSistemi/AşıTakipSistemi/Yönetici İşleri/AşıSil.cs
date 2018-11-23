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
    public partial class AşıSil : Form
    {
        public AşıSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AşıDBContext AşıVeriTabanı = new AşıDBContext();
            
                int ID = Int32.Parse(textBox1.Text);
                try
                {
                    var silinecek = (from d in AşıVeriTabanı.Aşılar
                                     where d.ID == ID
                                     select d).Single();
                    AşıVeriTabanı.Aşılar.Remove(silinecek);
                    AşıVeriTabanı.SaveChanges();
                    MessageBox.Show("Silme işlemi başarılı");
                }
                catch
                {
                    MessageBox.Show("Bu sicil numarasıyla kayıtlı kişi yok");
                }


            
        }
    }
}
