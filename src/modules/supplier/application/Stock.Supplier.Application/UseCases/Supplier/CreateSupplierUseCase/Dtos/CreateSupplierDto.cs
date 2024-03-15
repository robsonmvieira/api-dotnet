using MediatR;
using Stock.Supplier.Application.useCases.Address.CreateAddressUseCase.Dtos;
using Stock.Supplier.Domain.Enums;

namespace Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase.Dtos;

public class CreateSupplierDto: IRequest<SupplierOutput>
{
    public string Name { get; set; }
    
    public string Document { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public CreateAddressDto Address { get; set; }
    
    public SupplierType SupplierType { get; set; }
    
    public bool? IsActive { get; set; }
    
    
    public CreateSupplierDto(string name, string document, string email, string phone, CreateAddressDto address, SupplierType supplierType)
    {
        Name = name;
        Document = document;
        Email = email;
        Phone = phone;
        Address = address;
        SupplierType = supplierType;
    }
}