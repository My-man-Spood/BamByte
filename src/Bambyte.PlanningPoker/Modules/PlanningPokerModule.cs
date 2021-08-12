using Bambyte.PlanningPoker.Repo;
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

            repo.CreateVoteSubject(voteMessage.Id, votingSubject);
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
