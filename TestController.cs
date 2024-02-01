using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //  [Route("{x}")]
       
        // public string TestMethod([FromQuery]string param = "World!", [FromRoute]int x = 1)
        public bool TestMethod(string param = "World! ",int x = 1)
        {
            
            string cc = String.Empty;
            for(int i = 0; i < x; i++)
            {
               cc = String.Concat(cc, String.Concat("Hello",param));
            }
            return cc.StartsWithUpper();
        }
        public string Get()
        {
            return "Get Method";
        }
       
    }
}
