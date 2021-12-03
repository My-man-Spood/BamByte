using Bambyte.InMemoryRepo;
using Bambyte.InMemoryRepo.Models.PlanningPoker;
using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bambyte.PlanningPoker.Modules
{
    public class PlanningPokerModule : ModuleBase<SocketCommandContext>
    {
        IRepo repo;

        public PlanningPokerModule(IRepo repo)
        {
            this.repo = repo;
        }

        [Command("vote")]
        public async Task Send(string votingSubject)
        {
            var embed = new EmbedBuilder
            {
                Title = FormatMessage(votingSubject)
            }.Build();

            var voteMessage = await ReplyAsync(embed: embed);
            await voteMessage.AddReactionAsync(new Emoji("👍"));

            var vote = new Vote(Guid.NewGuid().ToString(), voteMessage.Id, votingSubject);
            repo.Create(vote);
        }

        private string FormatMessage(string votingSubject)
        {
            StringBuilder stbMessage = new StringBuilder();

            stbMessage.AppendLine($"Nous votons présentement pour: {votingSubject}");
            stbMessage.AppendLine("Pour participer ajouter une reaction a ce message.");

            return stbMessage.ToString();
        }
    }
}
