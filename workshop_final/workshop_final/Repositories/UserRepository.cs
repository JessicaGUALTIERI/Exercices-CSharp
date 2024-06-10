using System;
using System.Text.RegularExpressions;
using workshop_final.Database;
using workshop_final.Models;
using workshop_final.Repositories;
using workshop_final_console.Repositories.MenusRepositories;

namespace workshop_final
{
	public static class UserRepository
	{
		public static void CreateUserInDatabase(string mail, string password)
		{
            User user = new User { Mail = mail, Password = password };
            using (var context = new AppDbContext())
            {
				context.Users.Add(user);
				context.SaveChanges();
            }
        }

        public static void SignIn()
        {
            Console.Write("INSCRIPTION\nAdresse mail choisie :\t\t\t");
            string mail = CreateAndVerifyMail();
            string password = CreateAndVerifyPasswords();
            Console.Write("Inscription validée. Connectez-vous !");
            CreateUserInDatabase(mail, password);
            Login();
        }

        public static void Login()
        {
            Console.Write("CONNEXION\nAdresse mail :\t\t\t");
            string mail = Console.ReadLine();
            Console.Write("Mot de passe:\t\t\t");
            string password = Console.ReadLine();
            if (ParametersToLoginAreCorrect(mail, password))
            {
                CurrentUser.Mail = mail;
                Console.WriteLine("Vous êtes bien connecté-e " + CurrentUser.Mail);
                AppMenuRepository.DisplayAppMenu();
            } else
            {
                Console.WriteLine("Erreur de connexion, veuillez réessayer.");
                while (!ParametersToLoginAreCorrect(mail, password))
                {
                    Login();
                }
            }
        }

        public static bool ParametersToLoginAreCorrect(string mail, string password)
        {
            bool toReturn = false;
            User user = new User();
            using (var context = new AppDbContext())
            {
                user = context.Users.FirstOrDefault(x => x.Mail == mail);
            }
            if (user != null && user.Password == password)
            {
                toReturn = true;
            }
            return toReturn;
        }

        public static string CreateAndVerifyMail()
        {
            string mail = Console.ReadLine();
            while (!IsMailValid(mail))
            {
                Console.Write("L'adresse mail saisie est invalide.\nVeuillez réessayer :\t\t\t");
                mail = Console.ReadLine();
            }
            return mail;
        }

        public static string CreateAndVerifyPasswords()
        {
            Console.Write("Le mot de passe doit comporter au moins 8 caractères et au maximum 20 ; une majuscule, une minuscule, un chiffre et un caractère spécial au moins.\nMot de passe choisi :\t\t\t");
            string password1 = Console.ReadLine();
            while (!IsPasswordCorrect(password1))
            {
                Console.Write("Le mot de passe saisi est invalide.\nVeuillez réessayer :\t\t\t");
                password1 = Console.ReadLine();
            }
            Console.Write("Confirmation de passe choisi :\t\t\t");
            string password2 = Console.ReadLine();
            while (!ArePasswordsEqual(password1, password2))
            {
                Console.Write("Les mots de passes ne correspondent pas.\nVeuillez réessayer :\t\t\t");
                password2 = Console.ReadLine();
            }
            return password1;
        }

        public static bool IsMailValid(string mail)
		{
			bool toReturn = false;
			if (mail != null)
			{
				mail = mail.Trim();
				if (IsNotNullEmptyWhiteSpace(mail) && Regex.IsMatch(mail, @"^[a-zA-Z0-9]+[a-zA-Z0-9._-]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
				{
					toReturn = true;
				}
			}
			return toReturn;
		}

		public static bool IsPasswordCorrect(string password)
		{
			bool toReturn = false;
			if (password != null)
			{
				password = password.Trim();
				if (IsNotNullEmptyWhiteSpace(password) && IsPasswordsLengthValid(password) && MinimumOneUppercase(password) && MinimumOneLowercase(password) && MinimumOneDigit(password) && MinimumOneNonAlphanumeric(password))
				{
					toReturn = true;
				}
			}
			return toReturn;
		}

		public static bool ArePasswordsEqual(string password1, string password2)
		{
			return password1 == password2;
		}

		public static bool MinimumOneUppercase(string password)
		{
			return Regex.IsMatch(password, @"[A-Z]");
		}

        public static bool MinimumOneLowercase(string password)
        {
            return Regex.IsMatch(password, @"[a-z]");
        }

        public static bool MinimumOneDigit(string password)
        {
            return Regex.IsMatch(password, @"[\d]");
        }

        public static bool MinimumOneNonAlphanumeric(string password)
        {
            return Regex.IsMatch(password, @"[!@#$%^&*()_+]");
        }

        public static bool IsPasswordsLengthValid(string password)
		{
			return IsPasswordLongEnough(password) && IsPasswordNotTooLong(password);
		}

		public static bool IsPasswordLongEnough(string password)
		{
			return password.Length > 8;
		}

		public static bool IsPasswordNotTooLong(string password)
		{
			return password.Length < 20;
		}

		public static bool IsNotNullEmptyWhiteSpace(string data)
		{
			return !string.IsNullOrEmpty(data) && !string.IsNullOrWhiteSpace(data);
		}
	}
}

