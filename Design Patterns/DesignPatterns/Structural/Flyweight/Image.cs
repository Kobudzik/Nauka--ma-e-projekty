using System;

namespace Flyweight;

class Image(string filename) : BaseImage
{
    protected string _filename = filename;

    public override void Display(int x, int y, int width, int height)
    {
        Console.WriteLine(
            "img src={0}  style =left:{1}px; top:{2}px; width: {3}px; height {4}px;",
            _filename, x, y, width, height
        );
    }
}
