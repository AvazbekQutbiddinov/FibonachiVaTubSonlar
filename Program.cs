internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dasturga xush kelibsiz");
        string input = "";
        int num = 0;
        do
        {
            Console.WriteLine("Kerakli bo`limni tanlang");
            Console.WriteLine("1: dastlabki n ta fibonachi sonlarni topish");
            Console.WriteLine("2: sonni tublikka tekshirish");
            Console.WriteLine("3: dasturni tugatish");
            input = Console.ReadLine();
            switch(input)
            {
                case "1" :
                Console.Write("n = ");
                num = Convert.ToInt32(Console.ReadLine());
                Fibonachi(num);
                Console.Write("\n\n");
                break;

                case "2" :
                Console.Write("n = ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{num} soni tub son");
                if(Tub(num)) Console.WriteLine("emas");
                break;
            }Console.Write("\n");

        }while(input != "3");
    }
    static void Fibonachi(int cnt)
    {
        if (cnt == 1) Console.WriteLine(0);
            else
                { 
                    Console.Write("0, 1");
                    int[] nums = new int[cnt];
                    nums[0] = 0;
                    nums[1] = 1;
                    for(int index = 2; index < cnt; index ++)
                    {
                        nums[index] = nums[index - 1] + nums[index - 2];
                        Console.Write($", {nums[index]}");
                    }
                }
        Console.WriteLine();
    }
    static bool Tub(int num)
    {
        for (int i = 2; i * i <= num; i ++)
            if (num % i == 0) return true;
        return false;
    }
}