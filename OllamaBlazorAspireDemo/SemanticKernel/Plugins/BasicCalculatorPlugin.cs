using Microsoft.SemanticKernel;
using System.ComponentModel;

namespace OllamaBlazorAspireDemo.SemanticKernel.Plugins
{
    public class BasicCalculatorPlugin
    {
        [KernelFunction("Add")]
        [Description("Adds two numbers together.")]
        [return: Description("The sum of the two numbers.")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
