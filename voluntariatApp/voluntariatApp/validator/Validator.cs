using System;
using System.Linq;
using System.Text.RegularExpressions;
using voluntariatApp.domain;

namespace voluntariatApp.validator
{
    internal static class Validator
    {
        public static bool IsValidCNP(string cnp)
        {
            return !string.IsNullOrWhiteSpace(cnp) &&
                   cnp.Length == 13 &&
                   cnp.All(char.IsDigit);
        }

        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) &&
                   name.Length >= 2 &&
                   name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        public static bool IsValidOccupation(object occupation)
        {
            return occupation != null;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            var phoneRegex = new Regex(@"^\+?[0-9]{7,15}$");
            return phoneRegex.IsMatch(phoneNumber);
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            return password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(c => "!@#$%^&*()_+-=[]{}|;:',.<>?/".Contains(c));
        }

        public static bool IsValidCUI(string CUI)
        {
            if (string.IsNullOrWhiteSpace(CUI) || !CUI.All(char.IsDigit))
                return false;
            if (CUI.Length < 2 || CUI.Length > 10)
                return false;
            return true;
        }

        public static bool IsValidEventPeriod(EventPeriod eventPeriod, out string errorMessage)
        {
            if (eventPeriod == null)
            {
                errorMessage = "EventPeriod cannot be null.";
                return false;
            }

            if (eventPeriod.StartDate == default || eventPeriod.EndDate == default)
            {
                errorMessage = "StartDate and EndDate must be valid dates.";
                return false;
            }

            if (eventPeriod.StartDate > eventPeriod.EndDate)
            {
                errorMessage = "StartDate cannot be later than EndDate.";
                return false;
            }

            if (eventPeriod.StartDate < DateTime.UtcNow)
            {
                errorMessage = "StartDate cannot be in the past.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public static bool IsValidEventName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length >= 3;
        }

        public static bool IsValidNumberOfParticipants(int numberOfParticipants, int maxParticipants)
        {
            return numberOfParticipants > 0 && numberOfParticipants <= maxParticipants;
        }

        public static bool IsValidLocation(Location location)
        {
            if (location == null)
                return false;

            if (string.IsNullOrWhiteSpace(location.State) ||
                string.IsNullOrWhiteSpace(location.City) || 
                string.IsNullOrWhiteSpace(location.StreetName) ||
                string.IsNullOrWhiteSpace(location.StreetNumber))
            {
                return false;
            }

            if (!location.StreetNumber.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidEventPeriod(EventPeriod eventPeriod)
        {
            return eventPeriod != null &&
                   eventPeriod.StartDate <= eventPeriod.EndDate &&
                   eventPeriod.StartDate >= DateTime.UtcNow;
        }

        public static bool IsValidParticipationRequirements(string participationRequirements)
        {
            return !string.IsNullOrWhiteSpace(participationRequirements);
        }

        public static bool IsValidEventDescription(string eventDescription)
        {
            return !string.IsNullOrWhiteSpace(eventDescription);
        }

        public static bool IsValidEvent(Event eventObj, out string errorMessage)
        {
            if (eventObj == null)
            {
                errorMessage = "Event cannot be null.";
                return false;
            }

            if (!IsValidEventName(eventObj.Name))
            {
                errorMessage = "Event name must be at least 3 characters long.";
                return false;
            }

            if (!IsValidNumberOfParticipants(eventObj.NumberOfParticipants, eventObj.NumberOfParticipants))
            {
                errorMessage = "Number of participants must be a positive number and cannot exceed the maximum allowed.";
                return false;
            }

            if (!IsValidLocation(eventObj.Location))
            {
                errorMessage = "Location must be valid.";
                return false;
            }

            if (!IsValidEventPeriod(eventObj.Period))
            {
                errorMessage = "Event period is invalid. Ensure the start date is not in the past and the start date is not after the end date.";
                return false;
            }

            if (!IsValidParticipationRequirements(eventObj.ParticipationRequirements))
            {
                errorMessage = "Participation requirements cannot be empty.";
                return false;
            }

            if (!IsValidEventDescription(eventObj.EventDescription))
            {
                errorMessage = "Event description cannot be empty.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
