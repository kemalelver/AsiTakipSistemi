using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AşıTakipSistemi.Model.Entity
{
    class Hastalar
    {
        [Key]
        public double TC_Kimlik_No { get; set; }

        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime doğum_Tarihi { get; set; }

        public string olduğu_Aşılar { get; set; }

    }
}
