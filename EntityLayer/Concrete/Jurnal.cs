using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Jurnal
    {
        public int JurnalId { get; set; }
        public int TekneId { get; set; }
        public string TekneIsmi { get; set; } = "";

        public string Name { get; set; } = "";
        public string JurnalTipi { get; set; } = "";
        public string HareketTipi { get; set; } = "";
        public DateOnly HareketTarihi { get; set; }

        public  TimeOnly HareketSaati { get; set; }
        public  TimeOnly DonusSaati { get; set; }
        public DateOnly DonusTarihi { get; set; }

        public Tekne Tekne { get; set; }




    }
}
