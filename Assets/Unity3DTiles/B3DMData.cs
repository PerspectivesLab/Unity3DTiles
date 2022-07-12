using Newtonsoft.Json.Linq;
using System.Collections.Generic;

public class B3DMData
{
    private Dictionary<string, List<JToken>> _batchTable = new Dictionary<string, List<JToken>>();


    public Dictionary<string, List<JToken>> BatchTable { get => _batchTable; set => _batchTable = value; }

    public B3DMData()
    {
    }
}
