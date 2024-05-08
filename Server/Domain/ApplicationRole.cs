﻿using Microsoft.AspNetCore.Identity;

namespace Server.Domain;
public class ApplicationRole : IdentityRole
{
    public ICollection<ApplicationUserRole> UserRoles { get; set; } = [];
}

