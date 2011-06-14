using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcApplication7.ModelValidation
{
    public class CodeNameAttribute:ValidationAttribute, IClientValidatable
    {

        public override bool IsValid(object value)
        {
            string fieldValue = (string)value;

            if (string.IsNullOrEmpty(fieldValue))
                return false;

            if (fieldValue.Split(' ').Length != 2)
            {
                return false;
            }
            if (!IsMetal(fieldValue.Split(' ').First()))
            {
                return false;
            }
            return true;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata modelMetatdata, ControllerContext controllerContext)
        {
            /*
            //regular expression based custom validator
            string pattern = "^(";
            pattern = pattern + string.Join("|", metals.Select(x => x)) + ")\\s\\w+";
            var rule = new ModelClientValidationRegexRule("Only cool code names are permitted", pattern);
            return new List<ModelClientValidationRule> { rule };*/

            //completely custom validator - you have to write your own javascript
            var rule = new ModelClientValidationRule();
            rule.ValidationParameters.Add("metals", string.Join(",", metals));
            rule.ValidationType = "checkcoolfactor";
            rule.ErrorMessage = "Not a cool enough name";

            return new List<ModelClientValidationRule> { rule };

        }
		

        private String[] metals = { "Chrome", "Silver", "Bronze", "Iron", "Gold", "Mercury" };

        private bool IsMetal(string p)
        {
            return metals.Where(x => x.Equals(p, StringComparison.InvariantCultureIgnoreCase)).Count() > 0;
        }

    }
}