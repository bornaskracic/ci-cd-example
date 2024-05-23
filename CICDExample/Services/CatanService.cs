using CICDExample.Services.Interfaces;

namespace CICDExample.Services
{
    public class CatanService : ICatanService
    {
        public List<string> GetResources()
        {
            return new() { "wheat", "wool", "wood", "ore", "brick" };
        }
    }
}
