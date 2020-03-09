using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagment.Application.Tasks.Dto;

namespace TaskManagment.Application.Tasks.Queries
{
    public class GetTaskByIdQuery : IRequest<TaskDto>
    {
        public int Id { get; set; }
    }
}
