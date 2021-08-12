using Bambyte.PlanningPoker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bambyte.PlanningPoker.Repo
{
    public interface IRepo
    {
        void CreateVoteSubject(ulong messageId, string subject);

        bool IsMessageIdAVote(ulong messageId);

        Vote GetVoteSubjectByMessageId(ulong messageid);

        void AddUserReponse(ulong messageId, string userId, int value);       
    }
}
