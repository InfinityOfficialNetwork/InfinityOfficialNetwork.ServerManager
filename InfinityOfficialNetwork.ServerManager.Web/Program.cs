using InfinityOfficialNetwork.ServerManager.Web.Components;

namespace InfinityOfficialNetwork.ServerManager.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ApplicationBuilder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            ApplicationBuilder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var Application = ApplicationBuilder.Build();

            // Configure the HTTP request pipeline.
            if (!Application.Environment.IsDevelopment())
            {
                Application.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                Application.UseHsts();
            }

            Application.UseHttpsRedirection();

            Application.UseStaticFiles();
            Application.UseAntiforgery();

            Application.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();
            Application.Run();
            
        }
    }
}
