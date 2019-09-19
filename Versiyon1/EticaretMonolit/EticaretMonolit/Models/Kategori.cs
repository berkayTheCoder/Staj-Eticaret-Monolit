using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EticaretMonolit.Models
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }

        public string Adi { get; set; }

        //---ilişkileri----
        public List<Urun> Urunleri { get; set; }

    }
}