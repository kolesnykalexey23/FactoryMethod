namespace Lab2.Subscriptions;

public class EducationalSubscription : ISubscription
{
    private string _name;
    private float _monthlyFee;
    private float _minSubscriptionPeriod;
    private string[] _channels;
    
    private string _studentCode;
    private string _code = "student";
    private int _discount = 20;

    public EducationalSubscription(float fee, string studentCode = null)
    {
        _name = "Educational Subscription";
        _channels = ["Educational channel 1", "Educational channel 2"];
        _minSubscriptionPeriod = 365;
        _monthlyFee = fee;
        _studentCode = studentCode;
    }

    public string Name => _name;
    public string [] Channels => _channels;
    public float MinSubscriptionPeriod => _minSubscriptionPeriod;
    public float GetPrice() => Discount();

    private float Discount()
    {
        if (_studentCode == _code)
        {
            float num = (_monthlyFee * _discount) / 100;
            return _monthlyFee - num;
        }
        else
        {
            return _monthlyFee;
        }
    }
}
