using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using TelegramBot.Elements.ChatUpdate;

namespace TelegramBot.ChatAttributes
{
    [System.AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    internal class ChatUpdateAttribute : Attribute
    {       
        public UpdateType ChatUpdateType { get; }

        public ChatUpdateAttribute(UpdateType chatUpdateType)
        {
            ChatUpdateType = chatUpdateType;
        }

        public static bool operator ==(ChatUpdateAttribute left, UpdateType right) => left.ChatUpdateType == right;
        public static bool operator !=(ChatUpdateAttribute left, UpdateType right) => !(left == right);
    }
}
