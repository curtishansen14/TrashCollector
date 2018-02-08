using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Models
{
    public class CustomerModel
    {
        [Key]
        public int ID { get; set; }

        public string UserID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Zip")]
        [Required]
        public string Zip { get; set; }

        [Display(Name = "Collection Day")]
        [Required]
        public DayOfWeek CollectionDay { get; set; }

    }

    //public class GetCollectionDay
    //{
    //    [Required]
    //    public DayOfWeek CollectionDay { get; set; }
    //}
}