using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.ChatAttributes;

namespace TelegramBot.Elements.ChatUpdate
{
    [ChatUpdate(Telegram.Bot.Types.Enums.UpdateType.Message)]
    internal class ChatMessageUpdating : ChatUpdating
    {
        public override async void Action(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
