using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorConfListPWA.DTO
{
    public class Conference
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Url { get; set; }
        public int ContributionsCount { get; set; }
        public int SpeakerCount { get; set; }
        public string CfpStart { get; set; }
        public string CfpEnd { get; set; }
    }
}
