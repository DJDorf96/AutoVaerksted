

// Booking af mødelokaler.

// Hvad skal det indeholde?

/*
BookingSystem system1 = new BookingSystem();

Mødelokale lokaleA = new Mødelokale("Lokale A", 10);
system1.OpretLokale(lokaleA); // Security level is above, due to private function inside the Method.

system1.FindLokale("Lokale A");


class BookingSystem
{
    private List<Mødelokale> mødelokaler = new List<Mødelokale>(); // Opretter en tom liste som System har rådighed over.
    private void OpretLokale(Mødelokale lokale)
    {
        mødelokaler.Add(lokale);
    }
    public void VisLokaler()
    {
        foreach(Mødelokale lokale in mødelokaler)
        {
            Console.WriteLine($"Lokalenavn: {lokale.LokaleNavn}");
            Console.WriteLine($"Siddepladser: {lokale.Siddepladser}");
            Console.WriteLine($"Er lokalet booket?: {lokale.ErBooket}");
        }
    }
    public void FindLokale(string lokaleNavn) // Skal eventuelt returnerer et "string". Se opgaven med markering.
    {
        bool svar = false;
        string optaget = "Ledig";
        foreach(Mødelokale lokale in mødelokaler)
        {
            if (lokale.LokaleNavn == lokaleNavn)
            {
                svar = true;
                if (lokale.ErBooket == false)
                {
                    Console.WriteLine($"Søgeord: {lokaleNavn}.");
                    Console.WriteLine($"{lokaleNavn} - {lokale.Siddepladser} pladser - Status: {optaget}.");

                }
                else
                {
                    Console.WriteLine($"{lokaleNavn} - {lokale.Siddepladser} pladser - Status: Optaget.");
                }
            }
        }
        if (svar = false)
        {
            Console.WriteLine($"Lokalet {lokaleNavn} eksisterer desværre ikke i systemet.");
        }
    }
}


class Mødelokale // Vores lokale-class.
{
    public string LokaleNavn; // Lokalets navn.
    public int Siddepladser; // Antal siddepladser i lokalet.
    public bool ErBooket = false;
    public Mødelokale(string lokalenavn, int siddepladser)
    {
        LokaleNavn = lokalenavn;
        Siddepladser = siddepladser;
    }
}

*/



class Værksted
{
    private List<Bil> biler = new List<Bil>();
    public void OpretSag(string nummerplade)
    {
        Bil bil = new Bil(nummerplade);
        biler.Add(bil);
    }
}

class Bil
{
    private string Nummerplade;
    private int Regning = 0;
    private string Reparationslog = "";
    private bool ErKlarTilAfhentning = false;
    public Bil(string nummerplade)
    {
        Nummerplade = nummerplade;
    }
}