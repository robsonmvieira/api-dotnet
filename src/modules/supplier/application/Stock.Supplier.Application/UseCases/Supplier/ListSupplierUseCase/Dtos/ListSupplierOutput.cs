using Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase.Dtos;

namespace Stock.Supplier.Application.UseCases.Supplier.ListSupplierUseCase.Dtos;

public class ListSupplierOutput
{
    public List<SupplierOutput> Data { get; }
    
    public bool Error { get; }

    public DateTime CreatedAt { get; }


    public ListSupplierOutput(List<SupplierOutput> data, bool error)
    {
        Data = data;
        Error = error;
        CreatedAt = DateTime.Now;
    }
}

