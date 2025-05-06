
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class Salon
    {
        [Key] public int SalonId { get; set; } 
        [ForeignKey("BransId")] public int BransId { get; set; }
        [MaxLength(50)] public string SalonAd {  get; set; }
        public int Kapasite { get; set; }
        [MaxLength(50)] public string SalonYer {  get; set; }
        public Brans Brans { get; set; } // ilişkiyi göstermek için

    }
}
