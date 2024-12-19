using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;
using voluntariatApp.domain.enums;

namespace voluntariatApp.repo
{
    internal class TypeMatching<E, ID> where E : Entity<ID>
    {
        public static string returnTableName(Type type)
        {
            if (type == typeof(User))
            {
                return "users";
            }
            else if (type == typeof(Organiser))
            {
                return "organizatori";
            }
            else if (type == typeof(LoginEntity))
            {
                return "logins";
            }
            else if (type == typeof(Event))
            {
                return "events";
            }
            else if (type == typeof(EventSignup))
            {
                return "signups";
            }
            else if (type == typeof(Participation))
            {
                return "participations";
            }
            else throw new ArgumentException("Invalid entity type " + type.Name);
        }

        public static E? createEntityFromList(Type type, List<string> parameters)
        {
            if (type == typeof(User))
            {
                return new User(
                    parameters[0],
                    parameters[1],
                    (Occupation)Enum.Parse(typeof(Occupation), parameters[2])
                ) as E;
            }
            else if (type == typeof(Organiser))
            {
                return new Organiser(
                    parameters[0],
                    parameters[1],
                    (OrganiserType)Enum.Parse(typeof(OrganiserType), parameters[2]),
                    parameters[3]
                ) as E;
            }
            else if (type == typeof(LoginEntity))
            {
                return new LoginEntity(
                    parameters[0],
                    parameters[1],
                    parameters[2],
                    parameters[3],
                    parameters[4]
                ) as E;
            }
            else if (type == typeof(Event))
            {
                return new Event(
                    long.Parse(parameters[0]),
                    parameters[2],
                    parameters[1],
                    int.Parse(parameters[3]),
                    new Location(parameters[4].Split(";")),
                    new EventPeriod(DateTime.Parse(parameters[5]), DateTime.Parse(parameters[6])),
                    parameters[7],
                    parameters[8]
                ) as E;
            }
            else if (type == typeof(EventSignup))
            {
                return new EventSignup(
                    parameters[0],
                    long.Parse(parameters[1]),
                    DateTime.Parse(parameters[2]),
                    bool.Parse(parameters[4]),
                    parameters[3]
                ) as E;
            }
            else if (type == typeof(Participation))
            {
                return new Participation(
                    parameters[0],
                    long.Parse(parameters[1]),
                    bool.Parse(parameters[2]),
                    parameters[3]
                ) as E;
            }
            else throw new ArgumentException("Invalid entity type " + type.Name);
        }

        public static string createListFromEntity(E Entity)
        {
            //Change this function to return a string like: "cnp, name, occupation" -> like this: "(1, 'Alex Zdroba', 'Student')
            var resultList = $"(";

            if (Entity is User user)
            {
                resultList += $"\'{user.Cnp}\', ";
                resultList += $"\'{user.Name}\', ";
                resultList += $"\'{user.Occupation.ToString()}\')";
            }
            else if (Entity is Organiser organiser)
            {
                resultList += $"\'{organiser.Cui}\', ";
                resultList += $"\'{organiser.Name}\', ";
                resultList += $"\'{organiser.Field.ToString()}\', ";
                resultList += $"\'{organiser.Description}\')";
            }
            else if (Entity is LoginEntity loginEntity)
            {
                resultList += $"{loginEntity.getId()}, ";
                resultList += $"\'{loginEntity.Username}\', ";
                resultList += $"\'{loginEntity.Password}\', ";
                resultList += $"\'{loginEntity.PhoneNumber}\', ";
                resultList += $"\'{loginEntity.Email}\')";
            }
            else if (Entity is Event eventEntity)
            {
                resultList += $"{eventEntity.getId()}, ";
                resultList += $"\'{eventEntity.Name}\', ";
                resultList += $"\'{eventEntity.CuiOrganiser}\', ";
                resultList += $"{eventEntity.NumberOfParticipants}, ";
                resultList += $"\'{eventEntity.Location.ToString()}\', ";
                resultList += $"\'{eventEntity.Period.StartDate.ToString("yyyy-MM-dd HH:mm:ss")}\', ";
                resultList += $"\'{eventEntity.Period.EndDate.ToString("yyyy-MM-dd HH:mm:ss")}\', ";
                resultList += $"\'{eventEntity.ParticipationRequirements}\', ";
                resultList += $"\'{eventEntity.EventDescription}\')";
            }
            else if (Entity is EventSignup eventSignup)
            {
                resultList += $"\'{eventSignup.getId().Item1}\', ";
                resultList += $"{eventSignup.getId().Item2}, ";
                resultList += $"\'{eventSignup.SignupDateTime.ToString("yyyy-MM-dd:HH-mm")}\', ";
                resultList += $"\'{eventSignup.Reason}\', ";
                resultList += $"{eventSignup.Accepted.ToString().ToUpper()})";
            }
            else if (Entity is Participation participation)
            {
                resultList += $"\'{participation.getId().Item1}\', ";
                resultList += $"{participation.getId().Item2}, ";
                resultList += $"{participation.Present.ToString().ToUpper()}, ";
                resultList += $"\'{participation.Feedback}\')";
            }
            else
                throw new ArgumentException("Invalid entity type " + Entity.GetType().Name);

            return resultList;
        }

        internal static string returnIdCondition(Type type, ID id)
        {
            if (type == typeof(User))
            {
                return $"cnp = \'{id}\'";
            }
            else if (type == typeof(Organiser))
            {
                return $"cui = \'{id}\'";
            }
            else if (type == typeof(LoginEntity))
            {
                return $"id = \'{id}\'";
            }
            else if (type == typeof(Event))
            {
                return $"id = {id}";
            }
            else throw new ArgumentException("Invalid entity type " + type.Name);
        }
    }
}
