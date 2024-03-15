using Stock.Core.Application.UOW;
using Stock.Supplier.Infra.Context;

namespace Stock.Supplier.Infra.UOW;

public class UnitOfWork: IUnitOfWork
{
    private readonly SupplierContext.SupplierDbContext _context;
    public UnitOfWork(SupplierContext.SupplierDbContext context) => _context = context;
    
    public async Task Commit(CancellationToken cancellationToken = default) 
        => await _context.SaveChangesAsync(cancellationToken);
}