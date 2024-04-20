using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Dent.Data
{
    public class ServiceHelper
    {
        public static IConfiguration Configuration { get; set; }
        public static void SetConfig(IServiceProvider serviceProvider)
        {
            Configuration = serviceProvider.GetRequiredService<IConfiguration>();
        }

    }
}
