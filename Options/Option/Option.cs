using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Options.Option;

namespace Options
{
    public abstract class Option<T> : IOption<T>
    {
        public abstract bool MeetsRequirements(T o);

        public IOption<T> And(IOption<T> option)
        {
            return new AndOption<T>(this, option);
        }

        public IOption<T> Or(IOption<T> option)
        {
            return new OrOption<T>(this, option);
        }

        public IOption<T> Not(IOption<T> option)
        {
            return new NotOption<T>(this, option);
        }
    }
}
