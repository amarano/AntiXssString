using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.Security.AntiXss;

namespace AntiXssString
{
    public class AntiXssString
    {
        private readonly string _s;

        private AntiXssString(string s)
        {
            _s = s;
        }

        private string GetValue()
        {
            var safeString = AntiXssEncoder.HtmlEncode(_s, true);
            return safeString;
        }

        protected string GetRawValue()
        {
            return _s;
        }

        public static implicit operator AntiXssString(string s)
        {
            return new AntiXssString(s);
        }
        
        public static implicit operator string(AntiXssString s)
        {
            return s.GetValue();
        }

        public override string ToString()
        {
            return this.GetValue();
        }

    }
}
