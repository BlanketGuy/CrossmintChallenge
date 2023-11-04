using CrossmintChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CrossmintChallenge.JsonConverters
{
    internal class AstralObjectConverter : JsonConverter<IAstralObject>
    {
        public override IAstralObject Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(
            Utf8JsonWriter writer,
            IAstralObject value,
            JsonSerializerOptions options)
        {
            var type = value.GetType();
            JsonSerializer.Serialize(writer, value, type, options);
        }
    }
}
