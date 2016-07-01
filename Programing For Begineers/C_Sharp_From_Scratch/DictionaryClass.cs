using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class DictionaryClass
    {
        public void IntroDictionary()
        {
            // how to declare dictionary :

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            //  how to add element to dictionary object
            myDictionary.Add("name", "rasel");
            myDictionary.Add("age", "24");
            myDictionary.Add("Profession", "software engineer");
            myDictionary.Add("mob", "+8801676525954");
            // display elements of dictionary
            Console.WriteLine("name : {0} " ,
                             // ", age : {1} , Profession : {2} , mobile no : {3}",
                              myDictionary["mob"]);
            
        }

        public void CreateDictionaryClass()
        {
            var userInfo = UserInfoDictionary.GetUserInfo();
            var key = userInfo["user"];
            Console.WriteLine("User name : {0} , user profession : {1} , user phone number : {2}",
               key.Name,key.Profession,key.Phone );
        }
    }
}
