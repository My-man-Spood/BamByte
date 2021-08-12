using Bambyte.PlanningPoker.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bambyte.PlanningPoker
{
    public class PlanningPokerWrapper
    {
        IRepo repo; 

        public PlanningPokerWrapper(IRepo repo)
        {
            this.repo = repo;
        }

        public void AddUserVote(ulong messageId, string userId, int value)
        {
            repo.AddUserReponse(messageId, userId, value);
        }
    }
}
