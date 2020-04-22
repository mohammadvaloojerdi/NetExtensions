namespace NetExtensions.PrimitiveExtensions.Tests.DateTimeTests
{
    public class BaseDateTimeTests
    {
        protected readonly ClockStub Clock;

        public BaseDateTimeTests()
        {
            Clock = new ClockStub();
        }
    }
}