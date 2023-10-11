using CodeChallenge.Models;
using System.Threading.Tasks;

namespace CodeChallenge.Repositories
{
    public interface ICompensationRepository
    {
        Compensation CreateCompensation(Compensation compensation);
        Compensation GetCompensation(string id);
        Task SaveAsync();

    }
}
