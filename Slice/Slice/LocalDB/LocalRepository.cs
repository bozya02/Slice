using Slice.Model;
using SQLite;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Slice.LocalDB
{
    public class LocalRepository
    {
        SQLiteConnection database;
        public LocalRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Dog>();
            database.CreateTable<User>();
        }

        #region Dogs
        public List<Dog> GetDogs()
        {
            return database.Table<Dog>().ToList();
        }

        public List<Dog> GetDogs(int userId)
        {
            return GetDogs().FindAll(x => x.UserId == userId);
        }

        public int SaveOrUpdateDog(Dog dog)
        {
            if (dog.Id != 0)
            {
                database.Update(dog);
                return dog.Id;
            }
            else
            {
                return database.Insert(dog);
            }
        }

        public int DeleteDog(int id)
        {
            return database.Delete<Dog>(id);
        }
        #endregion

        #region Users
        public List<User> GetUsers()
        {
            return database.Table<User>().ToList();
        }

        public bool IsSuccessLogin(string login, string password)
        {
            return GetUsers().Where(u => u.Login == login && u.Passwrod == password).Count() != 0;
        }

        public User GetUser(string login, string password)
        {
            return GetUsers().FirstOrDefault(u => u.Login == login && u.Passwrod == password);
        }

        public int SaveOrUpdateUser(User user)
        {
            if (user.Id != 0)
            {
                database.Update(user);
                return user.Id;
            }
            else
            {
                return database.Insert(user);
            }
        }
        #endregion
    }
}
