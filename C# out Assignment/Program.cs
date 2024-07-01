using System.Security.Cryptography;

class out1
{
    public static void M1(out string s2)
    {
        Thread.Sleep(10000);
        s2 = "rithvik";
        Console.WriteLine("after intilization  " + s2);
    }
}

class program : out1
{
    public static string s1 = "sf";

    public Thread t1 = new Thread(() =>
            { M1(out s1); })
        { Name = "out thread" };

    public void M()
    {
        t1.Start();
        Console.WriteLine(s1);
    }

    public static void Main(string[] args)
    {
        program obj = new program();
        obj.M();
    }
}