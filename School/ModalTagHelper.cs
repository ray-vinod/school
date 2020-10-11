using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class BSModalTagHelper : TagHelper
    {
        string[] htmlAttributes = new string[] { "modal", "dialog", "modal-dialog", "document", "modal-content", "modal-header","modal-title","button","Close","true","modal-body", "modal-footer", };
        int tabIndex = -1;

        //public string ClassName { get; set; }
        public string IdName { get; set; }
        public string  ModalTitle { get; set; }
        public string ModalHeading { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "BSModal";
            output.TagMode = TagMode.StartTagAndEndTag;
            StringBuilder html = new StringBuilder(
                "<div class= '" + htmlAttributes[0] + "' tabindex='" + tabIndex + "' role = '"+htmlAttributes[1]+"'>" +
                "<div class='" + htmlAttributes[2] + "' role='" + htmlAttributes[3] + ">" +
                "<div class='" + htmlAttributes[4] + "'>" +
                "<div class='" + htmlAttributes[5] + "' > " +
                "<h5 class='" + htmlAttributes[6] + "'>ModalTitle</h5>" +
                "<button type='" + htmlAttributes[7] + "' data-dismiss='" + htmlAttributes[0] + "' aria-label='" + htmlAttributes[8] + "'>< span aria - hidden = '" + htmlAttributes[9] + "' > &times;</ span ></ button > " +
                "</div>" +
                "<div class='" + htmlAttributes[10] + "'>< p > Modal body text goes here.</ p ></ div > " +
                " <div class='" + htmlAttributes[11] + "></div>" +
                "</div>" +
                "</div>" +
                "</div>" +
                ""
                );

            output.PreContent.SetHtmlContent(html.ToString());
        }
    }
}
