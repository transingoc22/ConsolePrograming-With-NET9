// See https://aka.ms/new-console-template for more information
class Cube : Shape, IShape
{
    public Cube()
    {

    }

    public Cube(int width, int length, int height)
    {
        Width = width;
        Length = length;
        Height = height;
    }

    public Cube(int width)
    {

    }
    public double Width { get; set; }

    public double getArea()
    {
        return Length * Width;
    }

    public double getVolume()
    {
        return Length * Length;
    }
}
