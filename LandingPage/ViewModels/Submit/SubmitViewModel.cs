using Microsoft.Marketplace.SaaS.Models;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.Graph;
using Subscription = Microsoft.Marketplace.SaaS.Models.Subscription;


namespace LandingPage.ViewModels.Submit
{
    public class SubmitViewModel
    {
        public IEnumerable<Claim> UserClaims { get; internal set; }
        public Subscription Subscription { get; internal set; }
    }
}