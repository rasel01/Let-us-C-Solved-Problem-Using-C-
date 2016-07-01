using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class UserInfoDictionary
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Phone { get; set; }

        public UserInfoDictionary(string Name, string Profession, string Phone)
        {
            this.Name = Name;
            this.Profession = Profession;
            this.Phone = Phone;
        }

        public static Dictionary<string, UserInfoDictionary> GetUserInfo()
        {
            var Information = new Dictionary<string, UserInfoDictionary>();
            var userInfo = new UserInfoDictionary("rasel","software engineer","+88016765259");
            Information.Add("user",userInfo);
            return Information;

        }
    }
}
