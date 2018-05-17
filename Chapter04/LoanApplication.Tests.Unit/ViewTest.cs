using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Xunit;

namespace LoanApplication.Tests.Unit
{
    public class ViewTest
    {

        [Fact]
        public void TestResultView()
        {
            var httpContext = new DefaultHttpContext();
            var modelState = new ModelStateDictionary();
            var actionContext = new ActionContext(httpContext, new RouteData(),
            new PageActionDescriptor(), modelState);
            var modelMetadataProvider = new EmptyModelMetadataProvider();
            var viewData = new ViewDataDictionary(modelMetadataProvider,
            modelState);
            var pageContext = new PageContext(actionContext);
            pageContext.ViewData = viewData;
            var pageModel = new ResultModel();
            pageModel.PageContext = pageContext;
            pageModel.Url = new UrlHelper(actionContext);
            var result = pageModel.RedirectToPage();
            Assert.IsType<RedirectToPageResult>(result);
        }
    }
    public class ResultModel : PageModel
    {
        public string Message { get; set; }
    }

}
