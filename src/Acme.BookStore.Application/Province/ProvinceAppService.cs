using Acme.BookStore.Province;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class ProvinceAppService :
    CrudAppService<
        Provinces, //The Book entity
        ProvincesDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateProvincesDto>, //Used to create/update a book
    IProvinceAppService //implement the IBookAppService
{
    public ProvinceAppService(IRepository<Provinces, Guid> repository)
        : base(repository)
    {

    }
}