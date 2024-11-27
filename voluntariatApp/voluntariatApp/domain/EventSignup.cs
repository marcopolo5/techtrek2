using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
	internal class EventSignup :Entity<Tuple<string, long>>
	{
		private DateTime SignupDateTime { get; init; }
		private bool Accepted { get; set; }
		private string Reason { get; init; }

		public EventSignup (string cnpUser, long idEvent,  DateTime signupDateTime, bool accepted, string reason)
		{
			this.SignupDateTime = signupDateTime;
			this.Accepted = accepted;
			this.Reason = reason;
			this.setId(Tuple.Create(cnpUser, idEvent));
		}
	}
}
