using FluentAssertions;
using search_tdd;
using search_tddTests4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace search_tdd.Tests
{
    public class indexingTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public indexingTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        //[Fact]
        //public void indexingTest()
        //{
        //    Assert.Fail("a");
        //}
        [Fact]
        public void ReturnsWordIfExistsInDictionary()
        {
            //arrange
            List<string> list1 = new List<string>();
            list1.Add("hello i am a blackboard understand are you good that is a pen");
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens = new DictionaryOfFilesAndTokens();
            dictionaryOfFilesAndTokens.SetTokenIndices(0, new List<int>() { 2 });
            indexing Indexing = new indexing(list1);
            //act
            //assert

            var result = Indexing.Search("am");
            Assert.Equal(result.GetDictionary(), dictionaryOfFilesAndTokens.GetDictionary());
        }
        [Fact]
        public void ReturnsNullIfWordDoesntExist()
        {
            //arrange
            List<string> list = new List<string>();
            list.Add("hello i am a blackboard understand are you good that is a pen");
            indexing Indexing = new indexing(list);
            //act
            //assert
            var result = Indexing.Search("bear");
            Assert.Null(result);
        }

        [Fact]
        public void ReturnsAllOfIndexesOfOneFileIfExistsInDictionary()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            List<string> list3 = new List<string>();
            list3.Add("hello i am a blackboard understand are you good that is a pen");
            List<Dictionary<int, List<int>>> listOfdictionaryOfFilesAndTokens = new List<Dictionary<int, List<int>>>();
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens = new DictionaryOfFilesAndTokens();
            for (int i = 0; i <= 12; i++)
            {

                if (i == 3)
                {
                    printer.Print("hey");
                    dictionaryOfFilesAndTokens.AddTokenIndices(0, 3);
                    dictionaryOfFilesAndTokens.AddTokenIndices(0, 11);
                }
                else if (i != 11)
                {
                    printer.Print("hey3");
                    dictionaryOfFilesAndTokens.AddTokenIndices(0, i);
                }

            }

            indexing Indexing = new indexing(list3);
            //act


            List<Dictionary<int, List<int>>> listOfdictionaryOfFilesAndTokens2 = new List<Dictionary<int, List<int>>>();
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens0 = new DictionaryOfFilesAndTokens();
            var result = Indexing.Search("hello");
            printer.Print(result.GetDictionary());
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));

            result = Indexing.Search("i");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));

            result = Indexing.Search("am");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));

            result = Indexing.Search("a");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("blackboard");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("understand");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("are");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("you");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("good");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("that");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("is");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            result = Indexing.Search("pen");
            dictionaryOfFilesAndTokens0.AddTokenIndices(0, result.GetTokenIndices(0));
            //assert
            printer.Print(dictionaryOfFilesAndTokens.GetDictionary());
            printer.Print(dictionaryOfFilesAndTokens0.GetDictionary());
            Assert.Equal(dictionaryOfFilesAndTokens.GetDictionary(), dictionaryOfFilesAndTokens0.GetDictionary());
        }

        [Fact]
        public void SetTokenDictionaryTest()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens9 = new DictionaryOfFilesAndTokens();
            //act
            dictionaryOfFilesAndTokens9.SetTokenIndices(0, new List<int> { 0 });
            //assert
            Assert.Equal(dictionaryOfFilesAndTokens9.GetDictionary(), new Dictionary<int, List<int>> { [0] = new List<int> { 0 } });

        }
        [Fact]
        public void SetTokenIndicesTest()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens8 = new DictionaryOfFilesAndTokens();
            //act
            dictionaryOfFilesAndTokens8.SetTokenIndices(0, new List<int> { 0 });
            //assert
            Assert.Equal(dictionaryOfFilesAndTokens8.GetDictionary(), new Dictionary<int, List<int>> { [0] = new List<int> { 0 } });
        }
        [Fact]
        public void GetTokenIndicesTest()
        {
            //arrange
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens7 = new DictionaryOfFilesAndTokens();
            //act
            dictionaryOfFilesAndTokens7.SetTokenIndices(0, new List<int> { 0 });
            //assert
            Assert.Equal(dictionaryOfFilesAndTokens7.GetTokenIndices(0), new List<int> { 0 });
        }
        [Fact]
        public void AddTokenIndicesIfTokenDoesntExistTest()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens6 = new DictionaryOfFilesAndTokens();
            //act
            dictionaryOfFilesAndTokens6.AddTokenIndices(0, 0);
            //assert
            Assert.Equal(dictionaryOfFilesAndTokens6.GetDictionary(), new Dictionary<int, List<int>> { [0] = new List<int> { 0 } });
        }

        [Fact]
        public void AddTokenIndicesIfTokenExistTest()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens9 = new DictionaryOfFilesAndTokens();
            //act
            dictionaryOfFilesAndTokens9.AddTokenIndices(0, 0);
            dictionaryOfFilesAndTokens9.AddTokenIndices(0, 1);

            //assert
            printer.Print(dictionaryOfFilesAndTokens9.GetDictionary());
            Assert.Equal(dictionaryOfFilesAndTokens9.GetDictionary(), new Dictionary<int, List<int>> { [0] = new List<int> { 0, 1 } });
        }

        [Fact]
        public void Indexing_TwoFielsWithSimilarWordsinside_ReturnTrueIfSearchWorksCorrectly()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            List<string> list6 = new List<string>();
            list6.Add("hello i am a blackboard understand are you good that is a pen");
            list6.Add("there is an imposter amongus, amugos. the pen is on the blackboarD");
            //act
            indexing indexing1 = new indexing(list6);
            var result = indexing1.Search("blackboard");
            Dictionary<int, List<int>> dictionary1 = new Dictionary<int, List<int>>
            {
                [0] = new List<int>{ 4 },
                [1] = new List<int> { 11 }
            };
            printer.Print(result.GetDictionary());
            printer.Print(dictionary1);
            //assert
            Assert.Equal(dictionary1, result.GetDictionary());
        }

        [Fact]
        public void Indexing_TwoFielsWithSimilarWordsinside_ReturnsTrueIfResultOfAnNonExistingSearchISNull()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            List<string> list10 = new List<string>();
            list10.Add("hello i am a blackboard understand are you good that is a pen");
            list10.Add("there is an imposter amongus, amugos. the pen is on the blackboarD");
            //act
            indexing indexing9 = new indexing(list10);
            var result4 = indexing9.Search("AliMirzaei");
            //assert
            Assert.Null(result4);
        }

        [Fact]
        public void ReturnsIndexOfWordIfExistsAndInputStringIsNotClean()
        {
            //arrange
            var printer = new Printer(new TestOutputWriter(_testOutputHelper));
            List<string> list4 = new List<string>();
            list4.Add("he,l!lo #i a@m$ a/ b\\l%a^c&k*b[o\"a;r-d u$nderstand_a'r~e:y|ou good that is a pen");
            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens1 = new DictionaryOfFilesAndTokens();


            dictionaryOfFilesAndTokens1.SetTokenIndices(0, new List<int> { 0, 1, 2, 3, 11, 4, 5, 6, 7, 8, 9, 10, 12 });

            DictionaryOfFilesAndTokens dictionaryOfFilesAndTokens10 = new DictionaryOfFilesAndTokens();
            indexing Indexing = new indexing(list4);
            //act

            //assert
            var result1 = Indexing.Search("hello");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));

            result1 = Indexing.Search("i");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            printer.Print(result1);
            result1 = Indexing.Search("am");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));

            result1 = Indexing.Search("a");
            printer.Print(result1.GetDictionary());
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("blackboard");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("understand");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("are");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("you");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("good");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("that");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("is");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));
            result1 = Indexing.Search("pen");
            dictionaryOfFilesAndTokens10.AddTokenIndices(0, result1.GetTokenIndices(0));

            printer.Print(dictionaryOfFilesAndTokens1.GetDictionary());
            printer.Print(dictionaryOfFilesAndTokens10.GetDictionary());
            Assert.Equal(dictionaryOfFilesAndTokens1.GetDictionary(), dictionaryOfFilesAndTokens10.GetDictionary());
        }

    }
}