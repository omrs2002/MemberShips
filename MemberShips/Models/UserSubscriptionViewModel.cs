using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MemberShipsPro.Entities;

namespace MemberShipsPro.Models
{
    public class UserSubscriptionViewModel
    {
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<UserSubscriptionModel> UserSubscriptions { get; set; }
        public bool DisableDropDown { get; set; }
        public string UserId { get; set; }
        public int SubscriptionId { get; set; }
    }
}