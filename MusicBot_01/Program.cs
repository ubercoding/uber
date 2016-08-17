using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBot_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new DiscordClient();

            bot.ExecuteAndWait(async () =>
            {

                await bot.Connect("MjE0NjEwODA1MDU4OTYxNDA5.CpPBYg.UwzA9P-f3-1yYVnlftdoujI9guo");

            });
        }

            // This code is executed every time a message is recieved
            private void Bot_MessageRecieved(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) return;

            if(e.Message.Text == "rules")
            {
                e.Channel.SendMessage(e.User.Mention + " http//reddit.com/r/sourcefed");
            }

            if (e.Message.Text.ToLower().Contains("who is musicbot"))
            {
                e.Channel.SendMessage(e.User.Mention + " Review Movie World");
            }  
           }
        }
 
   }





