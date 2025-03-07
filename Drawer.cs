public class Drawer
{
    List<ISegment> segments = new List<ISegment>();

    public void AddSegment(ISegment segment)
    {
        segments.Add(segment);
    }

    public void Draw()
    {
        foreach (var segment in segments)
        {
            segment.DoConsole();            
        }
    }
}