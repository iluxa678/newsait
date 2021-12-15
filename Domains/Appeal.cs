using System;

namespace newsait.Domains
{
        public class Appeal
        {
        public int AppealId { get; set; }
        public DateTime DateAppeal { get; set; }
        public Client Client { get; set; }
        public Pet Pet { get; set; }
        public string Notes { get; set; }
        public string Description { get; set; }
        public int Lasting { get; set; }
        public Status Status { get; set; }
    }  
}
