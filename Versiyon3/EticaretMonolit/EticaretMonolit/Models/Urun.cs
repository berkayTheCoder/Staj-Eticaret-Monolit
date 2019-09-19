using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretMonolit.Models
{

    public class Urun
    {
        [Key]
        public int Id { get; set; }

        public string Adi { get; set; }

        public int Stok { get; set; }


        public string Resim { get; set; }

        [NotMapped]
        public IFormFile Dosya { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        //---ilişkileri----
        [Display(Name = "Kategorisi")]
        public int KategoriId { get; set; }    //scaler
        public Kategori Kategori { get; set; }  //referans
#if true // 
        [Display(Name = "ÜrünSahibi")]
        public string AppUserId { get; set; }
        public AppUser AppUserUser { get; set; }

#endif
#if false
            // Versiyon6 

            public IList<Siparis> Siparisler { get; set; }
#endif

    }

}

