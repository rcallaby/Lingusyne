namespace LanguageBotPrototype.Models
{
    public class ConversationPractice : ITeachingStrategy
    {
        public string Teach(string topic)
        {
            return $"Let's have a conversation about '{topic}'. How would you greet someone in that context?";
        }
    }
}
