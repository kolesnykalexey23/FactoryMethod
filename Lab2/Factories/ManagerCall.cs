namespace Lab2.Factories;

using Lab2.Subscriptions;

public class ManagerCall : ISubscriptionFactory
{
    //private float _monthlyFee;
    private string _description;
    private string _subsciptionType;
    private string _studentCode;

    public ManagerCall( string description, string subscriptionType, string studentCode)
    {
        _description = description;
        _subsciptionType = subscriptionType;
        _studentCode = studentCode;
    }
    public string Description => _description;


    public ISubscription GetSubscription()
    {
        ISubscription subscription = null;

        switch (_subsciptionType)
        {
            case "d":
                subscription = new DomesticSubscription();
                break;
            case "e":
                subscription = new EducationalSubscription(_studentCode);
                break;
            case "p":
                subscription = new PremiumSubscription();
                break;
            default:

                break;
        }

        return subscription;
    }
}
