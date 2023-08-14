using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripModel.DTO;

namespace TripData
{
    public class TripStore
    {
        public static List<UserDTO> userList = new List<UserDTO>
            {
                new UserDTO{UserId=1,FullName="Tom",Email="tom@gmail.com",Password="Tom@123",Gender="Male",Age=30,PermanentAddres="Delhi",Currentaddress="Delhi"},
                new UserDTO{UserId=2,FullName="Jerry",Email="jerry@gmail.com",Password="Jerry@123",Gender="Male",Age=30,PermanentAddres="Delhi",Currentaddress="Delhi"}
                
            };
    }
}
