﻿// See https://aka.ms/new-console-template for more information
class Rectange : Shape, IShape
{
    public double Width { get; set; }
    public double getArea()
    {
        return Length * Width;
    }
}