namespace smr.Entitis
{
    public class Turn
    {
        public string id { get; set; }
        public string day { get; set; }
        public string hour { get; set; }
        public string TouristId { get; set; }
        public Tourist tourist { get; set; }
    }
}
