using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bugalteriya.Logics.Database.Models;

namespace Bugalteriya.Logics.Database
{
    /// <summary>
    /// 
    /// </summary>
    public class ReportContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public ReportContext(): base("name=ReportDB")
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Expence> Expences { get; set; }
    }
}
