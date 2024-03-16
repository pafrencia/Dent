
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Text.RegularExpressions;


namespace Dent.Identity
{

    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly HttpContext? _httpContext;

        public PermissionAuthorizationHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor?.HttpContext ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        protected async override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
#if DEBUG
            var bearer = Convert.ToBoolean(Environment.GetEnvironmentVariable("Bearer") ?? "False");
            if (!bearer)
            {
                var fakePermissions = Enumerable.Range(1, 10000).Select(x => x.ToString()).ToList();
                if (fakePermissions.Any(p => p == requirement.Permission.Id.ToString()))
                {
                    context.Succeed(requirement);
                }
                return;
            }
#endif
            if (!context.User.Identity.IsAuthenticated) return;
            string token = ((DefaultHttpContext)context.Resource).Request.Headers.FirstOrDefault(x => x.Key.Equals("authorization", StringComparison.InvariantCultureIgnoreCase)).Value;
            if (string.IsNullOrWhiteSpace(token))
            {
                token = _httpContext.Request.Cookies["accessToken"];
            }
            var permissions = Enumerable.Empty<string>();
            if (token != null)
            {
                var regex = new Regex(@"(?:Bearer\s)?(?<token>eyJ.+)");
                var match = regex.Match(token);
                if (match.Success)
                {
                    token = match.Groups["token"]?.Value;
                }
            }

            try
            {

                var jwtHandler = new JwtSecurityTokenHandler();
                var secret = Environment.GetEnvironmentVariable("SECRET_KEY");
                jwtHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validated);

                var jwt = (JwtSecurityToken)validated;
                permissions = jwt.Claims.Where(x => x.Type == CustomClaimTypes.Permission).Select(x => x.Value).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            if (permissions.Any(p => p == requirement.Permission.Id.ToString()))
            {
                context.Succeed(requirement);
            }

            return;
        }
    }
}
