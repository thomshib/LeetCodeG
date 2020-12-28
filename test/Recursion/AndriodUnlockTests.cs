
using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;
using test.utility;

namespace test
{
    
        

public class AndriodUnlockTests{
        
        [Fact]
        public void shouldreturnvalidresultforMethod()
        {

            var result = new AndriodUnlock().NumberOfPatterns(1,2);
            Assert.Equal(65,result);


        }

}
}

