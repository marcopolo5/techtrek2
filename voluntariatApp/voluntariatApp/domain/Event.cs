using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
	internal class Event : Entity<long>
	{
		private string Name { get; init; }
		private string CuiOrganiser{ get; init; }
		private int NumberOfParticipants { get; init; }
		private string Location { get; init; }
		private DateTime StartDateTime { get; init; }
		private DateTime EndDateTime { get; init; }
		private string ParticipationConditions { get; init; }
		private string EventDescription { get; init; }

		//Still not sure whether it should be public or private
		public List<EventSignup> SignupList { get; init; } = new List<EventSignup>();
		public List<Participation> ParticipationList { get; init; } = new List<Participation>();

		public Event(long id, string name, string cuiOrganiser, int numberOfParticipants, string location, 
			DateTime startDateTime, DateTime endDateTime, string participationConditions, string eventDescription)
		{
			this.Name = name;
			this.CuiOrganiser = cuiOrganiser;
			this.NumberOfParticipants = numberOfParticipants;
			this.Location = location;
			this.StartDateTime = startDateTime;
			this.EndDateTime = endDateTime;
			this.ParticipationConditions = participationConditions;
			this.EventDescription = eventDescription;
			this.setId(id);
		}
	}
}
