using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IRestBasedWebService
{
    [OperationContract]
    [WebGet(UriTemplate="/welcome/{myname}")]  //the name specified in UriTemplate must match the parameter name eg.. myname
    string Welcome(string myname);

    [OperationContract]
    [WebGet(UriTemplate = "/add/{val1}/{val2}")]
    int Add(string val1, string val2);  //arguments for methods must be strings bcoz Variables for UriTemplate path segments must have type 'string'.

}
