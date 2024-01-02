using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.PrintSpooler;

public class PrintSpooler
{
    private static PrintSpooler instance;

    private PrintSpooler()
    {
        Console.WriteLine("PrintSpooler without thread safe is created.");
    }

    public static PrintSpooler GetInstance()
    {
        if (instance is null)
        {
            instance = new PrintSpooler();
        }

        return instance;
    }

    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }
}
