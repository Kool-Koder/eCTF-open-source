using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminSide.Models
{
    //public enum Status
    //{
    //    Upcoming, Active, Inactive
    //}

    public class Competition
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Competition Name")]
        public string CompetitionName { get; set; }
        public string Status { get; set; }
        //[Required]
        //Add regex here
        [Display(Name = "Bucket Name")]
        public string BucketName { get; set; }
        //Maximum users per team
        [Range(1, 100, ErrorMessage = "Maximum users must be more than 0 and less than 100")]
        public int MaxUsers { get; set; }

        public ICollection<CompetitionCategory> CompetitionCategories { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
