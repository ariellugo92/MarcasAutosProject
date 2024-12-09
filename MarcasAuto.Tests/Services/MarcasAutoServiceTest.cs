using MarcasAuto.Application.Services;
using MarcasAuto.Infraestructure.Seeds;
using MarcasAuto.Tests.Base;

namespace MarcasAuto.Tests.Services;

public class MarcasAutoServiceTest: BaseUnitTest
{
    [Fact]
    public async Task ShouldReturnItemsAsync()
    {
        // Arrange
        var service = new MarcasAutoService(_dbContext);

        // Act
        var result = await service.GetAll();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(result.Count(), MarcasSeed.Items.Length);
    }
}