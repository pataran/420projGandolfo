using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManeMediaReMake.Models
{
    public class EventsModel
    {

        public int ID { get; set; }
        public string EventTitle { get; set; }
        public DateTime EventCreated { get; set; }
        public string EventCreatedBy { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; }
        public string EventInfo { get; set; }
        public string EventDetails { get; set; }
        public bool EventCheckIn { get; set; }
        //public ContactStatus Status { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}
