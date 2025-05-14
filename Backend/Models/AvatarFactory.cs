namespace LanguageBotPrototype.Models
{
    public static class AvatarFactory
    {
        public static Avatar CreateAvatar(string type)
        {
            return type switch
            {
                "grammar_bot" => new Avatar("Grammarian", new GrammarFocus()),
                "chatty_bot" => new Avatar("Conversationalist", new ConversationPractice()),
                _ => new Avatar("DefaultBot", new GrammarFocus()),
            };
        }
    }
}
