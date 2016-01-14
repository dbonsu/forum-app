namespace ForumApp.Common.Utility
{
    public interface IPasswordHash
    {
        string CreateHash(string password);

        bool ValidatePassword(string password, string correctHash);
    }
}