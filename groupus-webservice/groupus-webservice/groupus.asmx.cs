using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace groupus_webservice
{
    /// <summary>
    /// Summary description for groupus
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class groupus : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int[] getIntArray()
        {
            int[] x = new int[3];
            x[0] = 1;
            x[1] = 2;
            x[2] = 3;

            return x;
        }
        
        // this function will not appear as web service function, will treat as local function
        public int thisIsNonWebMethod()
        {
            return 1;
        }
    }
}
