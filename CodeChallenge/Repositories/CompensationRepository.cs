using CodeChallenge.Data;
using CodeChallenge.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Repositories
{
    public class CompensationRepository : ICompensationRepository
    {
        private readonly CompensationContext _compensationContext;
        private readonly ILogger<ICompensationRepository> _logger;

        public CompensationRepository(ILogger<ICompensationRepository> logger, CompensationContext compensationContext)
        {
            _compensationContext = compensationContext;
            _logger = logger;
        }
        public Compensation CreateCompensation(Compensation compensation)
         
        {
            compensation.CompensationId = Guid.NewGuid().ToString();
            _compensationContext.EmployeeCompensation.Add(compensation);
            return compensation;
        }
        public Compensation GetCompensation(string id)
        {
            return _compensationContext.EmployeeCompensation.SingleOrDefault( comp => comp.Employee.EmployeeId == id);
        }
        public Task SaveAsync()
        {
            return _compensationContext.SaveChangesAsync();
        }
    }

}
