using Stock.Supplier.Application.useCases.Address.CreateAddressUseCase.Dtos;

namespace Stock.Supplier.Application.Mappers.Address;

public class AddressMapper
{
    public static Domain.Entities.Address MapToDomain(CreateAddressDto createAddressDto)
    {
        return Domain.Entities.Address.Create(
            createAddressDto.Street, 
            createAddressDto.Number, 
            createAddressDto.District,
            createAddressDto.City,
            createAddressDto.State,
            createAddressDto.Country,
            createAddressDto.ZipCode,
            createAddressDto.Complement
        );
    }
    
    public static AddressOutput MapToOutput(Domain.Entities.Address address)
    {
        return new AddressOutput(
            address.Id.ToString(),
            address.Street,
            address.Number,
            address.Complement,
            address.District,
            address.City,
            address.State,
            address.Country,
            address.ZipCode,
            address.CreatedAt ?? new DateTime(),
            address.UpdatedAt ?? null
        );
    }
}
