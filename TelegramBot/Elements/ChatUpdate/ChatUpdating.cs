using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot.Elements.ChatUpdate
{
    public abstract class ChatUpdating
    {       
        public abstract void Action(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken);     
    }
}
