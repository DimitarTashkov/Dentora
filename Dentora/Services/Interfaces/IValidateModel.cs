using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dentora.Services.Interfaces
{
    public interface IValidateModel
    {
        public Task<(bool IsValid, List<ValidationResult> Errors)> ValidateModelAsync<TModel>(TModel model);
    }
}
