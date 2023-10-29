using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Departmanlar
    {
        [Key]
        public int id { get; set; }
        public string departmanAd { get; set; }
    }
}
