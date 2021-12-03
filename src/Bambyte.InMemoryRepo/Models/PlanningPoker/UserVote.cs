using System;
using System.Collections.Generic;
using System.Text;

namespace Bambyte.InMemoryRepo.Models.PlanningPoker
{
    public class UserVote : BaseModel
    {
        public string UserId { get; set; }

        public int Value { get; set; }
    }
}
