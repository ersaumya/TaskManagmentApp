using System;
using System.Collections.Generic;
using System.Text;
using TaskManagment.Application.Abstraction;

namespace TaskManagment.Infrastructure.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Tasks = taskRepository;
        }
        public ITaskRepository Tasks { get; }
    }
}
