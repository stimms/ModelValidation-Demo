using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication7.Models
{
    //a buddy class which defines additional validations
    class AssassinBuddy
    {
        [Required]
        public virtual string PhoneNumber { get; set; }
    }
}
