namespace BouncingBall;
internal class BouncingBall()
{
    public int width = 40;
    public int height = 20;
    void DrawBorder()
    {
        for (int i = 0; i < width; i++)
        {
            Console.Write("#");
        }
        for (int i = 0; i < height; i++)
        {
            Console.Write("\n#");
            for(int j = 0; j < width -1; j++)
            {
                Console.Write(" ");
            }
            Console.Write("#\n");
        }
        for (int i = 0; i < width; i++)
        {
            Console.Write("#");
        }
    }
    static void Main()
    {
        BouncingBall bb = new BouncingBall();
        bb.DrawBorder();
    }
}