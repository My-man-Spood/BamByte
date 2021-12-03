using System;
using System.Collections.Generic;
using System.Text;

namespace Bambyte.InMemoryRepo.Models.PlanningPoker
{
    public class Vote : BaseModel
    {
        public Vote(string id, ulong messageId, string subject)
        {
            base.Id = id;
            this.MessageId = messageId;
            this.Suject = subject;
            this.userVotes = new List<UserVote>();
        }

        public ulong MessageId { get; set; }

        public string Suject { get; set; }

        List<UserVote> userVotes;

        public void AddUserVote(string userId, int value)
        {
            var userVote = new UserVote()
            {
                UserId = userId,
                Value = value
            };

            userVotes.Add(userVote);
        }
    }
}
