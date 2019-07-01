using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bugalteriya.Logics.Database.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Expence
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
        public int CategoryId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Comment { get; set; }
    }
}
