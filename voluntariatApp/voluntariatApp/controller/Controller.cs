using voluntariatApp.domain;
using voluntariatApp.service;

namespace voluntariatApp.controller
{
    internal class Controller
    {
        private static Controller? instance = null;
        private LoginEntity? loggedInEntity;
        private Service service;

        private Controller()
        {
            this.service = new Service("Host=ep-soft-darkness-a9t94gzc.gwc.azure.neon.tech;Database=Voluntariat;Username=Voluntariat_owner;Password=YV2LJcNsgd3u;SSL Mode=Require;Trust Server Certificate=true");
        }
        public static Controller getInstance()
        {
            if (instance == null)
                instance = new Controller();
            return instance;
        }
        public void addLogin(List<string> param) => loggedInEntity = new LoginEntity(param[0], param[1], param[2], param[3]);
        public void signUpOrganizator(List<string> param)
        {
            try
            {
                service.addOrganiser(param[0], param[1], param[2], param[3], loggedInEntity.Username, loggedInEntity.Email, loggedInEntity.Password, loggedInEntity.PhoneNumber);
            }
            catch (Exception _)
            {
                this.loggedInEntity = null;
            }
        }
        public void signUpUser(List<string> param)
        {
            try
            {
                service.addUser(param[0], param[1], param[2], loggedInEntity.Username, loggedInEntity.Password, loggedInEntity.Email, loggedInEntity.PhoneNumber);
            }
            catch (Exception _)
            {
                this.loggedInEntity = null;
            }
        }

        public bool login(string username, string password)
        {
            try
            {
                this.loggedInEntity = this.service.login(username, password);
                return true;
            }
            catch (Exception _)
            {
                return false;
            }
        }
        public List<Event> topEvens()
        {
            return service.getPopularEventList();
        }

        public List<Event> organizationEvents()
        {
            return service.listaEvenimenteOrganizatie(loggedInEntity.getId());
        }

        public bool isUser()
        {
            return service.getUser(loggedInEntity.getId()) !=null;
        }
    }
}