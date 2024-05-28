using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tekne
    {

        
        public int TekneId { get; set; }
        public string TekneIsmi { get; set; } = "";
        public string TekneTipi { get; set; } = "";
        public string TekneBayrak { get; set; } = "";
        public string TekneDurumu { get; set; } = "";
        [MaxLength(20)]
        public string TekneRuhsatNo { get; set; } = "";
        public string TekneLiman { get; set; } = "";
        [MaxLength(20)]
        public string TekneEn { get; set; } = "";
        [MaxLength(20)]
        public string TekneBoy { get; set; } = "";
        [MaxLength(20)]
        public string TekneDerinlik { get; set; } = "";
        [MaxLength(20)]
        public string TekneMetreKare { get; set; } = "";
        public string Iskele { get; set; } = "";
        [MaxLength(20)]
        public string IskeleNo { get; set; } = "";
        [MaxLength(20)]
        public string TekneSigortaNo { get; set; } = "";
        public DateOnly TekneSigortaTarihi { get; set; }
        public DateOnly TekneSozlesmeBaslangic { get; set; }
        public DateOnly TekneSozlesmeBitis { get; set; }

     

        [Required]
        public string Isim { get; set; } = "";

        [Required]
        public string Uyruk { get; set; } = "";
        [MaxLength(20)]
        public string Kimlik { get; set; } = "";
        [MaxLength(20)]
        public string TelefonNo { get; set; } = "";
        public string Email { get; set; } = "";

        [Required]
        public string Adres { get; set; } = "";

        public string PersonelIsim { get; set; } = "";
        public string PersonelUyruk { get; set; } = "";
        public string PersonelEmail { get; set; } = "";
       

        [MaxLength(20)]
        public string PersonelEhliyetNo { get; set; } = "";

        [MaxLength(20)]
        public string PersonelTelefonNo { get; set; } = "";




    }
}
