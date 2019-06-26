using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Tester.ServiceReference1;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceReference1.DemoServiceClient client = new ServiceReference1.DemoServiceClient();
            DemoRequest dr = new DemoRequest()
            {
                Foo = "A",
                Bar = "B"
            };


            //DemoResponse result = client.DoTheThing(dr);
            //Console.WriteLine($"{result.Baz}\t{result.Quux}");

            ChannelFactory<IDemoService> factory = new ChannelFactory<IDemoService>("test");
            IDemoService service = factory.CreateChannel();
            try
            {
                var result = service.DoTheThing(dr);
                Console.WriteLine($"{result.Baz}\t{result.Quux}");

            }
            catch (Exception)
            {

                throw;
            }



            Console.ReadLine();
        }
    }
}
