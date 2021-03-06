using System.Web;
using Valis.Core;

namespace ValisManager.Support.WebApi.Messages
{
    public class Delete : WebApiHandler
    {
        protected override void ProcessGetRequestWrapped(Valis.Core.VLAccessToken accessToken, HttpContext context)
        {
            try
            {
                var messageId = TryParseInt32(context, "messageId");

                var manager = VLSurveyManager.GetAnInstance(accessToken);
                manager.DeleteMessage(messageId);

                //empty json object
                context.Response.Write("{}");
            }
            catch
            {
                throw;
            }
        }
    }
}