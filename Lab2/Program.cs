
using Lab2.Factories;
using Lab2.Subscriptions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose platform to get subscription:");
        Console.WriteLine("W - Web-site");
        Console.WriteLine("M - Mobile app");
        Console.WriteLine("Man - Manager call");

        string platform = Console.ReadLine();
        
        Console.WriteLine("Choose subscription:");
        Console.WriteLine("d - Domestic subscription");
        Console.WriteLine("e - Education subscription");
        Console.WriteLine("p - Professional subscription");
        string subscription = Console.ReadLine();

        ISubscriptionFactory factory = GetFactory(platform, subscription);
        ISubscription abonement = factory.GetSubscription();
        Console.WriteLine($"Name: {abonement.Name} \nChanels: {string.Join(", ", abonement.Channels)}\nPeriod: {abonement.MinSubscriptionPeriod}\nPrice: {abonement.GetPrice()}");
        Console.ReadLine();
    }

    private static ISubscriptionFactory GetFactory(string platform, string subscription) =>
        platform.ToLower() switch
        {
            "w" => new WebSite(100, "login via the website", subscription,"student"),
            "m" => new MobileApp(200, "login via mobile app", subscription),
            "man" => new MobileApp(300, "login via operator", subscription),
            _ => null
        };

}

