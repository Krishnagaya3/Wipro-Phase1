public sealed class Singleton

{

    private static int cntr = 0;



    private static Singleton Instance = null;



    public static Singleton GetInstance()

    {

        if (Instance == null)

        {

            Instance = new Singleton();

        }

        return Instance;



    }



    private Singleton()
    {

        cntr++;

        Console.WriteLine("Counter Value :" + cntr.ToString());



    }



    public void Display(string message)
    {





        Console.WriteLine(message);





    }





}