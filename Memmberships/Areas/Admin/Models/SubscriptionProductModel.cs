using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using Memmberships.Entities;

namespace Memmberships.Areas.Admin.Models
{
    public class SubscriptionProductModel
    {

        [DisplayName ("Product Id")]
        public int ProductId { get; set; }

        [DisplayName("Subscritption Id")]
        public int SubscriptionId { get; set; }

        [DisplayName ("Product Title")]
        public string ProductTitle { get; set; }


        [DisplayName ("Susbcription Title")]
        public string SubscritionTitle { get; set; }

     
        public ICollection <Product> Products { get; set; }

        public ICollection <Subscription> Subscriptions { get; set; }

    }
}