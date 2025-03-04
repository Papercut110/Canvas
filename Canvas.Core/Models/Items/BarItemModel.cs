using System.Collections.Generic;

namespace Canvas.Core.ModelSpace
{
  public class BarItemModel : GroupModel, IGroupModel
  {
    /// <summary>
    /// Render the shape
    /// </summary>
    /// <param name="index"></param>
    /// <param name="name"></param>
    /// <param name="items"></param>
    /// <returns></returns>
    public override void CreateShape(int index, string name, IList<IItemModel> items)
    {
      var currentModel = Y;

      if (currentModel is null)
      {
        return;
      }

      var size = Composer.ItemSize / 2.0;

      var coordinates = new IItemModel[]
      {
        Composer.GetPixels(Engine, index - size, 0.0),
        Composer.GetPixels(Engine, index + size, currentModel.Value)
      };

      Engine.CreateBox(coordinates, this);
    }
  }
}
