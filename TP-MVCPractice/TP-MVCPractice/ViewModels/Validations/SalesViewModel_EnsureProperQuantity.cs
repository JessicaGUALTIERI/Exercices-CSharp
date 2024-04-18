using System;
using System.ComponentModel.DataAnnotations;
using TP_MVCPractice.Models;

namespace TP_MVCPractice.ViewModels.Validations
{
	public class SalesViewModel_EnsureProperQuantity : ValidationAttribute
	{
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var salesViewModel = validationContext.ObjectInstance as SalesViewModel;
            if (salesViewModel != null)
            {
                if (salesViewModel.QuantityToSell <= 0)
                {
                    return new ValidationResult("The quantity to sell has to be greater than zero.");
                } else
                {
                    var product = ProductsRepository.GetProductById(salesViewModel.SelectedProductId);
                    if (product != null)
                    {
                        if (product.Quantity < salesViewModel.QuantityToSell)
                        {
                            return new ValidationResult($"{product.Name} only has {product.Quantity} left. Please try again.");
                        }
                    } else
                    {
                        return new ValidationResult("The selected product doesn't exist.");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}

