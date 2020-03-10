using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskManagment.Application.Tasks.Commands;
using TaskManagment.Application.Abstraction;

namespace TaskManagment.Application.Tasks.Handlers
{
    //Every request needs a handler that will handle the request.The CreateTaskCommand is the request and then the int is the output.
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateTaskCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Tasks.Add(_mapper.Map<TaskManagment.Core.Entities.Task>(request));
            return result;
        }
    }
}
