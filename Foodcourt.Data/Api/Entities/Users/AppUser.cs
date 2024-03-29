﻿using Foodcourt.Data.Api.Entities.Cafes;
using Foodcourt.Data.Api.Entities.Orders;
using Microsoft.AspNetCore.Identity;

namespace Foodcourt.Data.Api.Entities.Users;

public class AppUser : IdentityUser
{
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;
    public int ConfirmationCode { get; set; }
    public DateTime CodeExpiredTo { get; set; }

    public virtual Basket Basket { get; set; }
    
    public List<Order> Orders { get; set; }
    public virtual List<Cafe> Cafes { get; set; }
}