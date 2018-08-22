using System;
using System.Collections.Generic;
using System.Text;

namespace DecreaseCommute.Testing.Library
{
    public class StationTests
    {
        private Station sut;

        public StationTests()
        {
            sut = new Station()
            {

            };
        }

        #region Station Data State Test
            Test_Station_StationName
        #endregion

        #region Station Behavior Test
            Test_Station_ReturnCode
        #endregion
    }
}
