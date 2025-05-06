using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class Brans
    {
        [Key] public int BransId { get; set; }
        [MaxLength(30)] public string BransAd {  get; set; }
        public List<BransAntrenor> BransAntrenorler { get; set; }
        public List<Etkinlik> Etkinlikler {  get; set; }
        public List<Salon> Salonlar {  get; set; }
        public List<SporcuBrans> SporcuBranslar {  get; set; }
    }
}
