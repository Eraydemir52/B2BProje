using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.DTOs
{
    public class UserDto
    {
       //Userdan 
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string phonenumber { get; set; }
        public string address { get; set; }
        //
        public int roleID { get; set; }
        public string name { get; set; }
        public int sepetID { get; set; }
    }
}
