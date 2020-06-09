using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JediAcademy.Domain.Entities;
using JediAcademy.Domain.Services;
using MediatR;

namespace JediAcademy.Application.Queries
{
    public class RetrieveSpecies
    {
        #region Query

        public class Query : IRequest<(bool IsSuccess,IEnumerable<Species> Result)>
        {
        }

        #endregion Query

        #region Handler

        public class Handler : IRequestHandler<Query, (bool IsSuccess,IEnumerable<Species> Result)>
        {
            private readonly IJediEnrollmentService _enrollmentService;

            public Handler(IJediEnrollmentService enrollmentService)
            {
                _enrollmentService = enrollmentService;
            }

            public async Task<(bool IsSuccess,IEnumerable<Species> Result)> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _enrollmentService.GetAvailableSpecies();
            }
        }

        #endregion Handler
    }
}