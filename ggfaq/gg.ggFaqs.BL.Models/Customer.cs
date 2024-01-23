using System.ComponentModel;

namespace gg.ggFaqs.BL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("User Name")]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public int MembershipId { get; set; }
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }
        public string ProfileImage { get; set; }
        public string AboutMe { get; set; }
        public string SocialSites { get; set; }

        //General strings for easier displays
        public string FullName { get {  return FirstName + " " + LastName; } }
        public string FullAddress {  get {  return Address + " " + City + " " + State + " " + ZipCode; } }
    }
}