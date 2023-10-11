using CodeChallenge.Models;
using System;
using CodeChallenge.Models;
using Microsoft.Extensions.Logging;
using CodeChallenge.Repositories;

namespace CodeChallenge.Services
{
    public interface ICompensationService
    {
        Compensation CreateCompensation(Compensation compensation);
        Compensation GetCompensation(String id);
    }
}
