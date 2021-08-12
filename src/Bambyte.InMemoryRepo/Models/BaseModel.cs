﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bambyte.InMemoryRepo.Models
{
    public abstract class BaseModel
    {
        public ulong Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public BaseModel()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
