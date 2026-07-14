using CleanArchitecture.Application.Feature.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using Moq;

namespace CleanArchitecture.UnitTest;

public class CreateCarCommandHandlerUnitTest
{
    [Fact]
    public async Task Handle_ReturnsSuccessResponse_WhenRequestIsValid()
    {
        // Arrange

        var carServiceMock = new Mock<ICarService>();
        CreateCarCommand createCarCommand = new("Toyota", "Corolla", 5000);
        MessageResponse response = new("Araç başarıyla kaydedildi!");
        CancellationToken cancellationToken = new();

        carServiceMock.Setup(c => c.CreateAsync(createCarCommand, cancellationToken)).Returns(Task.FromResult(response));

        CreateCarCommandHandler handler = new CreateCarCommandHandler(carServiceMock.Object);

        // Act

        var result = await handler.Handle(createCarCommand, cancellationToken);

        // Assert

        var returnValue = Assert.IsType<MessageResponse>(result);

        Assert.Equal(returnValue, response);
        carServiceMock.Verify(c => c.CreateAsync(createCarCommand, cancellationToken), Times.Once);
    }
}
