using Bambyte.PlanningPoker.Models;
using Bambyte.PlanningPoker.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bambyte.PlanningPoker.Repos
{
    public class InMemoryRepo : IRepo
    {
        List<Vote> votes;

        public InMemoryRepo()
        {
            votes = new List<Vote>();
        }

        public void AddUserReponse(ulong messageId, string userId, int value)
        {
            var vote = votes.Find(v => v.MessageId == messageId);
            vote.AddUserVote(messageId, userId, value);
        }

        public void CreateVoteSubject(ulong messageId, string subject)
        {
            var vote = new Vote(Guid.NewGuid().ToString(), messageId, subject);
            votes.Add(vote);
        }

        public Vote GetVoteSubjectByMessageId(ulong messageId)
        {
            return votes.Find(v => v.MessageId == messageId);
        }

        public bool IsMessageIdAVote(ulong messageId)
        {
            return votes.Exists(v => v.MessageId == messageId);
        }
    }
}
