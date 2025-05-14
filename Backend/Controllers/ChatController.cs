using Microsoft.AspNetCore.Mvc;
using LanguageBotPrototype.Services;
using LanguageBotPrototype.Utils;

namespace LanguageBotPrototype.Controllers
{
    [ApiController]
    [Route("chat")]
    public class ChatController : ControllerBase
    {
        private readonly AvatarService _avatarService;

        public ChatController(AvatarService avatarService)
        {
            _avatarService = avatarService;
        }

        [HttpGet("{avatarType}/{userInput}")]
        public IActionResult GetResponse(string avatarType, string userInput)
        {
            var topic = TopicGenerator.ExtractTopic(userInput);
            var response = _avatarService.GetAvatarResponse(avatarType, topic);
            return Ok(response);
        }
    }
}
