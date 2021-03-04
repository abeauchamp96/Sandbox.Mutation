using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Mutation.Services2.Tests")]
namespace Mutation.Services2
{
    internal sealed class Calculator : ICalculator
    {
        public int Sum(params int[] values) => values.Sum();
    }
}
