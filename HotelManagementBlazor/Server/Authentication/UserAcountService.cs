using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Authentication
{
    public class UserAcountService
    {
        private List<UserAccount> _userAccountList;

        public UserAcountService()
        {
            _userAccountList = new List<UserAccount>
            {
                new UserAccount{Username="manager@email.com", Password="Manager123" , Role="Manager"},
                new UserAccount {Username="staff@email.com", Password="Staff123",Role="Staff"},
                new UserAccount{Username="guest@email.com", Password="Guest123" , Role="Guest"}
            };
        }

        public UserAccount? GetUserAccountByUserName(string username)
        {
            return _userAccountList.FirstOrDefault(x => x.Username == username);
        }
    }
}
