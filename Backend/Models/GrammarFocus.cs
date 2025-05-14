namespace LanguageBotPrototype.Models
{
    public class GrammarFocus : ITeachingStrategy
    {
        public string Teach(string topic)
        {
            return $"Let's study the grammar rules of '{topic}'. Can you conjugate the verb in present tense?";
        }
    }
}