using Play4Fun.Services.Dtos;

namespace Play4Fun.Services
{
    public interface IGameService
    {
        public List<GameDto> GetAllPlayable();
    }
}