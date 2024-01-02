using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.PrintSpooler;

public class PrintSpoolerThreadSafe
{
    private static volatile PrintSpoolerThreadSafe instance;
    private static readonly object syncRoot = new object();

    public PrintSpoolerThreadSafe()
    {
        
    }

    public static PrintSpoolerThreadSafe GetInstance()
    {
        if (instance is null)
        {
            lock (syncRoot)
            {
                if(instance is null)
                {
                    instance = new PrintSpoolerThreadSafe();
                }
            }
        }

        return instance;
    }

    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }
}
