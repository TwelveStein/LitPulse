namespace LitPulse.FileProviders;

public interface IFileProvider
{
    Task SaveFileAsync(CancellationToken cancellationToken);
}