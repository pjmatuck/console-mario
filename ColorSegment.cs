public class ColorSegment
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
}