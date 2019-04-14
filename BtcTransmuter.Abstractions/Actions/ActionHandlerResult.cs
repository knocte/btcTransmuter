using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BtcTransmuter.Abstractions.Actions
{
    public class ActionHandlerResult
    {
        public bool Executed { get; set; }
        public string Result { get; set; }
        public object Data { get; protected set; }
        

        public virtual string DataJson => JObject.FromObject(Data).ToString();
    }

    public class StringJsonResult
    {
        public StringJsonResult()
        {
            
        }
        public StringJsonResult(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}