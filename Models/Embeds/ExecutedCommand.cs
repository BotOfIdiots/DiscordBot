﻿using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace DiscordBot.Models.Embeds
{
    public class ExecutedCommand : EmbedBuilder
    {
        public ExecutedCommand(SocketCommandContext context, IMessage message)
        {
            IUser author = message.Author;
            
            WithAuthor(author.Username + "#" + author.Discriminator, author.GetAvatarUrl());
            WithTitle("Command successfully executed");
            WithColor(Discord.Color.DarkBlue);
            WithDescription(message.Content);
            AddField("Origin Channel", "<#" + message.Channel.Id + "> (" + message.Channel.Id + ")");
            WithCurrentTimestamp();
            WithFooter("UserID: " + author.Id);
        }
    }
}