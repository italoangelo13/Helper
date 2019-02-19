using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace Helper
{
    /// <summary>
    /// Summary description for Versao
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Versao : System.Web.Services.WebService
    {

        [WebMethod]
        public string buscaVersao()
        {
            string versao = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            return JsonConvert.SerializeObject(versao);
        }
    }
}
