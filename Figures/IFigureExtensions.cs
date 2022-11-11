namespace Figures;

public static class IFigureExtensions
{
    public static double GetArea<TFigure>(this TFigure figure)
        where TFigure : IFigure
    {
        return figure.GetArea();
    }
}