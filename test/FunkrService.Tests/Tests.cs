using System;
using ConsoleApplication;
using Xunit;

namespace Funkr.UnitTests.Servics
{
    public class FunkrService_ProcessEventData
    {

        private readonly ConsoleApplication.FunkrService _funkrService;

        public FunkrService_ProcessEventData() 
        {
            _funkrService = new FunkrService();
        }

        [Fact]
        public void ParseBasicEvent() 
        {

            Assert.True(false);
        }
    }
}
