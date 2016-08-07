namespace Options.Option
{
    public class AndOption<T> : Option<T>
    {
        private readonly IOption<T> leftOption;
        private readonly IOption<T> rightOption;

        public AndOption(IOption<T> left, IOption<T> right)
        {
            this.leftOption = left;
            this.rightOption = right;
        }

        public override bool MeetsRequirements(T o)
        {
            return this.leftOption.MeetsRequirements(o)
                && this.rightOption.MeetsRequirements(o);
        }
    }
}
