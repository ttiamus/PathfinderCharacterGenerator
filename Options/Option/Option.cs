namespace Options.Option
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
