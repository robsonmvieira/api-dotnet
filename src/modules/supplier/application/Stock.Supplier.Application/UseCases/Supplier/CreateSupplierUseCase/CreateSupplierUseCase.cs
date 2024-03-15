using MediatR;
using Stock.Core.Application.UOW;
using Stock.Core.Entities;
using Stock.Supplier.Application.Mappers.Supplier;
using Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase.Dtos;
using Stock.Supplier.Domain.Repositories;
using Stock.Supplier.Domain.Validations;

namespace Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase;

public class CreateSupplierUseCase: BaseValidation,  IRequestHandler<CreateSupplierDto, SupplierOutput>
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IUnitOfWork _unitOfWork;
    

    public CreateSupplierUseCase(ISupplierRepository supplierRepository, IUnitOfWork unitOfWork, INotificatorService notificatorService): base(notificatorService)
    {
        _supplierRepository = supplierRepository;
        _unitOfWork = unitOfWork;
    }


    public async Task<SupplierOutput> Handle(CreateSupplierDto request, CancellationToken cancellationToken)
    {

        var newSupplier = SupplierMapper.MapToDomain(request);

        if (!ExecuteValidation(new SupplierValidation(), newSupplier)) return null;
        
        
        await _supplierRepository.Insert(newSupplier, cancellationToken);
        await _unitOfWork.Commit(cancellationToken);
        return SupplierMapper.MapToOutput(newSupplier);
    }
}