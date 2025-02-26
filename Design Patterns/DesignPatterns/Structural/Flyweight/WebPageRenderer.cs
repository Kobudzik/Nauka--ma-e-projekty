using System;

namespace Flyweight;

class WebPageRenderer
{
    public void Render()
    {
        //instatnionate new Factory
        var factory = new ImageFactory();

        //display image
        var image = factory.GetFlyweight("image.png");
        image.Display(0, 0, 420, 230);

        //display another
        image = factory.GetFlyweight("image.png");
        image.Display(4, 15, 333, 564);

        //display another
        image = factory.GetFlyweight("image.png");
        image.Display(33, 43, 253, 637);

        Console.ReadKey();
    }
}
