public class ColorSegment : ISegment
{
    public int startPixel;
    public int endPixel;
    public ConsoleColor color;

    public ColorSegment(int startPixel, int endPixel, ConsoleColor color)
    {
        this.startPixel = startPixel;
        this.endPixel = endPixel;
        this.color = color;
    }

    public void DoConsole()
    {
        for(int i = startPixel; i <= endPixel; i++)
        {
            Console.BackgroundColor = color;
            Console.Write(" ");
            Thread.Sleep(10);
            Console.ResetColor();
        }
    }
}