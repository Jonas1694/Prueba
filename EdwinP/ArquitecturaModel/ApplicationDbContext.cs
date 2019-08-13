using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaModel
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {

    }
}
