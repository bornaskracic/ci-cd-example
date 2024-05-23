using CICDExample.Services;

namespace CICDExample.Tests.ServiceTest
{
    public class CatanServiceTest
    {

        private readonly CatanService _catanService;

        public CatanServiceTest()
        {
            _catanService = new CatanService();
        }

        [Fact]
        public void GetResourcesShouldReturn5Resources()
        {
            int expectedCount = 5;

            var resources = _catanService.GetResources();

            Assert.Equal(expectedCount, resources.Count);
        }
    }
}
