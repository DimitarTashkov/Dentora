using Dentora.Services.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Dentora.Services
{
    public class BaseService
    {
        public virtual async Task<(bool IsValid, List<ValidationResult> Errors)> ValidateModelAsync<TModel>(TModel model)
        {
            return await Task.Run(() =>
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(model);
                bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);
                return (isValid, validationResults);
            });
        }
    }
}
