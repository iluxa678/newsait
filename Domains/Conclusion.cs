using System;


namespace newsait.Domains
{
    public class Conclusion
    {
        public int ConclusionId { get; set; }
        public DateTime DateConclusion { get; set; }
        public Appeal Appeal { get; set; }
        public Doct Doct { get; set; }
        public Ill Ill { get; set; }   
    }  
}
