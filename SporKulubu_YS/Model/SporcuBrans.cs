using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class SporcuBrans
    {
        [Key] public int SporcuBransId { get; set; }
        [ForeignKey("SporcuId")] public int SporcuId { get; set; }
        [ForeignKey("BransId")] public int BransId { get; set; }
        public Sporcu Sporcu { get; set; } //Birebir ilişkiyi göstermek için
        public Brans Brans { get; set; } //Birebir ilişkiyi göstermek için
    }
}
