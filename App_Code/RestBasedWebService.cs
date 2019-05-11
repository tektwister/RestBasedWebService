using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class RestBasedWebService : IRestBasedWebService
{
    public string Welcome(string yourName)
    {

        return string.Format("Welcome to WCF Web Services with REST and XML, {0}!",yourName);
    }
    public int Add(string val1, string val2)
    {
        int sum = Int32.Parse(val1) + Int32.Parse(val2);
        return sum;
    }
}
