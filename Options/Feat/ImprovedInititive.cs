using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options.Feat
{
    public class ImprovedInititive<T> : Option<T>
    {
        public string Description { get; }

        public override bool MeetsRequirements(T character)
        {
            return true;
        }

        public T Add(T character)
        {
            //add bonus to inititive
            return character;
        }

        public T Remove(T character)
        {
            //Remove bonus to inititive 
            return character;
        }
    }
}
