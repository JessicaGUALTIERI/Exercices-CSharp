using System;
namespace workshop_final_API.Repositories
{
	public static class UserRepository
	{
        public static int GlobalId = 0;

        public static int CreateUser(string mail, string password)
        {
            Console.WriteLine("Mail : " + mail + "\nMot de passe :" + password);
            return GlobalId++;
        }

        public static bool DeleteUser(int id)
        {
            Console.WriteLine("L'utilisateur n°" + id + " a bien été supprimé.");
            return true;
        }
    }
}

