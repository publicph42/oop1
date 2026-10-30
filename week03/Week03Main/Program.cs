namespace Week03.SecondClass;

internal class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 10, 25, 30, 45, 50 };
        int[] sayilar2 = new int[5];
        int[] sayilar3 = new int[5] { 10, 25, 30, 45, 50 };
        int[] sayilar4 = new int[] { 10, 25, 30, 45, 50 };

        int[] indexesToRemove = new int[10];

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] % 2 == 0)
            {
                //sayilar[i].Remove
                // we can't remove a value from the array because it's created in the heap
                // 20byte of space was created, (4byte x 5) and we can't remove an element from that array.
            }
        }

        List<int> list1 = new List<int> { 10, 25, 30, 40, 50 };

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] % 2 == 0)
            {
                list1.RemoveAt(i);
            }
        }
        for (int i = 0; i < list1.Count; i++)
        {
            Console.WriteLine(list1[i]);
        }

        // like the example above we can use a linked list
        // this is so much more performant and faster to find value
        // but it will take more space in the heap
    }
}
