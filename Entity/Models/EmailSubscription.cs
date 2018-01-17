using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class EmailSubscription
    {
        [Key]
        public int EmailSubscriptionID { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
