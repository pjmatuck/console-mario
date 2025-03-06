public class Drawer
{
    public void Draw(List<ColorSegment> segments)
    {
        foreach (var segment in segments)
        {
            Console.BackgroundColor = segment.color;
            for(int i = segment.startPixel; i <= segment.endPixel; i++)
            {
                Console.Write(" ");
                Thread.Sleep(10);
            }
        }
        Console.Write('\n');
        segments.Clear();
    }
}