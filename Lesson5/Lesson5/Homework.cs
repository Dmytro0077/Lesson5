namespace Lesson5
{
    internal class Homework
    {
        static void Main()
        {
            char[] letters = { 'D', 'm', 'y', 't', 'r', 'o', ' ', 'r', 'u', 'n' };
            string name = "";
            int[] a = new int[10];
            for (int i = 0; i < letters.Length; i++)
            {
                name += letters[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }
            Console.ReadKey();
        }
        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Run, " + name + "! Count to " + msg);
        }
    }
}
