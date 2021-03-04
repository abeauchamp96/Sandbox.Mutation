using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Mutation.Services.Tests")]
namespace Mutation.Services
{
    public interface IBarService
    {
        bool IsPersonOldEnough(int age);
    }
}
