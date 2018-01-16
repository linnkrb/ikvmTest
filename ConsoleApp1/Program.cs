using no.point.paypoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPayex
{
    class Program
    {




        static void Main(string[] args)
        {
            NewMethod();

        }

        private static void NewMethod()
        {

            try
            {

       
            PayPoint pim = new PayPoint();

            var ip = "192.168.10.131";
            int logLevel = 1;
            pim.setPayPointListener(new TestListner());


            pim.open(ip, 0, "point_", 3);

            pim.startTestCom();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }


        }

        public class TestListner : PayPointListener
        {
            public void getPayPointEvent(PayPointEvent ppe)
            {
                var test = ppe.toString();
            }
        }




        enum transModes : short
        {
            MODE_NORMAL = 0x30,
            MODE_REQ_PREV = 0x31
        }

        enum transTypes : short
        {
            TRANS_TEST = 0x30,

        }
    }
}
