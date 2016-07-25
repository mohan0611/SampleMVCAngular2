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
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question2", title = "title 2" },
                new TriviaQuestion { question = "question2", title = "title 2" }
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
