using Acme.BookStore.Province;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Province;

public interface IProvinceAppService :
    ICrudAppService< //Defines CRUD methods
        ProvincesDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateProvincesDto> //Used to create/update a book
{

}