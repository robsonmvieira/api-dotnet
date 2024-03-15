using MediatR;
using Stock.Core.Entities;
using Stock.Supplier.Application.Mappers.Supplier;
using Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase.Dtos;
using Stock.Supplier.Application.UseCases.Supplier.ListSupplierUseCase.Dtos;
using Stock.Supplier.Domain.Repositories;

namespace Stock.Supplier.Application.UseCases.Supplier.ListSupplierUseCase;

public class ListSupplierUseCase: BaseValidation,  IRequestHandler<ListSupplierUseCaseDto, ListSupplierOutput>
{
    private readonly ISupplierRepository _supplierRepository;
    public ListSupplierUseCase(INotificatorService notificatorService, ISupplierRepository supplierRepository) : base(notificatorService)
    {
        _supplierRepository = supplierRepository;
    }

    public async Task<ListSupplierOutput> Handle(ListSupplierUseCaseDto request, CancellationToken cancellationToken)
    {
        var suppliers = await _supplierRepository.GetAll(cancellationToken);
        
        return new ListSupplierOutput(suppliers.Select(SupplierMapper.MapToOutput).ToList(), false);
    }
}