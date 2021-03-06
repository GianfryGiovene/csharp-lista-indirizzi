/*
In questo esercizio dovrete leggere un file CSV (che vi allego), 
non tanto differente da quanto visto nel live-coding in classe, 

e salvare tutti gli indirizzi contenuti all’interno 
di una lista di oggetti istanziati a partire dalla classe Indirizzo.

Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” 
che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire 
come meglio crediate queste casistiche.
*/
using csharp_lista_indirizzi;

StreamReader fileRead = File.OpenText(@"D:\Documenti\Coding\Corso_Experis\Esercizi\csharp-lista-indirizzi\addresses.csv");

Console.WriteLine(fileRead.ReadLine());


List<Address> addresses = new List<Address>();
List<Address> invalidAddresses = new List<Address>();

while (!fileRead.EndOfStream)
{

    string row = fileRead.ReadLine();
    string[] words = row.Split(",");

    Console.WriteLine();
    Address address;
    try { 
        address = new Address(words[0], words[1], words[2], words[3], words[4], words[5]);
        addresses.Add(address);
    }
    catch (IndexOutOfRangeException)
    {
        address = new Address();
        invalidAddresses.Add(address);
        Console.WriteLine("Lo salvo altrove");
    }
    
    
}
fileRead.Close();

try
{
    string path = @"D:\Documenti\Coding\Corso_Experis\Esercizi\csharp-lista-indirizzi\newAddresses.csv";
    if (!File.Exists(path))
    {
        StreamWriter newFile = File.CreateText(@"D:\Documenti\Coding\Corso_Experis\Esercizi\csharp-lista-indirizzi\newAddresses.csv");
        foreach (Address address in addresses)
        {
            
            newFile.WriteLine(address.ShowAddress());

        }
        newFile.Close();
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

