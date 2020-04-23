namespace NetExtensions.ExtensionMethods.Tests.DateTimeExtensionsTests
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