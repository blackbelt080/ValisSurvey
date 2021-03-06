using Newtonsoft.Json;
using System.Web;
using Valis.Core;

namespace ValisManager.Support.WebApi.ViewFilters
{
    public class GetQnaFilterById : WebApiHandler
    {
        protected override void ProcessGetRequestWrapped(Valis.Core.VLAccessToken accessToken, HttpContext context)
        {
            var filterId = TryParseInt32(context, "filterId");

            var manager = VLSurveyManager.GetAnInstance(accessToken);
            var filter = manager.GetViewFilterById(filterId);

            if (filter != null)
            {
                var _filter = new
                {
                    filter.ViewId,
                    filter.FilterId,
                    filter.Survey,
                    filter.Name,
                    filter.ApplyOrder,
                    filter.IsRule,
                    filter.Question,
                    filter.QuestionType,
                    filter.LogicalOperator,
                    filter.IsActive
                };

                var response = JsonConvert.SerializeObject(_filter, Formatting.None);
                context.Response.Write(response);
            }
            else
            {
                throw new VLException(string.Format("There is no Filter with id='{0}'.", filterId));
            }
        }
    }
}