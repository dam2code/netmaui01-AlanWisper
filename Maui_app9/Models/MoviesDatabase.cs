using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_app9.Models
{
    internal static class MoviesDatabase
    {
        public async static Task<IEnumerable<Movie>> GetMovies()
        {
            using Stream stream = await FileSystem.OpenAppPackageFileAsync("data.json");

            System.Text.Json.JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
            };

            IEnumerable<Movie>? movies = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Movie>>(stream, options);

            return movies ?? [];
        }
    }
}
