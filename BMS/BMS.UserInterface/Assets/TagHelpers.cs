using BMS.Application.Assets;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Application.Assets
{
    [HtmlTargetElement(Attributes = "af-for")]
    public class InputTagHelper : TagHelper
    {
        [HtmlAttributeName("type")]
        public string InputType { get; set; }

        public ModelExpression AfFor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            /*
                <input type="text" maxlength="25" name="thresholdconfig" class="form-control" id="thresholdconfig2">
                <small id="emailHelp" class="form-text text-error">This is require.</small>
             */
            var metadata = this.AfFor.Metadata;
            var identifier = metadata.ContainerType.GetProperty(metadata.PropertyName)?.GetCustomAttribute<Identifier>();
            var require = metadata.ContainerType.GetProperty(metadata.PropertyName)?.GetCustomAttribute<RequiredAttribute>();
            var css = metadata.ContainerType.GetProperty(metadata.PropertyName)?.GetCustomAttribute<FormCSS>();
            var disabled = metadata.ContainerType.GetProperty(metadata.PropertyName)?.GetCustomAttribute<Disabled>();
            var placeholder = metadata.ContainerType.GetProperty(metadata.PropertyName)?.GetCustomAttribute<PlaceHolder>();

            /* Identifer */
            output.Attributes.Add("id", identifier.string_Identier);
            output.Attributes.Add("name", identifier.string_Identier);
            output.Attributes.Add("type", this.InputType);

            /* require */
            if (require != null)
                output.Attributes.Add("required", "true");

            /* css */
            if (css != null)
                output.Attributes.Add("class", css.string_FormCSS);

            /* disabled */
            if (disabled != null)
                output.Attributes.Add("disabled", "true");

            /* placeholder */
            if (placeholder != null)
                output.Attributes.Add("placeholder", placeholder.string_Placeholder);

            switch (this.InputType)
            {
                case "text":
                case "password":
                case "email":
                case "hidden":
                    if (this.AfFor.Model != null)
                        output.Attributes.Add("value", this.AfFor.Model);
                    break;
                case "date":
                    if (this.AfFor.Model != null)
                        output.Attributes.Add("value", Convert.ToDateTime(this.AfFor.Model).ToString("yyyy-MM-dd"));
                    break;

                case "datetime":
                    if (this.AfFor.Model != null)
                        output.Attributes.Add("value", Convert.ToDateTime(this.AfFor.Model).ToString());
                    break;

                case "checkbox":
                    if (this.AfFor.Model != null)
                        if ((bool)this.AfFor.Model == true)
                            output.Attributes.Add("checked", this.AfFor.Model.ToString().ToLower());

                    output.PostElement.AppendHtml($"""
                                                <input type="hidden"
                                                       class="form-control"
                                                       id="{identifier.string_Identier}_Hidden"
                                                       name="{identifier.string_Identier}_Hidden" />
                                                """);
                    break;

                case "radio":
                    if ((bool)this.AfFor.Model == true)
                        output.Attributes.Add("checked", this.AfFor.Model.ToString().ToLower());
                    break;
                default:
                    break;
            }

            output.PostElement.AppendHtml($"""
                                                <small id="{identifier.string_Identier}_error" name="{identifier.string_Identier}_error" class="form-text text-error">This is require.</small>
                                                """);

        }

    }

    [HtmlTargetElement("select", Attributes = "af-for,af-datasource")]
    public class SelectTaghelper : TagHelper
    {
        public ModelExpression AfFor { get; set; }
        public List<DataModel> AfDatasource { get; set; } = new();
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var metadata = this.AfFor.Metadata;
            var html = $"""
                    <option value="0">Please Select</option>
                """;

            foreach (var item in AfDatasource)
            {
                // Check if Item is selected
                var selected = "";
                if (this.AfFor.Model != null)
                    if (item.FieldValue == (int)this.AfFor.Model)
                        selected = "selected";

                html += $"""
                    <option value="{item.FieldValue}" {selected}>{item.FieldText}</option>
                """;
            }
            output.Content.AppendHtml(html);
        }
    }
}