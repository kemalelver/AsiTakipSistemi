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
    public partial class AşıBilgisiGöster : Form
    {
        public AşıBilgisiGöster(string olunan_Aşılar)
        {
            InitializeComponent();
            AşıDBContext AşıVeriTabanı = new AşıDBContext();

            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.MaximumSize = new Size(450, 250);
            int i = 0;
            Aşılar aşı = new Aşılar();
            foreach (var prop in aşı.GetType().GetProperties())
            {
                tableLayoutPanel1.Controls.Add(new Label() { Text = prop.Name }, i, 0);
                i++;
            }

            var aşıBilgisi = (from d in AşıVeriTabanı.Aşılar

                                select new { d.ID,d.aşı_Adı,d.doz1,d.doz2,d.doz3,d.doz4 }).ToList();
            string oldu = "";

            foreach (var o in aşıBilgisi)
            {
                i = 0;
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                tableLayoutPanel1.Controls.Add(new Label() { Text = o.ID.ToString() }, i++, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = o.aşı_Adı }, i++, tableLayoutPanel1.RowCount - 1);
                if (olunan_Aşılar.Contains(o.aşı_Adı + "_doz1"))
                    oldu = "+";
                else oldu = " ";
                tableLayoutPanel1.Controls.Add(new Label() { Text = oldu }, i++, tableLayoutPanel1.RowCount - 1);
                if (olunan_Aşılar.Contains(o.aşı_Adı + "_doz2"))
                    oldu = "+";
                else oldu = " ";
                tableLayoutPanel1.Controls.Add(new Label() { Text = oldu }, i++, tableLayoutPanel1.RowCount - 1);
                if (olunan_Aşılar.Contains(o.aşı_Adı + "_doz3"))
                    oldu = "+";
                else oldu = " ";
                tableLayoutPanel1.Controls.Add(new Label() { Text = oldu }, i++, tableLayoutPanel1.RowCount - 1);
                if (olunan_Aşılar.Contains(o.aşı_Adı + "_doz4"))
                    oldu = "+";
                else oldu = " ";
                tableLayoutPanel1.Controls.Add(new Label() { Text = oldu }, i++, tableLayoutPanel1.RowCount - 1);
                
            }
        }
    }
}
