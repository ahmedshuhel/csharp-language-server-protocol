using Newtonsoft.Json;

namespace OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities
{
    public class SignatureHelpCapability : DynamicCapability, ConnectedCapability<ISignatureHelpHandler>
    {
        /// <summary>
        /// The client supports the following `SignatureInformation`
        /// specific properties.
        /// </summary>
        [Optional]
        public SignatureInformationCapability SignatureInformation { get; set; }
    }
}
