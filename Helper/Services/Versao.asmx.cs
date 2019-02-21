using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
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


        [WebMethod]
        public string atualizaDashboard(int CodUsuario, string Usuario)
        {
            if (Usuario.ToUpper().Equals("ADMIN"))
            {
                int ticketAberto = 0;
                BancoDados b = new BancoDados();
                //Ticket's em aberto
                b.Query(@"SELECT Count(*) AS ticket 
                            FROM   atendimentos 
                            WHERE  ate_codstatus = 1 ");
                DataTable dt = b.ExecutarDataTable();
                if (dt.Rows.Count > 0)
                {
                    ticketAberto = int.Parse(dt.Rows[0]["ticket"].ToString());
                }

                return JsonConvert.SerializeObject(new { QTAbertos = ticketAberto});
            }
            else
            {
                return JsonConvert.SerializeObject(new { QTAbertos = 0 });
            }
            
        }
    }
}
