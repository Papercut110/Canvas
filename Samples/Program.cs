using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;

namespace Canvas.Client
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      builder.Services.AddMudServices(o =>
      {
        o.SnackbarConfiguration.NewestOnTop = true;
        o.SnackbarConfiguration.ShowCloseIcon = true;
        o.SnackbarConfiguration.PreventDuplicates = true;
        o.SnackbarConfiguration.SnackbarVariant = Variant.Outlined;
        o.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopRight;
      });

      var app = builder.Build();

      app.UseStaticFiles();
      app.UseRouting();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

      app.MapBlazorHub();
      app.MapFallbackToPage("/Host");
      app.Run();
    }
  }
}
