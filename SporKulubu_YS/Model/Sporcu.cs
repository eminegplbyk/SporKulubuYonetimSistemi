using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class Sporcu
    {
        [Key] public int SporcuId { get; set; }
        [MaxLength(50)] public string SporcuAd {  get; set; }
        [MaxLength(50)] public string SporcuSoyad { get; set; }
        public DateTime SporcuDogumTarihi { get; set; }
        public bool Cinsiyet {  get; set; }
        [MaxLength(50)] public string Eposta { get; set; }
        public List<SporcuBrans> SporcuBranslar { get; set; }
    }
}
