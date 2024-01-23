using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Storage;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.BL
{
    public class LoginFailureException : Exception
    {
        // Two Contructors to handle the presence or
        // absense of a developer thrown message.
        public LoginFailureException() : base("Cannot log in with these credentials. Your IP address has been saved.")
        {

        }
        public LoginFailureException(string message) : base(message)
        {

        }

    }
    public static class UserManager
    {
        private static string GetHash(string password)
        {
            using (var hasher = SHA1.Create())
            {
                var hashbytes = Encoding.UTF8.GetBytes(password);
                return Convert.ToBase64String(hasher.ComputeHash(hashbytes));
            }
        }

        public static int DeleteAll()
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    dc.tblUsers.RemoveRange(dc.tblUsers.ToList());
                    return dc.SaveChanges();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(User user, bool rollback = false)
        {
            try
            {
                int results = 0;

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblUser row = new tblUser();

                    row.Id = dc.tblUsers.Any() ? dc.tblUsers.Max(u => u.Id) + 1 : 1;
                    row.FirstName = user.FirstName;
                    row.LastName = user.LastName;
                    row.UserName = user.UserName;
                    row.Password = UserManager.GetHash(user.Password);

                    dc.tblUsers.Add(row);
                    results = dc.SaveChanges();

                    if (rollback) transaction.Rollback();

                    user.Id = row.Id;
                    return results;

                }
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }

        public static bool Login(User user)
        {
            try
            {
                if (!string.IsNullOrEmpty(user.UserName))
                {
                    if(!string.IsNullOrEmpty(user.Password))
                    {
                        using(DVDCentralEntities dc = new DVDCentralEntities())
                        {
                            tblUser tblUser = dc.tblUsers.FirstOrDefault(u => u.UserName == user.UserName);
                            if(tblUser != null)
                            {
                                // valid userid
                                if(tblUser.Password == GetHash(user.Password))
                                {
                                    // Login Happened - WOOHOO!!
                                    user.Id = tblUser.Id;
                                    user.UserName = tblUser.UserName;
                                    user.FirstName = tblUser.FirstName;
                                    user.LastName = tblUser.LastName;
                                    return true;
                                }
                                else
                                {
                                    throw new LoginFailureException();

                                    // or
                                    // throw new LoginFailureException("No Luck Mate");
                                }
                            }
                            else
                            {
                                // invalid userid
                                throw new Exception("UserId could not be found.");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Password was not set");
                    }
                }
                else
                {
                    throw new Exception("UserId was not set.");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public static void Seed()
        {
            User user = new User
            {
                FirstName = "Wichai",
                LastName = "Xiong",
                UserName = "vthoj21",
                Password = "soccer"
            };
            Insert(user);

            user = new User
            {
                FirstName = "Brian",
                LastName = "Foote",
                UserName = "bfoote",
                Password = "maple"
            };
            Insert(user);
        }
    }
}
