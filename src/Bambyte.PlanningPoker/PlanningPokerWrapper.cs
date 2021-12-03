//using Bambyte.InMemoryRepo;
//using Bambyte.InMemoryRepo.Models.PlanningPoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bambyte.PlanningPoker
{
    public class PlanningPokerWrapper
    {
        //IRepo repo; 

        public PlanningPokerWrapper(/*IRepo repo*/)
        {
            //this.repo = repo;
        }

        public void AddUserVote(ulong messageId, string userId, int value)
        {
            //var userVote = new UserVote() { 
            //    Id = Guid.NewGuid().ToString(),
            //    UserId = userId,
            //    Value = value
            //};

            //var votes = repo.GetAll<Vote>();

            //var vote = votes.FirstOrDefault(v => v.MessageId == messageId);
            //if (vote == null)
            //{
            //    return;
            //}

            //vote.AddUserVote(userId, value);            
            //repo.Update(vote.Id, userVote);
        }
    }
}
