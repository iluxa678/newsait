namespace newsait.Domains
{
    public class Metod
    {
        public int MetodId { get; set; }
        public char MetodName { get; set; }
        public char DescriptionMetod { get; set; }
        public Ill Ill { get; set; }
        public Diag Diag { get; set; }
    }
}