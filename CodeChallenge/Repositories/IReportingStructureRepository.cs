using CodeChallenge.Models;

namespace CodeChallenge.Repositories
{
    public interface IReportingStructureRepository
    {
        int getNumberOfReports(Employee employee);
    }
}
