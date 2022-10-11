using eTickets.Data.Base;
using eTickets.Data.ViewModels;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        public Task<Movie> GetMovieByIdAsync(int id);
        public Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        public Task AddNewMovieAsync(NewMovieVM data);
        public Task UpdateMovieAsync(NewMovieVM data);
    }
}
