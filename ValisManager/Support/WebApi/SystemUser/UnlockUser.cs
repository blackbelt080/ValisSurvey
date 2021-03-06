using System.Web;
using Valis.Core;

namespace ValisManager.Support.WebApi.SystemUser
{
    public class UnlockUser : WebApiHandler
    {
        protected override void ProcessGetRequestWrapped(Valis.Core.VLAccessToken accessToken, HttpContext context)
        {
            //we will need an instance of a LrSystem:
            var systemManager = VLSystemManager.GetAnInstance(accessToken);

            //gather required values:
            var userId = TryParseInt32(context, "UserId", true);

            systemManager.UnlockPrincipal(PrincipalType.SystemUser, userId);

            //empty json object
            context.Response.Write("{}");
        }
    }
}