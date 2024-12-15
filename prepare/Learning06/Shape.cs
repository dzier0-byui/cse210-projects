public abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public string SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {

    }
}