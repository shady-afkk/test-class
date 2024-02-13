using NUnit.Framework.Legacy;
using NUnit.Framework;
using static triangle_test.Class1;

namespace test_class
{
    public class Class1
    {
        //Mohammed Shadaab Uddin

        [TestFixture]
        public class class1

        {
            [Test]
            public void ValidTriangle_Input60and60_outputvalidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }    
    }
    
}
