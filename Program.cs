Console.WriteLine("It's me, Mario!\n");

Drawer drawer = new Drawer();

List<ColorSegment> colorSegments = new();

colorSegments.Add(new ColorSegment(0, 3, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(4, 9, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(10, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 2, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(3, 12, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 2, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(3, 5, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(6, 8, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(9, 9, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(10, 10, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(11, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 1, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(2, 2, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(3, 3, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(4, 4, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(5, 8, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(9, 9, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(10, 12, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 1, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(2, 2, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(3, 3, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(4, 5, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(6, 9, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(10, 10, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(11, 13, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(14, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 1, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(2, 3, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(4, 8, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(9, 12, ConsoleColor.Black));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 3, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(4, 11, ConsoleColor.Yellow));
colorSegments.Add(new ColorSegment(12, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 2, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(3, 4, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(5, 5, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(6, 7, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(8, 8, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(9, 10, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(11, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 1, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(2, 4, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(5, 5, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(6, 7, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(8, 8, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(9, 11, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(12, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 0, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(1, 4, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(5, 8, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(9, 12, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 0, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(1, 2, ConsoleColor.White));
colorSegments.Add(new ColorSegment(3, 3, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(4, 4, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(5, 5, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(6, 7, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(8, 8, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(9, 9, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(10, 10, ConsoleColor.Red));
colorSegments.Add(new ColorSegment(11, 12, ConsoleColor.White));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 0, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(1, 3, ConsoleColor.White));
colorSegments.Add(new ColorSegment(4, 9, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(10, 12, ConsoleColor.White));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 0, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(1, 2, ConsoleColor.White));
colorSegments.Add(new ColorSegment(3, 10, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(11, 12, ConsoleColor.White));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 2, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(3, 5, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(6, 7, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(8, 10, ConsoleColor.Blue));
colorSegments.Add(new ColorSegment(11, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 1, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(2, 4, ConsoleColor.DarkRed));
colorSegments.Add(new ColorSegment(5, 8, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(9, 11, ConsoleColor.DarkRed));
colorSegments.Add(new ColorSegment(12, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);

colorSegments.Add(new ColorSegment(0, 0, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(1, 4, ConsoleColor.DarkRed));
colorSegments.Add(new ColorSegment(5, 8, ConsoleColor.DarkYellow));
colorSegments.Add(new ColorSegment(9, 12, ConsoleColor.DarkRed));
colorSegments.Add(new ColorSegment(13, 15, ConsoleColor.DarkYellow));
drawer.Draw(colorSegments);


Console.CursorVisible = false;
Console.ReadKey(true);

PlayMarioTheme();

static void PlayMarioTheme()
{
    int tempo = 140; // Ajuste para mudar a velocidade da música
    Console.Beep(659, tempo); // Mi
    Console.Beep(659, tempo); // Mi
    Thread.Sleep(tempo);
    Console.Beep(659, tempo);
    Thread.Sleep(tempo);
    Console.Beep(523, tempo);
    Console.Beep(659, tempo);
    Thread.Sleep(tempo);
    Console.Beep(784, tempo);
    Thread.Sleep(tempo);
    Console.Beep(392, tempo);
    Thread.Sleep(tempo);
    Console.Beep(523, tempo);
    Thread.Sleep(tempo);
    Console.Beep(392, tempo);
    Thread.Sleep(tempo);
    Console.Beep(330, tempo);
    Thread.Sleep(tempo);
    Console.Beep(440, tempo);
    Thread.Sleep(tempo);
    Console.Beep(494, tempo);
    Thread.Sleep(tempo);
    Console.Beep(466, tempo);
    Thread.Sleep(tempo);
    Console.Beep(440, tempo);
    Thread.Sleep(tempo);
    Console.Beep(392, tempo);
    Thread.Sleep(tempo);
    Console.Beep(659, tempo);
    Thread.Sleep(tempo);
    Console.Beep(784, tempo);
    Thread.Sleep(tempo);
    Console.Beep(880, tempo);
    Thread.Sleep(tempo);
    Console.Beep(698, tempo);
    Console.Beep(784, tempo);
    Thread.Sleep(tempo);
    Console.Beep(659, tempo);
    Thread.Sleep(tempo);
    Console.Beep(523, tempo);
    Console.Beep(587, tempo);
    Console.Beep(494, tempo);
    Thread.Sleep(tempo);
    Console.Beep(523, tempo);
    Thread.Sleep(tempo);
    Console.Beep(392, tempo);
    Thread.Sleep(tempo);
    Console.Beep(330, tempo);
    Thread.Sleep(tempo);
    Console.Beep(440, tempo);
    Thread.Sleep(tempo);
    Console.Beep(494, tempo);
    Thread.Sleep(tempo);
    Console.Beep(466, tempo);
    Thread.Sleep(tempo);
    Console.Beep(440, tempo);
    Thread.Sleep(tempo);
    Console.Beep(392, tempo);
    Thread.Sleep(tempo);
    Console.Beep(659, tempo);
    Thread.Sleep(tempo);
    Console.Beep(784, tempo);
    Thread.Sleep(tempo);
    Console.Beep(880, tempo);
    Thread.Sleep(tempo);
    Console.Beep(698, tempo);
    Console.Beep(784, tempo);
    Thread.Sleep(tempo);
    Console.Beep(659, tempo);
    Thread.Sleep(tempo);
    Console.Beep(523, tempo);
    Console.Beep(587, tempo);
    Console.Beep(494, tempo);
    Thread.Sleep(tempo);
}