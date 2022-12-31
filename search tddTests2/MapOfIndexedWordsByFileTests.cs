using search_tdd;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace search_tdd.Tests
{
    public class MapOfIndexedWordsByFileTests
    {
        [Fact]
        public void ReturnNullWhenDictionaryIsNull()
        {
            //arrange
            MapOfIndexedWordsByFile mapOfIndexedWordsByFile = new MapOfIndexedWordsByFile(null);
            //act

            //assert
            Assert.Null(mapOfIndexedWordsByFile.Dictionary);
        }

        [Fact]
        public void ReturnsDictionaryOfFileAndIndexForOneWordWithTwoIndex()
        {
            //arrange
            MapOfIndexedWordsByFile mapOfIndexedWordsByFile4 = new MapOfIndexedWordsByFile(new Dictionary<string, Dictionary<int, List<int>>>
            {
                ["mamad"] = new Dictionary<int, List<int>>() { 
                    [1] = new List<int> { 2 },
                    [2] = new List<int> { 5 }
                }
            });
            Dictionary<int, List<int>> mmd = new Dictionary<int, List<int>>
            {
                [1] = new List<int> { 1 }
            };
            bool a = mmd.Equals(new Dictionary<int, List<int>>
            {
                [1] = new List<int> { 1 }
            });
            Console.WriteLine(a);
            //act
            var result = mapOfIndexedWordsByFile4.Search("mamad");
            //assert
            Assert.Equal(result, new Dictionary<int, List<int>>()
            {
                [1] = new List<int> { 2 },
                [2] = new List<int> { 5 }
            });
        }

        [Fact]
        public void PassesIfDictionarySuccessfullyInitialized()
        {
            //arrange
            MapOfIndexedWordsByFile mapOfIndexedWordsByFile1 = new MapOfIndexedWordsByFile(new Dictionary<string, Dictionary<int, List<int>>>
            {
                ["ali"] = new Dictionary<int, List<int>>() { [1] = new List<int> { 1 } }
            });
            //act
            var result = mapOfIndexedWordsByFile1.Dictionary;
            //assert
            Console.WriteLine(Convert.ToString(result));
            Assert.Equal(mapOfIndexedWordsByFile1.Dictionary, result);
        }

        [Fact]
        public void ReturnsDictionaryOfFileAndIndexForOneWordWithOneIndex()
        {
            //arrange
            MapOfIndexedWordsByFile mapOfIndexedWordsByFile3 = new MapOfIndexedWordsByFile(new Dictionary<string, Dictionary<int, List<int>>>
            {
                ["ali"] = new Dictionary<int, List<int>>() { [1] = new List<int> { 1 } }
            });
            Dictionary<int, List<int>> mmd = new Dictionary<int, List<int>>
            {
                [1] = new List<int> { 1 }
            };
            bool a = mmd.Equals(new Dictionary<int, List<int>>
            {
                [1] = new List<int> { 1 }
            });
            Console.WriteLine(a);
            //act
            var result = mapOfIndexedWordsByFile3.Search("ali");
            //assert
            Assert.Equal(result, new Dictionary<int, List<int>>() { [1] = new List<int> { 1 } });
        }
    }
}