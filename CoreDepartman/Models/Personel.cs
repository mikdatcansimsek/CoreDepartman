using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Personel
    {
        [Key]
        public int perId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }
        public Departmanlar depart { get; set; }
    }
}
