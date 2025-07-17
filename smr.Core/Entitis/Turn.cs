using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smr.Entitis
{
    public class Turn
    {
        [Key]
        public int id { get; set; }

        public string day { get; set; }
        public string hour { get; set; }

        // קישור תקין ל-Tourist
        public int TouristId { get; set; }

        [ForeignKey("TouristId")]
        public Tourist tourist { get; set; }
    }
}
