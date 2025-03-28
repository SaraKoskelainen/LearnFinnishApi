using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnFinnishApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordListController : ControllerBase
    {
         Dictionary<int, Dictionary<string, string>> tmpData = 
            new Dictionary<int, Dictionary<string, string>> 
            {
                {
                    1, 
                    new Dictionary<string, string> 
                    {
                        {"text_to_translate", "Cake"},
                        {"optionA", "Kakku"},
                        {"optionB", "Kakka"},
                        {"optionC", "Kukka"}
                    }
                },
                {
                    2, 
                    new Dictionary<string, string> 
                    {
                        {"text_to_translate", "Lemonade"},
                        {"optionA", "Lima"},
                        {"optionB", "Mehu"},
                        {"optionC", "Limu"}
                    }
                },

            };

        [HttpGet]
        public Dictionary<int, Dictionary<string, string>> Get() {
            return tmpData;
        }
    }
}
