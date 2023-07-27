using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Assets
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckDuplicate : Attribute
    {
        public string Table { get; set; }
        public string Target { get; set; }
        public CheckDuplicate(string table, string target)
        {
            this.Table = table;
            this.Target = target;

        }

    }

    public class Identifier : Attribute
    {
        public string string_Identier { get; set; }
        public Identifier(string value)
        {
            this.string_Identier = value;
        }

    }

    public class Disabled : Attribute
    {
        public Disabled()
        {
        }

    }

    public class PlaceHolder : Attribute
    {
        public string string_Placeholder{ get; set; }
        public PlaceHolder(string value)
        {
            this.string_Placeholder = value;

        }
    }
    public class FormCSS : Attribute
    {
        public string string_FormCSS { get; set; }
        public FormCSS(string value)
        {
            this.string_FormCSS = value;
        }
    }

}
