using System;

namespace testeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num=new int[]{1,5,10,55,65,80,99,106};
            for(int i=0;i<num.Length;i++){
                Console.WriteLine(num[i]);
            }
        }
    }
}
