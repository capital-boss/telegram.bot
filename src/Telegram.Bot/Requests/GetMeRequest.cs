using System.Net.Http;
using Telegram.Bot.Types;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// A simple method for testing your bot's auth token. Requires no parameters.
    /// Returns basic information about the bot in form of a <seealso cref="User"/> object.
    /// </summary>
    public class GetMeRequest : RequestBase<User>
    {
        /// <summary>
        /// Initializes an instance of <seealso cref="GetMeRequest"/>
        /// </summary>
        public GetMeRequest()
            : base("getMe", HttpMethod.Get)
        { }
    }
}
