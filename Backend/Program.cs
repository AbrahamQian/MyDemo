using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost sh = new ServiceHost(typeof(DemoService)))
            {
                sh.Open();
                Console.WriteLine("service is ready....");

                Console.ReadLine();

                sh.Close();
            }
        }
    }
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        [WebInvoke(ResponseFormat =WebMessageFormat.Json,RequestFormat =WebMessageFormat.Json)]
        DemoResponse DoTheThing(DemoRequest request);
    }
    [DataContract]
    public class DemoRequest
    {
        [DataMember]
        public string Foo { get; set; }
        [DataMember]
        public string Bar { get; set; }
    }

    [DataContract]
    public class DemoResponse
    {
        [DataMember]
        public string Baz { get; set; }
        [DataMember]
        public string Quux { get; set; }
    }
    public class DemoService : IDemoService
    {
        public DemoResponse DoTheThing(DemoRequest request) =>
             new DemoResponse
             {
                 Baz = request.Foo + request.Bar,
                 Quux = request.Bar + request.Foo
             };
    }
}
