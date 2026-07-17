using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Feature.AuthFeatures.Commands.Register;

public sealed class RegisterCommandHandler(IAuthService authService, IMailService mailService) : IRequestHandler<RegisterCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        await authService.RegisterAsync(request);

        var mailBody = $"""
            <h2>Hoş geldiniz, {request.FullName}</h2>
            <p>Clean Architecture uygulamasına kaydınız başarıyla oluşturuldu.</p>
            <p>Kullanıcı adınız: <strong>{request.UserName}</strong></p>
            """;

        await mailService.SendAsync(request.Email, "Kayıt işleminiz tamamlandı", mailBody, isHtml: true, cancellationToken);
        return new MessageResponse("Kullanıcı kaydı başarıyla tamamlandı!");
    }
}
