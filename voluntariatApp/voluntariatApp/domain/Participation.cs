using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
    internal class Participation : Entity<Tuple<string, long>>
    {
        private bool Present { get; init; }
        private string Feedback { get; init; }

        public Participation(string cnp, long id, bool present, string feedback)
        {
            this.Present = present;
            this.Feedback = feedback;
            this.setId(Tuple.Create(cnp, id));
        }
    }
}