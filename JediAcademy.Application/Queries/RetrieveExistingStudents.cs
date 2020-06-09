using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JediAcademy.Domain.Entities;
using JediAcademy.Domain.Services;
using MediatR;

namespace JediAcademy.Application.Queries
{
    public class RetrieveExistingStudents
    {
        #region Query

        public class Query : IRequest<(bool IsSuccess, IEnumerable<JediStudent> Result)>
        {
        }

        #endregion Query

        #region Handler

        public class Handler : IRequestHandler<Query, (bool IsSuccess, IEnumerable<JediStudent> Result)>
        {
            private readonly IJediEnrollmentService _enrollmentService;

            public Handler(IJediEnrollmentService enrollmentService)
            {
                _enrollmentService = enrollmentService;
            }

            public Task<(bool IsSuccess, IEnumerable<JediStudent> Result)> Handle(Query request, CancellationToken cancellationToken)
            {
                return _enrollmentService.GetExistingStudents();
            }
        }

        #endregion Handler
    }
}