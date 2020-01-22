using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Shop.Northwind.MvcWebUI.TagHelpers
{
    [HtmlTargetElement("page-size-change")]
    public class PageSizeTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(
                "<nav aria-label='...'><ul class='pagination pagination-md'><li class='page-item' ariacurrent='page'><span class='page-link'> Page size <span class='sr-only'>(current)</span></span></li>");
            for (int i = 10; i <= 25; i += 5)
            {
                stringBuilder.AppendFormat(
                    "<li class='page-item {0}'><a class='page-link' href='/Home/Index?page={1}&pageSize={2}&category={3}'>{4}</a></li>", i == PageSize ? "active" : "", CurrentPage, i, CurrentCategory, i);
            }

            stringBuilder.AppendFormat("</ul></ nav >");
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}
