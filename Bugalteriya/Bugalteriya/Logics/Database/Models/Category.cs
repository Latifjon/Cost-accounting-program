using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace Bugalteriya.Logics.Database.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string CategoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Expence> Expence { get; set; }
    }
}
