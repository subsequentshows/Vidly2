﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
  public class MembershipTypes
  {
    public byte Id { get; set; }
    public short SignUpFee { get; set; }
    public byte DurationInMonth { get; set; }
    public byte DiscountRate { get; set; }
  }
}