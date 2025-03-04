namespace Canvas.Views.Web
{
  public class ViewMessage
  {
    public virtual double X { get; set; }
    public virtual double Y { get; set; }
    public virtual string ValueX { get; set; }
    public virtual string ValueY { get; set; }
    public virtual CanvasWebView View { get; set; }
  }
}
