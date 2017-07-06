namespace practCalculate.TwoArg
{
    /// <summary>
    /// Interface for all two arguments operations.
    /// </summary>
    public interface ITwoArgCalc
    {
        /// <summary>
        /// Calculation one argumet operation.
        /// </summary>
        /// <param name="firstArg"></param>
        /// <param name="secondArg"></param>
        /// <returns></returns>
        double Calculate(double firstArg, double secondArg);
    }
}
