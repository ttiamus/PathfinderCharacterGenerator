using System.Collections.Generic;

namespace Core.Feats
{
    public class Feat
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public List<string> Requirements { get; set; }
        public string Effect { get; set; }
    }
}
