using smr.Core.Entitis.smr.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smr.Entitis
{
    public class Renter
    {
        [Key]
        public int id { get; set; }
        public string CountryNameOfBusiness { get; set; }
        public bool isActive { get; set; }
        public virtual List<Turn> turns { get; set; }
        [ForeignKey(nameof(user))]
        public int Userid { get; set; }
        public virtual User user { get; set; }

    }
}
