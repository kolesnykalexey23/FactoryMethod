using System.Data;
using System.Transactions;

namespace Lab2.Subscriptions;

public class DomesticSubscription : ISubscription
{
    private string _name;
    private float _monthlyFee;
    private float _minSubscriptionPeriod;
    private string[] _channels;

    public DomesticSubscription(float fee)
    {
        _name = "Domestic Subscription";
        _channels = ["domestic channel 1", "domestic channel 2"];
        _minSubscriptionPeriod = 20;
        _monthlyFee = fee;
    }

    public string Name => _name;
    public string [] Channels => _channels;
    public float MinSubscriptionPeriod => _minSubscriptionPeriod;
    public float GetPrice() => _monthlyFee;
}