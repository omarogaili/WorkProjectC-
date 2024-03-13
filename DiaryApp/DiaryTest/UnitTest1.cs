//using DiaryDataBase;
//using System.Reflection.Metadata;
//using Xunit;
//namespace DiaryTest
//{
//    public class UnitTest1
//    {
//        public void Test1()
//        {
//            [Theory]
//            [InlineData("12345",false )]
//            [InlineData("Omar", true)]
//            [InlineData("O!m?r", false)]

//            //Gavin_When_than
//            public void GetTheBarCodeScaned_Contians_ASting(string barCode, bool expectedResult)
//            {
//                //arrange
//                User sut= new User();


//                //act 
//                var result = sut.IsvalidName(barCode, expectedResult);
//                //Assert 
//                Assert.Equal(expectedResult, result);
//            }
//        }
//    }
//}using DiaryDataBase;
using DiaryDataBase;
using Xunit;

namespace DiaryTest
{
    //Kan du d�pa om den h�r klassen till n�got mer talande?
    //"UnitTest1" s�ger inte s� mycket om vad den g�r.
    //Kanske n�got i stil med "UserDataTests"?
    public class UnitTest1
    {
        [Theory]
        [InlineData("12345", false)]
        [InlineData("Omar", true)]
        [InlineData("O!m?r", false)]
        public void GetTheBarCodeScaned_Contians_ASting(string barCode, bool expectedResult)
        {
            // Arrange
            Customer sut = new Customer();

            // Act 
            var result = sut.IsvalidName(barCode);

            // Assert 
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData("12345", false)]
        [InlineData("Omar", false)]
        [InlineData("O!m?rp1i", true)]
        [InlineData("", false)]
        //�r "Omar2024" ett giltigt l�senord? "Omar#%2024"?
        public void GetPassword_Is_Valid_Tested(string barCode, bool expectedResult)
        {
            Password sutOne= new Password();
            var resultOne= sutOne.IsvalidPassWord(barCode);
            Assert.Equal(expectedResult, resultOne);
        }
        [Theory]
        [InlineData("O!m?rp1i", true)]
        [InlineData("", false)]
        public void GetComment_Valid_Tested(string comment, bool  expectedResult)
        {
            Comment sutTwo= new Comment();
            var result = sutTwo.IsContentAComment(comment);
            Assert.Equal(expectedResult, result);
        }
    }
}
