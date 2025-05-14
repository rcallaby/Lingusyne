
using LanguageBotPrototype.Models;

namespace LanguageBotPrototype.Services
{
    public class AvatarService
    {
        public string GetAvatarResponse(string type, string topic)
        {
            var avatar = AvatarFactory.CreateAvatar(type);
            return avatar.Respond(topic);
        }
    }
}
