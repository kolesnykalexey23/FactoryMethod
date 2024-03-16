using Lab2.Subscriptions;

namespace Lab2.Factories;

public class WebSite : ISubscriptionFactory
{
    private float _monthlyFee;
    private string _description;
    private string _subsciptionType;
    private string _studentCode;

    public WebSite(float monthlyFee, string description, string subscriptionType, string studentCode = null)
    {
        _monthlyFee = monthlyFee;
        _description = description;
        _subsciptionType = subscriptionType;
        _studentCode = studentCode;
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
                subscription = new EducationalSubscription(_monthlyFee, _studentCode);
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