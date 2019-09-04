﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memmberships.Entities
{
    [Table("ProductItem")]

    public class ProductItem
    {
        [Required]
        [Key, Column (Order =1)]
        public int ProductId{ get; set; }
        
        //Composite Primary Key of Product ID and Item ID
        //Order = 1 or 2 
        [Required]
        [Key, Column(Order = 2)]
        public int ItemId { get; set; }


        //Entity should not create a table in database
        
        [NotMapped]
        public int OldProductId { get; set; }

        [NotMapped]
        public int OldItemId { get; set; }


      
    }
}