using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagment.Application.Tasks.Commands
{
    public class DeleteTaskCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
