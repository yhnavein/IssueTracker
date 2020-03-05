﻿

using CSharpFunctionalExtensions;
using IssueTracker.Domain.Entities;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Repositories
{
    public interface IJobRepository
    {
        Task<Maybe<Job>> GetAsync(int jobId);
        Task<Result> SaveAsync(Job job);
        Result Delete(Job job);
    }
}