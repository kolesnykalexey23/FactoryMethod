namespace Lab2.Subscriptions;

public class PremiumSubscription : ISubscription
{
    private string _name;
    private float _monthlyFee;
    private float _minSubscriptionPeriod;
    private string[] _channels;

    public PremiumSubscription(float fee)
    {
        _name = "Premium Subscription";
        _channels = ["premium channel 1", "premium channel 2"];
        _minSubscriptionPeriod = 30;
        _monthlyFee = fee;
    }

    public string Name => _name;
    public string[] Channels => _channels;
    public float MinSubscriptionPeriod => _minSubscriptionPeriod;
    public float GetPrice() => _monthlyFee;
}