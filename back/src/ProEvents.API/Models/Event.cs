namespace ProEvents.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Localization { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public int QtyAttendees { get; set; }
        public string Lot { get; set; }
        public string ImageUrl { get; set; }
    }
}