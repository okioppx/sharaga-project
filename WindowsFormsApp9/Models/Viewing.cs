using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.Models
{
    public class Viewing
    {
        public int ViewingId { get; set; }
        public int PropertyId { get; set; }
        public int ClientId { get; set; }
        public int AgentId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string ClientFeedback { get; set; }
        public Property Property { get; set; }
        public Client Client { get; set; }
        public Agent Agent { get; set; }
    }
}
