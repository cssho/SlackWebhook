using System;
using System.Threading.Tasks;
using ConsoleAppFramework;
using Microsoft.Extensions.Hosting;
using Slack.Integration.IncomingWebhook;

namespace SlackWebhook
{
    class Program : ConsoleAppBase
    {
        static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder().RunConsoleAppFrameworkAsync<Program>(args);
        }

        public async Task Run(string url, string text = null, string channel = null, string userName = null)
        {
            if (text == null)
            {
                while (true)
                {
                    var line = Console.ReadLine();

                    if (line == null) break;
                    else text = (text ?? "") + line;
                }
            }
            if (text == null) throw new ArgumentNullException(nameof(text));

            await new WebhookClient().SendAsync(url, new Payload { Text = text, Channel = channel, UserName = userName });
        }
    }
}
