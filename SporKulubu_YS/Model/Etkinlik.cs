using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class Etkinlik
    {
        [Key] public int EtkinlikId { get; set; }
        [ForeignKey("BransId")] public int BransId { get; set; }
        [MaxLength(50)] public string EtkinlikAd {  get; set; }
        [MaxLength(50)] public string EtkinlikYer {  get; set; }
        public DateTime EtkinlikTarih { get; set; }
        [MaxLength(150)] public string EtkinlikAciklama { get; set; }
        public Brans Brans { get; set; } //Birebir ilişkiyi göstermek için
    }
}
