using System;
using System.Collections.Generic;
using System.Text;

namespace Bambyte.PlanningPoker.Models
{
    public class Vote
    {
        public Vote(string id, ulong messageId, string subject)
        {
            this.Id = id;
            this.MessageId = messageId;
            this.Suject = subject;
            this.userVotes = new List<UserVote>();
        }

        public string Id { get; set; }

        public ulong MessageId { get; set; }

        public string Suject { get; set; }

        List<UserVote> userVotes;

        public void AddUserVote(ulong messageId, string userId, int value)
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
