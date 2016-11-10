using System;
using Xunit;
using EngineeringCore.Algorithms.Sorting;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
           List<int> numbers = new List<int> {9, 7, 6, 3, 2, 1};
           List<int> numberstocompare = new List<int> {1, 2, 3, 6, 7, 9};

            numbers.BubblesortAscending(Comparer<int>.Default);
            Assert.True(Enumerable.SequenceEqual());
            
                     
             
        }
    }
}
