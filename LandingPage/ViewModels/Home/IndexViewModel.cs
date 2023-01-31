using System;
using System.Collections.Generic;
using Microsoft.Marketplace.SaaS.Models;


namespace LandingPage.ViewModels.Home
{
    public class IndexViewModel
    {
        public IList<Subscription> Subscriptions { get; internal set; }
        public Guid? FulId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string SubscriptionName { get; set; }
        public long? Quantity { get; set; }
        public SubscriptionStatusEnum? FulfillmentStatus { get; set; }
        public string PlanName {  get; set; }
        public string SubscriptionId { get; set; }
        public string TenantId { get; set; }
        public string PurchaseIdToken { get; set; }
    }
}
