using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Types;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Use this method to get a sticker set. On success, a <see cref="StickerSet"/> object is returned.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetStickerSetRequest : RequestBase<StickerSet>
    {
        /// <summary>
        /// Name of the sticker set
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Initializes an instance of <see cref="GetStickerSetRequest"/>
        /// </summary>
        public GetStickerSetRequest()
            : base("getStickerSet")
        { }

        /// <summary>
        /// Initializes an instance of <see cref="GetStickerSetRequest"/>
        /// </summary>
        public GetStickerSetRequest(string name)
            : base("getStickerSet")
        {
            Name = name;
        }
    }
}
