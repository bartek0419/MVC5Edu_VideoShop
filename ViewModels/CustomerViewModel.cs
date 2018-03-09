using System.Collections.Generic;
using VideoShop.Models;

namespace VideoShop.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}