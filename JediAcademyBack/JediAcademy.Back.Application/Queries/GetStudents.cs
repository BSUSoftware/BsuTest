using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JediAcademy.Back.Domain.Entities;
using JediAcademy.Back.Domain.Services;
using MediatR;

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
            private readonly IJediStudentsService _jediStudentsService;

            public Handler(IJediStudentsService jediStudentsService)
            {
                _jediStudentsService = jediStudentsService;
            }

            public Task<(bool IsSuccess, IEnumerable<JediStudent> Result, string Message)> Handle(Query request, CancellationToken cancellationToken)
            {
                return _jediStudentsService.GetJediStudents();
            }
        }

        #endregion Handler
    }
}