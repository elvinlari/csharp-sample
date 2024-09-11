// IOurHeroService.cs

using WebApi1.Model;

namespace WebApi1.Services
{
    public interface IOurHeroService
    {
        Task<List<OurHero>> GetAllHeros(bool? isActive);

        Task<OurHero?> GetHerosByID(int id);

        Task<OurHero?> AddOurHero(AddUpdateOurHero obj);

        Task<OurHero?> UpdateOurHero(int id, AddUpdateOurHero obj);

        Task<bool> DeleteHerosByID(int id);

        // List<OurHero> GetAllHeros(bool? isActive);

        // OurHero? GetHerosByID(int id);

        // OurHero AddOurHero(AddUpdateOurHero obj);

        // OurHero? UpdateOurHero(int id, AddUpdateOurHero obj);

        // bool DeleteHerosByID(int id);
    }
}