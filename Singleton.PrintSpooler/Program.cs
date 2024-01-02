using Singleton.PrintSpooler;

await Task.Run(() => PrintWithThreadSafeSpooler("document 1"));
await Task.Run(() => PrintWithThreadSafeSpooler("document 2"));

static void PrintWithThreadSafeSpooler(string document)
{
    PrintSpoolerThreadSafe spooler = new PrintSpoolerThreadSafe();
    spooler.Print(document);
}
