using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public interface IDataBaseServices
    {
        void AddMovie(Movies movie);
        void UpdateMovie(Movies movie, int id);
        void DeleteMovie(int id);

        void AddAcotor(Actors actor);
        void UpdateActor(Actors actor, int id);
        void DeleteActor(int id);

        void AddUser(Users user);
        void UpdateUser(Users user, int id);
        void DeleteUser(int id);
    }
}
