using TrackYourLifeDotnet.Application.Abstractions.Messaging;

namespace TrackYourLifeDotnet.Application.Users.Commands.VerifyEmail;

public sealed record VerifyEmailCommand(string VerificationToken) : ICommand<VerifyEmailResult>;
