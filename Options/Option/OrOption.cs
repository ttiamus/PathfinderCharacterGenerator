using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options.Option
{
    public class OrOption<T> : Option<T>
    {
        private readonly IOption<T> leftOption;
        private readonly IOption<T> rightOption;

        public OrOption(IOption<T> left, IOption<T> right)
        {
            this.leftOption = left;
            this.rightOption = right;
        }

        public override bool MeetsRequirements(T o)
        {
            return this.leftOption.MeetsRequirements(o)
                || this.rightOption.MeetsRequirements(o);
        }
    }
}
