using AirAstanaProject.Controllers;
using AirAstanaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AirAstanaProject
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public void InsertData(int User_ID, string Surname, string Name, string Patronymic, 
            DateTime Birthday, string Email, string Description )
        {
            User user = new User(User_ID,Surname,Name, Patronymic, Birthday, Email, Description);
            UsersController userController = new UsersController();
            try
            {
                userController.Create(user);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Source, e.Message);
            }
           
            
        }
       [WebMethod]
       public void DeleteData(int id)
        {
            UsersController usersController = new UsersController();
            try
            {
                usersController.DeleteConfirmed(id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
        [WebMethod]
        public void EditData(int User_ID, string Surname, string Name, string Patronymic,
            DateTime Birthday, string Email, string Description)
        {
            User user = new User(User_ID, Surname, Name, Patronymic, Birthday, Email, Description);
            UsersController userController = new UsersController();
            try
            {
                userController.Edit(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source, e.Message);
            }

        }
        

    }
}
