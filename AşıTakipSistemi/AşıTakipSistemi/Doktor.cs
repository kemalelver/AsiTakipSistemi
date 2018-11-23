using AşıTakipSistemi.Doktor_İşleri;
using AşıTakipSistemi.Hemşire_İşleri;
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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new HastaEkle());
        }

        private void hastaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new HastaSil());
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

        private void hastalarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new HastalarıListele());
        }

        private void aşıYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AşıYap());
        }

        private void aşısıYaklaşanlarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AşısıYaklaşanlarıListele());
        }
    }
}
