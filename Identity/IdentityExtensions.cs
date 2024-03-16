using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using System.Text.RegularExpressions;
using static Dent.Identity.Permissions;

namespace Dent.Identity
{
    public static class IdentityExtensions
    {
        public static IServiceCollection AddOurIdentity(this IServiceCollection services)
        {
            services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
            services.ConfigurePermissions();
            services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme (\"bearer token\")",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            var _secret_key = Environment.GetEnvironmentVariable("SECRET_KEY");
            if (string.IsNullOrWhiteSpace(_secret_key))
            {
                throw new ArgumentNullException("Falta la Secret_Key en Identity. Probablemente falte el .env o no se cargó correctamente.");
            }
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secret_key)),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        RequireExpirationTime = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            return services;
        }

        private static void ConfigurePermissions(this IServiceCollection services)
        {
            //se crea una colección de todos los permisos
            var nestedTypes = typeof(Permissions)
                .GetNestedTypes();

            var props = nestedTypes?.SelectMany(x => x.GetProperties());

            var permissions = props.Select(f => f?.GetValue(f));

            //creo Policies peronalizadas para usarlas en el atribute Authorize
            services.AddAuthorization(options =>
            {
                foreach (PermissionTuple permission in permissions)
                {
                    if (permission == null) continue;
                    var policyName = Regex.Replace(permission.Name, @"^Permissions\.", string.Empty);
                    options.AddPolicy(policyName, builder =>
                    {
                        builder.AddRequirements(new PermissionRequirement(permission));
                    });

                }


            });
        }
    }
}