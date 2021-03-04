using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace XXG.Frm.Pages
{
    public class Index_Tests : FrmWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
