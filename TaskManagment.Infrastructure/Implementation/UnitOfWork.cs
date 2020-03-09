using System;
using System.Collections.Generic;
using System.Text;
using TaskManagment.Repository.Abstraction;

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
