namespace Lab2.Factories;
using Lab2.Subscriptions;

public class MobileApp: ISubscriptionFactory
{
    private float _monthlyFee;
    private string _description;
    private string _subsciptionType;
    //private string _studentCode;

    public MobileApp(float monthlyFee, string description, string subscriptionType)
    {
        _monthlyFee = monthlyFee;
        _description = description;
        _subsciptionType = subscriptionType;
       // _studentCode = studentCode;
    }

    public ISubscription GetSubscription()
    {
        ISubscription subscription = null;

        switch (_subsciptionType)
        {
            case "d":
                subscription = new DomesticSubscription(_monthlyFee);
                break;
            case "e":
                subscription = new EducationalSubscription(_monthlyFee);
                break;
            case "p":
                subscription = new PremiumSubscription(_monthlyFee);
                break;
            default:
                
                break;
        }

        return subscription;
    }
}
