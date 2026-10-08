namespace BouncingBall;

internal class BouncingBall
{
    int canvasW = 60;
    int canvasH = 20;

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        BouncingBall bB = new BouncingBall();

        int startingCordX = 15;
        int startingCordY = 0;

        bB.DrawBorder();
        bB.MoveBall(startingCordX, startingCordY);

        Console.ReadLine();
    }

    void DrawBorder()
    {

        for (int i = 0; i < canvasW; i++)
        {
            Console.Write("#");
        }
        Console.Write("\n");
        for (int i = 0; i < canvasH; i++)
        {
            Console.Write("#");
            for (int j = 0; j < canvasW - 2; j++)
            {
                Console.Write(" ");
            }
            Console.Write("#\n");
        }
        for (int i = 0; i < canvasW; i++)
        {
            Console.Write("#");
        }

    }

    void MoveBall(int startingCordX, int startingCordY)
    {
        Console.SetCursorPosition(startingCordX, startingCordY);
        for (int i = 1; i < 10; i++)
        {
            Thread.Sleep(100);
            Console.SetCursorPosition(i-1, 15);
            Console.WriteLine(" ");
            Console.SetCursorPosition(i, 15);
            Console.Write("º");
        }
    }
}