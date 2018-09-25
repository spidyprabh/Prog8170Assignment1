using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_QA_Test;

namespace Assignment1_QA_Test
{
    public class Assignment1_QA_Test
    {
    [Test]
    public void Getlength_input5_expectLengthEquals5()
    {
      //Arrange
      int l = 5;
      int w = 3;
      Rectangle testRectangle = new Rectangle(l, w);

      //Act
      int length = testRectangle.GetLength();

      //Assert
      Assert.AreEqual(length, l);

    }
    [Test]
    public void ChangeRectangleLength_input2_expectLengthEqual2()
    {
      // Arrange 
      int l = 5;
      int w = 3;
      Rectangle testRectangle = new Rectangle(l, w);

      //Act
      int newlength = testRectangle.SetLength(l);

      //Assert
      Assert.AreEqual(newlength, l);
    }
    [Test]
    public void GetRectangleWidth_input3_expectedWidthEqual3()
    {
      //Arrange
      int l = 2;
      int w = 3;
      Rectangle testrectangle = new Rectangle(l, w);

      //Act
      int width = testrectangle.GetWidth();

      //Assert
      Assert.AreEqual(width, w);

    }
    [Test]
    public void ChangeRectangleWidth_input2_expectwidth_equal2()
    {
      // Arrange 
      int l;
      int width = 2;
      Rectangle testRectangle = new Rectangle();

      //Act
      int newWidth = testRectangle.SetWidth(width);

      //Assert
      Assert.AreEqual(newWidth, width);
    }

    [Test]
    public void GetRectanglePerimeter_input_expect()
    {
      // Arrange 
      int length = 2;
      int width = 2;
      int value = 2 * (length + width);
      Rectangle testRectangle = new Rectangle(length, width);

      //Act
      int NewValue = testRectangle.GetPerimeter();

      //Assert
      Assert.AreEqual(NewValue, value);
    }
    [Test]
    public void GetRectangleArea_input_expect()
    {
      // Arrange 
      int l = 2;
      int w = 2;
      int value = l * w;
      Rectangle testRectangle = new Rectangle(l, w);

      //Act
      int NewValue = testRectangle.GetArea();

      //Assert
      Assert.AreEqual(NewValue, value);
    }

  }
}
