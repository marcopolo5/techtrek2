using voluntariatApp.domain;
using voluntariatApp.service;

namespace voluntariatApp.test
{
    internal class Controller
    {
        private static Controller instance = null;
        private LoginEntity localData;
        private Service service = new Service("Host=ep-soft-darkness-a9t94gzc.gwc.azure.neon.tech;Database=Voluntariat;Username=Voluntariat_owner;Password=YV2LJcNsgd3u;SSL Mode=Require;Trust Server Certificate=true");
        private Controller()
        {
        }
        public static Controller getInstance()
        {
            if (instance == null)
                instance = new Controller();
            return instance;
        }
        public void addData(List<string> param)
        {
            localData = new LoginEntity(param[0], param[1], param[2], param[3]);
        }
        public void signUpOrganizator(List<string> param)
        {
            service.addOrganiser(param[0], param[1], param[2], param[3], localData.Username, localData.Email, localData.Password, localData.PhoneNumber);
        }
        public void signUpUser(List<string> param)
        {
            service.addUser(param[0], param[1], param[2], localData.Username, localData.Password, localData.Email, localData.PhoneNumber);
        }

    }
}
