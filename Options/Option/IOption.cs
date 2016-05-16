using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public interface IOption<T>
    {
        bool MeetsRequirements(T o);
        IOption<T> And(IOption<T> option);
        IOption<T> Or(IOption<T> option);
        IOption<T> Not(IOption<T> option);
    }
}
