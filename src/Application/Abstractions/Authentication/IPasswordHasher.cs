namespace TrackYourLifeDotnet.Application.Abstractions.Authentication;

public interface IPasswordHasher
{
    string Hash(string password);

    bool Verify(string passwordHash, string inputPassword);
}
