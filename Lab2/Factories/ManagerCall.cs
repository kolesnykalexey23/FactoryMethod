namespace Lab2.Factories;

using Lab2.Subscriptions;

public class ManagerCall : ISubscriptionFactory
{
    private float _monthlyFee;
    private string _description;
    private string _subsciptionType;
    private string _studentCode;

    public ManagerCall(float monthlyFee, string description, string subscriptionType, string studentCode)
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
