using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi.Model.Entity
{
    class Çalışanlar
    {
        [Key]
        public int sicil_No { get; set; }

        public string ad  { get; set; }

        public string soyad { get; set; }

        public int görev_Tipi { get; set; }

        public string şifre { get; set; }
    }
}
