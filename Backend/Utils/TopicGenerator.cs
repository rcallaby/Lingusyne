using System;

namespace LanguageBotPrototype.Utils
{
    public static class TopicGenerator
    {
        private static readonly string[] Topics = { "food", "travel", "weather", "family", "school" };

        public static string ExtractTopic(string userInput)
        {
            Random rand = new Random();
            return Topics[rand.Next(Topics.Length)];
        }
    }
}
