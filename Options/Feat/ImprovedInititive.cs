﻿using Options.Option;

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
