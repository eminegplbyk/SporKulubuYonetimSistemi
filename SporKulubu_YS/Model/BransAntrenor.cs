using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Model
{
    public class BransAntrenor
    {
        [Key] public int BransAntrenorId { get; set; }
        [ForeignKey("AntrenorId")] public int AntrenorId { get; set; }
        public Antrenor Antrenor { get; set; } //veriyi nerden aldığımızı gösterir. Bu şekilde ulaşırız.
                                               //Foregin Key yerini belirtir.
        [ForeignKey("BransId")] public int BransId { get; set; }
        public Brans Brans { get; set; }

    }
}
