using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace SampleMVCAngular.Controllers
{
    [Authorize]
    public class TriviaController : ApiController
    {
        
        [ResponseType(typeof(TriviaQuestion))]
        public async Task<IHttpActionResult> Get()
        {

            var userID = User.Identity.Name;

            
            //TriviaQuestion question = new TriviaQuestion();
            //question.title = "Capital Name";
            //question.question = "My new question";

            //TriviaQuestion question2 = new TriviaQuestion();
            //question2.title = "Capital Name 2";
            //question2.question = "My new question 2";


            List<TriviaQuestion> lst = new List<TriviaQuestion>
            {
                new TriviaQuestion { question = "question1", title = "title 1" },
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question 3", title = "title 3" },
                new TriviaQuestion { question = "question  4", title = "title 4" },
                new TriviaQuestion { question = "question 5", title = "title 5" },
                new TriviaQuestion { question = "question 6", title = "title 6" },
                new TriviaQuestion { question = "question 7", title = "title 7" },
                new TriviaQuestion { question = "question 8", title = "title 8" },
                new TriviaQuestion { question = "question 9", title = "title 9" },
                new TriviaQuestion { question = "question 10", title = "title 10" }
            };


            return  this.Ok(lst);

        }


    }

    public class TriviaQuestion
    {
        public string title { get; set; }
        public string question { get; set; }
    }
}
