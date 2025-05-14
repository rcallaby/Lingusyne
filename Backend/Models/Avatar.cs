namespace LanguageBotPrototype.Models
{
    public class Avatar
    {
        public string Name { get; set; }
        public ITeachingStrategy Strategy { get; set; }

        public Avatar(string name, ITeachingStrategy strategy)
        {
            Name = name;
            Strategy = strategy;
        }

        public string Respond(string topic)
        {
            return $"{Name}: {Strategy.Teach(topic)}";
        }
    }
}
