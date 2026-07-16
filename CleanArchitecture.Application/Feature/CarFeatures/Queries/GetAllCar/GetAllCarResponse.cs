namespace CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCar;

public sealed record GetAllCarResponse(string Id, string Name, string Model, int EnginePower);