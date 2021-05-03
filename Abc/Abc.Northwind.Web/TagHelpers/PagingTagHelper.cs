using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Northwind.Web.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper:TagHelper
    {
        [HtmlAttributeName("page-size")] //bu parametreleri razorun içerisine htmlattname sayesinde gönderebiliyorum.
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output) //Tag helperı burda oluşturduk.
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='pagination'>");

            for (int i = 1; i <= PageCount ; i++) //gelecek ürünler için sayfa sayısı kadar bizim link oluşturmamız lazım o da page counttan geliyor zaten.
            {
                stringBuilder.AppendFormat("<li class='{0}'>", i == CurrentPage ? "active" : ""); //her bir link için bir li
                stringBuilder.AppendFormat("<a href='/product/index?page={0}&category={1}'>{2}</a>", i, CurrentCategory, i); //buna tıkladığımda bir url oluşturmam gerekiyor.yani bir route oluşturmam gerekiyor.1.i benim page değerim,2.si benim kategorim,3.benim yazılacak değerim o da i.
                stringBuilder.Append("</li>");
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}
