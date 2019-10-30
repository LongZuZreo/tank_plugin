using System.Collections.Generic;

namespace tank_plugin
{
    public class DefinitionNode
    {
        public string Name { get; set; }
        public IList<DefinitionNode> Children { get; set; }
    }
}