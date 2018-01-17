using Entity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogContext:IdentityDbContext<IdentityUser>
    {
        public virtual DbSet<Article> Articles { get; set; }
        //Sonradan e-mail eklersek bunu kullanırız.
        public virtual DbSet<EmailSubscription> Emails { get; set; }
    }
}
