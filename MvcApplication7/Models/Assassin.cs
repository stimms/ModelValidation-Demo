﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcApplication7.ModelValidation;

namespace MvcApplication7.Models
{
    //partial class as the other part of the class defines the metadata type.
    //Think of this class as having been generated by your ORM
    public partial class Assassin
    {
        public virtual int ID { get; set; }

        [Required(ErrorMessageResourceName="FirstNameRequiredErrorMessage",
                  ErrorMessageResourceType=typeof(Strings))]
        public virtual string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        public virtual string LastName { get; set; }

        [StringLength(1)]
        public virtual string MiddleInitial { get; set; }

        [CodeName(ErrorMessage = "Code names must be awesome and all awesome code names are two words with the first word being a metal")]
        public virtual string CodeName { get; set; }

        public virtual string PhoneNumber { get; set; }

        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public virtual string EMailAddress { get; set; }

        public virtual string Address { get; set; }

        public virtual string City { get; set; }

        public virtual string PostalCode { get; set; }

        [Range(0, 250)]
        public virtual int Height { get; set; }

    }
}