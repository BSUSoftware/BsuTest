using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using JediAcademy.Back.Application.Interfaces;
using JediAcademy.Back.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JediAcademy.Back.Application.Queries
{
    public class GetStudents
    {
        #region Query

        public class Query : IRequest<(bool IsSuccess,IEnumerable<JediStudent> Result,string Message)>
        {
        }

        #endregion Query

        #region Handler

        public class Handler : IRequestHandler<Query, (bool IsSuccess,IEnumerable<JediStudent> Result,string Message)>
        {
            private readonly IJediStudentsDbContext _dbContext;

            public Handler(IJediStudentsDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<(bool IsSuccess, IEnumerable<JediStudent> Result, string Message)> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    var students = await _dbContext.JediStudents.ToListAsync();
                    if (students != null && students.Any())
                    {
                        return (true, students, null);
                    }

                    return (false, students, "No Jedi Students found");
                }
                catch (Exception exception)
                {
                    return (false, null, exception.Message);
                }
            }
        }

        #endregion Handler
    }
}