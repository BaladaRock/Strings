using System;
using Xunit;

namespace StringOperations
{
    public class StringOperationsFacts
    {
        [Fact]
        public void Test_Remove_Ending_Null()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', null);
            //Then
            Assert.Null(result);
        }

        [Fact]
        public void Test_Remove_Ending_Simple_Case()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', "Costelaaaa");
            //Then
            Assert.Equal("Costel", result);
        }

        [Fact]
        public void Test_Remove_Ending_Repeating_Elements()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', "aaaaaaaaaaaa");
            //Then
            Assert.Empty(result);
        }

        [Fact]
        public void Test_RemoveEnding_String_Should_Remain_The_Same()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', "aaaaab");
            //Then
            Assert.Equal("aaaaab", result);
        }

        [Fact]
        public void Test_RemoveEnding_More_Complicated_Case()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', "ACaabCostaartaaa");
            //Then
            Assert.Equal("ACaabCostaart", result);
        }

        [Fact]
        public void Test_RemoveEnding_Should_Remove_From_End_Another_Test()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', "ACaabCostaartaaab");
            //Then
            Assert.Equal("ACaabCostaartaaab", result);
        }

        [Fact]
        public void Test_Remove_Ending_Should_Remove_From_End_One_Character_Word()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', "a");
            //Then
            Assert.Empty(result);
        }

        [Fact]
        public void Test_Remove_Ending_String_Should_Remove_From_End_Empty_String()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveEndingCharacters('a', string.Empty);
            //Then
            Assert.Empty(result);
        }

        [Fact]
        public void Test_RemoveDuplicates_Should_Correctly_Work_For_Null()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveDuplicates('a', null);
            //Then
            Assert.Null(result);
        }

        [Fact]
        public void Test_RemoveDuplicates_Simple_Case()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveDuplicates('a', "AAnndreiaa");
            //Then
            Assert.Equal("AAnndreia", result);
        }

        [Fact]
        public void Test_RemoveDuplicates_More_Complicated_Case()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveDuplicates('a', "aaaaaaaaaaaaaaa");
            //Then
            Assert.Equal("a", result);
        }

        [Fact]
        public void Test_RemoveDuplicates_String_Should_Remain_The_Same()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveDuplicates('b', "aaaaa");
            //Then
            Assert.Equal("aaaaa", result);
        }

        [Fact]
        public void Test_RemoveDuplicates_String_2_Characters()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveDuplicates('b', "bb");
            //Then
            Assert.Equal("b", result);
        }

        [Fact]
        public void Test_RemoveDuplicates_Final_Test()
        {
            //Given
            var testObject = new StringOperations();
            //When
            string result = testObject.RemoveDuplicates('a', "aabbbcaaaadaaraagaaaaaaaaaaaaa");
            //Then
            Assert.Equal("abbbcadaraga", result);
        }
    }
}
