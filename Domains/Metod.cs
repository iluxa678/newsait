namespace newsait.Domains
{
    public class Metod
    {
        public int MetodId { get; set; }
        public string MetodName { get; set; }
        public string DescriptionMetod { get; set; }
        public Ill Ill { get; set; }
        public Diag Diag { get; set; }
    }
}