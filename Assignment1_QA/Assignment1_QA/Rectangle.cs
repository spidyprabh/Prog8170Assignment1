﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_QA
{
  public class Rectangle
  {
    private int length;
    private int width;

    public int Length { get => length; set => length = value; }
    public int Width { get => width; set => width = value; }

    public Rectangle()
    {
      length = 1;
      width = 1;
    }

    public Rectangle(int length, int width)
    {
      this.length = length;
      this.width = width;
    }
    public int GetLength()
    {
      return length;
    }

    public int SetLength(int length)
    {
      this.length = length;
      return length;
    }

    public int GetWidth()
    {
      return width;
    }
    public int SetWidth(int width)
    {
      this.width = width;
      return width;
    }
    public int GetPerimeter()
    {
      return 2 * (length + width);


    }
    public int GetArea()
    {
      return length * width;
    }

  }
}
