using System;
using System.Collections.Generic;
using System.Text;

namespace DecreaseCommute.Testing.Library
{
    public class UserTest
    {
        private User sut;
        private static EntityData entity = new EntityData();

        public UserTest()
        {
            sut = new User()
            {

            };
        }

        #region User Data State Tests
            Test_User_ValidType
            Test_User_Authentication
            Test_User_SavedRoutes
        #endregion

        #region User Behavior Tests
            Test_User_CreateAccount
            Test_User_SaveRoute
            ?Test_User_RemoveRoute?

        #endregion

    }
}
