using Proxy.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
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
    
    public class DemoService : IDemoService
    {
        //ServiceReference1.DemoServiceClient client = new DemoServiceClient();
        ChannelFactory<IDemoService> factory = new ChannelFactory<IDemoService>("backend");
        public DemoResponse DoTheThing(DemoRequest request)
        {
            request.Bar += "-Proxied";
            IDemoService service = factory.CreateChannel();
            using (OperationContextScope scope = new OperationContextScope((IContextChannel)service))
            {
                WebOperationContext woc = WebOperationContext.Current;
                woc.OutgoingRequest.ContentType = "application/json; charset=utf-8";
                var result = service.DoTheThing(request);
                try
                {
                    return result;
                }
                finally
                {
                    if (result is System.ServiceModel.ICommunicationObject client)
                    {
                        if (client.State == System.ServiceModel.CommunicationState.Faulted) client.Abort();
                        else client.Close();
                    }
                }
            }
        }

    }
}
