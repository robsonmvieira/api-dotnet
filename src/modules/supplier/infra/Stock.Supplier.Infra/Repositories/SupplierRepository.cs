using Microsoft.EntityFrameworkCore;
using Stock.Core.Application.UOW;
using Stock.Supplier.Domain.Entities;
using Stock.Supplier.Domain.Repositories;
using Stock.Supplier.Infra.Context;

namespace Stock.Supplier.Infra.Repositories;

public class SupplierRepository: ISupplierRepository, IDisposable
{
     private readonly SupplierContext.SupplierDbContext _context;
    private readonly IUnitOfWork _unitOfWork;
    private DbSet<Category> _categories => _context.Set<Category>();
    private DbSet<Domain.Entities.Supplier> _suppliers => _context.Set<Domain.Entities.Supplier>();
    
    private DbSet<Address> _addresses => _context.Set<Address>();
    
    private DbSet<Product> _products => _context.Set<Product>();
    
    public SupplierRepository(SupplierContext.SupplierDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }
    
    
    public async Task Insert(Domain.Entities.Supplier entity, CancellationToken cancellationToken = default)
    {
        await _suppliers.AddAsync(entity, cancellationToken);
        await _unitOfWork.Commit(cancellationToken);
    }

    public async Task Update(Domain.Entities.Supplier entity, CancellationToken cancellationToken = default)
    {
        
        _suppliers.Update(entity);
        await _unitOfWork.Commit(cancellationToken);
    }

    public async Task Delete(Guid entity, CancellationToken cancellationToken = default)
    {
        var category = await _categories.FindAsync(new object[] { entity }, cancellationToken);
        if (category == null)
        {
            throw new Exception("Category not found");
        }
        _categories.Remove(category);
        await _unitOfWork.Commit(cancellationToken);
    }

    public async Task<Domain.Entities.Supplier> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        var category = await _suppliers.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id , cancellationToken);
        return category;
    }

    public async Task<IEnumerable<Domain.Entities.Supplier>> GetAll(CancellationToken cancellationToken = default)
    {
        return await _suppliers.AsNoTracking().ToListAsync(cancellationToken);
    }

    // public async Task<SearchOutput<Domain.Entities.Supplier>> Search(SearchInput input, CancellationToken cancellationToken = default)
    // {
    //     var skip = (input.Page - 1) * input.PerPage;
    //     var query = _suppliers.AsNoTracking();
    //     
    //     if (!string.IsNullOrEmpty(input.Search))
    //     {
    //         query = query.Where(x => x.Name.Contains(input.Search) || x.Document.Contains(input.Search));
    //     }
    //     
    //     query = ApplyOrder(query, input.OrderBy, input.Order.Value);
    //     
    //     var total = await query.CountAsync(cancellationToken);
    //     var items = await query.Skip(skip).Take(input.PerPage).ToListAsync(cancellationToken);
    //     return new SearchOutput<DE.Supplier>(input.Page, input.PerPage, total, items);
    // }

    // private IQueryable<DE.Supplier> ApplyOrder(IQueryable<DE.Supplier> list, string queryField, SearchOrder order) => (
    //         queryField.ToLower(), order) switch
    //     {
    //         ("name", SearchOrder.Asc) => list.OrderBy(x => x.Name),
    //         ("name", SearchOrder.Desc) => list.OrderByDescending(x => x.Name),
    //         // ("description", SearchOrder.Asc) => list.OrderBy(x => x.Description),
    //         // ("description", SearchOrder.Desc) => list.OrderByDescending(x => x.Description),
    //         ("createdAt", SearchOrder.Asc) => list.OrderBy(x => x.CreatedAt),
    //         ("createdAt", SearchOrder.Desc) => list.OrderByDescending(x => x.CreatedAt),
    //         ("updatedAt", SearchOrder.Asc) => list.OrderBy(x => x.UpdatedAt),
    //         ("updatedAt", SearchOrder.Desc) => list.OrderByDescending(x => x.UpdatedAt),
    //         _ => list.OrderBy(x => x.CreatedAt)
    //     };
    

    public async Task AddAddress(Address address, CancellationToken cancellationToken = default)
    {
        await _addresses.AddAsync(address);
        await _unitOfWork.Commit();
    }

    public async Task UpdateAddress(Address address, CancellationToken cancellationToken = default)
    {
        _addresses.Update(address);
        await _unitOfWork.Commit();
    }

    public async Task AddProduct(Product product, CancellationToken cancellationToken = default)
    {
        await _products.AddAsync(product);
        await _unitOfWork.Commit();
    }

    public async Task UpdateProduct(Product product, CancellationToken cancellationToken = default)
    {
       _products.Update(product);
        await _unitOfWork.Commit();
    }

    public async Task DeleteProduct(Guid productId, CancellationToken cancellationToken = default)
    {
        var product = await _products.FindAsync(new object[] { productId });
        if (product == null)
        {
            throw new Exception("Product not found");
        }
       _products.Remove(product);
        await _unitOfWork.Commit();
    }
    
    public void Dispose()
    {
        _context?.Dispose();
    }

    
    public async Task AddCategory(Category category, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateCategory(Category category, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteCategory(Guid categoryId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Category>> GetCategories(CancellationToken cancellationToken = default)
    {
        return await _categories.AsNoTracking().ToListAsync(cancellationToken);
    }

    public async Task<Category> GetCategoryById(Guid categoryId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}