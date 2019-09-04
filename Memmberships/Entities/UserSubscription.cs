using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memmberships.Entities
{
    [Table("UserSubscription")]

    public class UserSubscription
    {
        [Required]
        [Key, Column (Order =1)]
        public int SubscriptionId{ get; set; }
        
        //Composite Primary Key of Subscritpion ID and Item ID
        //Order = 1 or 2 
        [Required]
        [Key, Column(Order = 2)]
        [MaxLength (128)]
        public string UserId { get; set; }

              
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

      
    }
}