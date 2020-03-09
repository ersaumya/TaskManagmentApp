﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskManagment.Application.Tasks.Commands;
using TaskManagment.Repository.Abstraction;

namespace TaskManagment.Application.Tasks.Handlers
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTaskCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Tasks.Delete(request.Id);
            return result;
        }
    }
}
