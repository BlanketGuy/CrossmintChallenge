using CrossmintChallenge.JsonConverters;
using System.Text.Json.Serialization;

namespace CrossmintChallenge.Models
{
    [JsonConverter(typeof(AstralObjectConverter))]
    public interface IAstralObject
    {
        public string CandidateId { get; }
        public int Row { get; set; }
        public int Column { get; set; }

        string GetEndpoint();
    }
}
