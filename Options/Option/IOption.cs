namespace Options.Option
{
    public interface IOption<T>
    {
        bool MeetsRequirements(T o);
        IOption<T> And(IOption<T> option);
        IOption<T> Or(IOption<T> option);
        IOption<T> Not(IOption<T> option);
    }
}
