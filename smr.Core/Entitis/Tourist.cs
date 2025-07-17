using smr.Core.Entitis.smr.Core.Models;
using smr.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Tourist
{
    [Key]
    public int id { get; set; }
    public string CountryNameOfBusiness { get; set; }
    public bool isActive { get; set; }

    public List<Turn> turns { get; set; }

    // קשר ל-User
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
}
