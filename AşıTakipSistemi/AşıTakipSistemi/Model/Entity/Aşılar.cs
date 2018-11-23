using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AşıTakipSistemi.Model.Entity
{
    class Aşılar
    {
        [Key]
        public int ID { get; set; }

        public string aşı_Adı { get; set; }

        public int doz1 { get; set; }

        public int doz2 { get; set; }
        public int doz3 { get; set; }
        public int doz4 { get; set; }
    }
}
