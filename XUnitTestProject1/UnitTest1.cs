using System.Threading;
using Xunit;
using BreakfastTesting;

namespace Unit6._5_Template
{
    public class UnitTest1
    {
        [Fact]
        public void TestPouringCoffee()
        {
            var coffee = Breakfast.PourCoffee();
            Assert.True(typeof(Coffee) == coffee.GetType());
        }

        [Fact]
        public void TestCoffeeTemperature()
        {
            var coffee = Breakfast.PourCoffee();
            Assert.Equal("Hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Quite hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Not so hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Cold", coffee.Temperature);
        }
        
        [Fact]
        public void TestFryingEggsLength()
        {
            var eggs = Breakfast.FryEggs(2);
            Assert.Equal(2, eggs.Count);
            Assert.Equal("2 eggs", eggs.Print());
        }
        
        [Fact]
        public void TestFryingBaconLength()
        {
            var bacon = Breakfast.FryBacon(3);
            Assert.Equal(3, bacon.Count);
            Breakfast.EatBacon(bacon, 2);
            Assert.Equal(1, bacon.Count);
        }

        
        [Fact]
        public void TestToastingBreadLength()
        {
            var toasts = Breakfast.ToastBread(2);
            Assert.Equal(2, toasts.Count);
        }
        
        [Fact]
        public void TestApplyingToToast()
        {
            var toasts = Breakfast.ToastBread(2);

            Breakfast.ApplyButter(toasts[0]);
            Breakfast.ApplyJam(toasts[1]);

            Assert.False(toasts[0].JamApplied);
            Assert.False(toasts[1].ButterApplied);
            Assert.True(toasts[1].JamApplied);
            Assert.True(toasts[0].ButterApplied);
        }
    }
}
