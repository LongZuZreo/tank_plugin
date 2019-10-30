using System.Collections.Generic;

namespace tank_plugin
{
    public class DefinitonNode
    {
        public string Name { get; set; }
        public IList<DefinitonNode> Children { get; set; }
    }
}