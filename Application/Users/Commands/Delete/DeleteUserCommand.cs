using TrackYourLifeDotnet.Application.Abstractions.Messaging;

namespace TrackYourLifeDotnet.Application.Users.Commands.Remove;

public sealed record RemoveUserCommand(Guid UserId) : ICommand<RemoveUserResponse>;
