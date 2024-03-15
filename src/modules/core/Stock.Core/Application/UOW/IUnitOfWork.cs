namespace Stock.Core.Application.UOW;

public interface IUnitOfWork
{
    public Task Commit(CancellationToken cancellationToken = default);
}