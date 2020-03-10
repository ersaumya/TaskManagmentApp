using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagment.Application.Abstraction
{
    public interface IUnitOfWork
    {
        ITaskRepository Tasks { get; }
    }
}
