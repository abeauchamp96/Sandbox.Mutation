using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Mutation.Services.Tests")]
namespace Mutation.Services
{
    internal sealed class BarService : IBarService
    {
        public bool IsPersonOldEnough(int age) => age >= 18;
    }
}
