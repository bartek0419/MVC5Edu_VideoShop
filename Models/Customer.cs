using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace VideoShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        [ForeignKey("MembershipTypeId")]
        public MembershipType MembershipType { get; set; }
        public byte? MembershipTypeId { get; set; }
    }
}