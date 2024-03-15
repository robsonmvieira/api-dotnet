using Stock.Supplier.Application.Mappers.Address;
using Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase.Dtos;

namespace Stock.Supplier.Application.Mappers.Supplier;

public class SupplierMapper
{
   public static Domain.Entities.Supplier MapToDomain(CreateSupplierDto createSupplierDto)
    {
        return Domain.Entities.Supplier.Create(
            createSupplierDto.SupplierType,
            createSupplierDto.Name,
            createSupplierDto.Document,
            createSupplierDto.Email,
            AddressMapper.MapToDomain(createSupplierDto.Address),
            createSupplierDto.Phone,
            createSupplierDto.IsActive
        );
    }
   
   public static SupplierOutput MapToOutput(Domain.Entities.Supplier supplier)
   {
       return new SupplierOutput (
           supplier.Id.ToString(),
           supplier.Name, 
           supplier.Document, 
           supplier.Email.Value, 
           supplier.Phone, 
           AddressMapper.MapToOutput(supplier.Address), 
           supplier.SupplierType.ToString(), 
           supplier.IsActive, 
           supplier.CreatedAt?? new DateTime(), 
           supplier.UpdatedAt?? null);
       
   }
}
