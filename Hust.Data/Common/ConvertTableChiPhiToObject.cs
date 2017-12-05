using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using Newtonsoft.Json;

namespace Hust.Data.Common
{
    public static class ConvertTableChiPhiToObject
    {
        public static List<GettingStarted> ListData(string json)
        {
            return GettingStarted.FromJson(json);
        }
    }
    public partial class GettingStarted
    {
        [JsonProperty("ChiPhiSuDung")]
        public string ChiPhiSuDung { get; set; }

        [JsonProperty("STT")]
        public string STT { get; set; }

        [JsonProperty("TenNhanVien")]
        public string TenNhanVien { get; set; }
    }

    public partial class GettingStarted
    {
        public static List<GettingStarted> FromJson(string json) => JsonConvert.DeserializeObject<List<GettingStarted>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<GettingStarted> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}