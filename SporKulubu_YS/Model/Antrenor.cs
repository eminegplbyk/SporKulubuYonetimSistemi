using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class Antrenor
    {
        [Key] public int AntrenorId { get; set; }
        [MaxLength(50)] public string AntrenorAd {  get; set; }
        [MaxLength(50)] public string AntrenorSoyad { get; set; }
        [MaxLength(30)] public string Uzmanlık { get; set; }
        public DateTime AntrenorDogumTarihi { get; set; }
        [MaxLength(20)] public string Ulke {  get; set; }
        public List<BransAntrenor> BransAntrenorler { get; set; }
    }
}
