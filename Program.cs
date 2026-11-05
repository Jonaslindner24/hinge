using System;

class Program
{

    static void Main(string[] args)
    {
        string[] hingestate;
        string[] hingestateparts = Array.Empty<string>();
        bool lidstate = false;

        hingestate = File.ReadAllLines("/proc/acpi/button/lid/LID0/state");

        while (true)
        {
            foreach (string line in hingestate)
            {
                hingestateparts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (hingestateparts[1] == "open")
            {
                lidstate = true;
            }
            else
            {
                lidstate = false;
                break;
            }

            Thread.Sleep(500);
            Console.WriteLine(lidstate);
        }

        
    }

}
