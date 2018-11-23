using AşıTakipSistemi.XML_işleri;
using AşıTakipSistemi.Yönetici_İşleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi
{
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childForm)
        {

            _childForm.Location = new Point(0, 0);
            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Location = new Point(0, 0);
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Location = new Point(0, 0);
                _childForm.Show();
            }
        }

        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new DoktorEkle());
        }

        private void doktorlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Listele("Doktorlar"));
        }

        private void doktorSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Sil("Doktorun"));
        }

        private void hemşireleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Listele("Hemşireler"));
        }

        private void hemşireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new HemşireEkle());
        }

        private void hemşireSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Sil("Hemşirenin"));
        }

        private void aşılarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AşıListele());
        }

        private void aşıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AşıEkle());
        }

        private void aşıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AşıSil());
        }

        private void databaseiXMLeAktarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaYardımcısı.DosyaYarat();
            DosyaYardımcısı.AşıDegerleriniDoldur();
            DosyaYardımcısı.HastaDegerleriniDoldur();
            DosyaYardımcısı.ÇalışanDegerleriniDoldur();
            MessageBox.Show("Xml'e aktarıldı");

        }
    }
}
