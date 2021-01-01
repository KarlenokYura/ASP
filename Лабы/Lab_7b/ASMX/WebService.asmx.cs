using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASMX
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        Models.TelephoneDictionary telephoneDictionary = new Models.TelephoneDictionary();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "Get list", EnableSession = true)]
        public string GetAll()
        {
            return telephoneDictionary.getAll();
        }

        [WebMethod(Description = "Get all numbers", EnableSession = true)]
        public List<Models.Telephone> GetDict()
        {
            return telephoneDictionary.selectAll();
        }

        [WebMethod(Description = "Add new number", EnableSession = true)]
        public string AddDict(string surname, int number)
        {
            telephoneDictionary.insert(surname, number);

            return "OK";
        }

        [WebMethod(Description = "Update number by id", EnableSession = true)]
        public string UpdDict(int id, string surname, int number)
        {
            telephoneDictionary.update(id, surname, number);

            return "OK";
        }

        [WebMethod(Description = "Delete number by id", EnableSession = true)]
        public string DelDict(int id)
        {
            telephoneDictionary.delete(id);

            return "OK";
        }
    }
}
