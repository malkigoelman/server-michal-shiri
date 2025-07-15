

using smr.Core.Entitis.smr.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smr.Entitis
{
    public class Tourist
    {
        public string id { get; set; }
        public string CountryNameOfBusiness { get; set; }
        public bool isActive { get; set; }
        public List<Turn> turns { get; set; }
        [ForeignKey("User")]
        public string Userid { get; set; }
        public User user { get; set; }


    }
}
