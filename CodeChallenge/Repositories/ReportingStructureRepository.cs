using CodeChallenge.Data;
using CodeChallenge.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CodeChallenge.Repositories
{
    public class ReportingStructureRepository : IReportingStructureRepository
    {

        private readonly ILogger<ReportingStructureRepository> _logger;

        public int getNumberOfReports(Employee employee)
        {
            int numberOfReports = 0;
            List<Employee> reportList = employee.DirectReports;
            if (reportList != null )
            {
                foreach (Employee tmpEmp in reportList)
                {
                    _logger.LogDebug($"Got here for '{tmpEmp.EmployeeId}'");
                    numberOfReports += 1 + getNumberOfReports(tmpEmp);
                }
            }

            return numberOfReports;
        }
    }
}
