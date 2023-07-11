using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
  public class Customer
  {
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public bool IsSubcribedToNewsletter { get; set; }
    public MembershipTypes MembershipType { get; set; }
    public byte MembershipTypeId { get; set; }
    public int PhoneNumber { get; set; }
    public string Province { get; set; }
    [StringLength(50)]
    public string ReferralCode { get; set; }
    public int RegisterdTime { get; set; }
    public int RegisterdDate { get; set; }
  }
}