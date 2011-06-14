using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication7.Models
{
    //annotate with a buddy class which contains additional validations
    [MetadataType(typeof(AssassinBuddy))]
    public partial class Assassin
    {
    }
}