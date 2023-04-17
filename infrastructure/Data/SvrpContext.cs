using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Data
{
    public class SvrpContext:DbContext
    {
        public SvrpContext(DbContextOptions<SvrpContext> options):base(options)
        {

        }

    }
}
