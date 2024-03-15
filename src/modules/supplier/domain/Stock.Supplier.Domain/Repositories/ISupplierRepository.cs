using Stock.Supplier.Domain.Entities;

namespace Stock.Supplier.Domain.Repositories;

public interface ISupplierRepository
{
    Task Insert(Entities.Supplier supplier, CancellationToken cancellationToken = default);
    
    Task Update(Entities.Supplier entity, CancellationToken cancellationToken = default);
    
    Task Delete(Guid entity, CancellationToken cancellationToken = default);
    
    Task<Entities.Supplier> GetById(Guid id, CancellationToken cancellationToken = default);
    
    Task<IEnumerable<Entities.Supplier>> GetAll(CancellationToken cancellationToken = default);
    
    Task  AddAddress(Address address, CancellationToken cancellationToken = default);
   
    Task UpdateAddress(Address address, CancellationToken cancellationToken = default);
   
    Task AddProduct(Product product, CancellationToken cancellationToken = default);
   
    Task UpdateProduct(Product product, CancellationToken cancellationToken = default);
   
    Task DeleteProduct(Guid productId, CancellationToken cancellationToken = default);
   
    Task AddCategory(Category category, CancellationToken cancellationToken = default);
   
    Task UpdateCategory(Category category, CancellationToken cancellationToken = default);
   
    Task DeleteCategory(Guid categoryId, CancellationToken cancellationToken = default);
   
    Task<IEnumerable<Category>> GetCategories(CancellationToken cancellationToken = default);
   
    Task<Category> GetCategoryById(Guid categoryId, CancellationToken cancellationToken = default);
   
   
}