using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CagriMerkezi_200601021_SanerYesil
{
    public class CustomerQueue
    {
        Queue<string> comQueue = new Queue<string>();
        Queue<string> perQueue = new Queue<string>();



        public string[] comArray;
        public string[] perArray;
        int personalNo = 1;
        public int commercialNo = 1;

        //Ticari Müşteri Kuyruğuna Ekleme Yapmaktadır
        public void AddCommercial()
        {
            
            DateTime time = DateTime.Now;
            comQueue.Enqueue(commercialNo + " Nolu Ticari Müşteri, Çağrı Tarihi -->" + time.ToString());
            commercialNo++;
            

        }
        //Bireysel Müşteri Kuyruğuna Ekleme Yapmaktadır
        public void AddPersonal()
        {
            DateTime time = DateTime.Now;
            perQueue.Enqueue(personalNo + " Nolu Bireysel Müşteri, Çağrı Tarihi -->" + time.ToString());
            personalNo++;
        }
        public void CommercialOutput()
        {
            Queue<string> comQueueCopy = new Queue<string>(comQueue);
            comArray = comQueueCopy.ToArray(); ; 
        }
        public void PersonalOutput()
        {
            Queue<string> perQueueCopy = new Queue<string>(perQueue);
            perArray = perQueueCopy.ToArray();   
            
        }

        public string CommercialCallAssignment()
        {
            string assignedComCall;
            assignedComCall = comQueue.Dequeue().ToString();
            return assignedComCall;
            
        }
        public string PersonalCallAssignment()
        {
            string assignedPerCall;
            assignedPerCall = perQueue.Dequeue().ToString();
            return assignedPerCall;

        }



    }
}
