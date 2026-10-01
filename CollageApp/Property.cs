namespace CollageApp;

public abstract class Property(float worth)
{
    protected float _worth = worth;

    public virtual float CalculateTax()
    {
        return 0f;
    }
}