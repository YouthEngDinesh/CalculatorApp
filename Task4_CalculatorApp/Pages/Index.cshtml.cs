using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task3_CalculatorApp.Pages
{
    public class IndexModel : PageModel
    {
        // Razor Pages automatically handles the type conversion from string to double
        [BindProperty]
        public double Number1 { get; set; }

        [BindProperty]
        public double Number2 { get; set; }

        // Properties to hold the results for the screen
        public double? Result { get; set; }         // Nullable to handle cases where result is not set (e.g., division by zero)
        public string OperationSymbol { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet()
        {
            // Initial page load setup
        }

        // 1. Handler for Addition: Triggered by asp-page-handler="Add"
        public void OnPostAdd()
        {
            Result = Number1 + Number2;
            OperationSymbol = "+";
        }

        // 2. Handler for Subtraction: Triggered by asp-page-handler="Subtract"
        public void OnPostSubtract()
        {
            Result = Number1 - Number2;
            OperationSymbol = "−";
        }

        // 3. Handler for Multiplication: Triggered by asp-page-handler="Multiply"
        public void OnPostMultiply()
        {
            Result = Number1 * Number2;
            OperationSymbol = "×";
        }

        // 4. Handler for Division: Triggered by asp-page-handler="Divide"
        public void OnPostDivide()
        {
            OperationSymbol = "÷";
            if (Number2 == 0)
            {
                ErrorMessage = "💥 Error: Cannot divide by zero!";
                Result = null;
            }
            else
            {
                Result = Number1 / Number2;
            }
        }
    }
}
