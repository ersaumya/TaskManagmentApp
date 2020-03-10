﻿using System;
using System.Collections.Generic;
using System.Text;
using TaskManagment.Core.Enums;

namespace TaskManagment.Core.Entities
{
    public class Task
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TaskStatus Status { get; set; }


        public DateTime DueDate { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

    }
}
        