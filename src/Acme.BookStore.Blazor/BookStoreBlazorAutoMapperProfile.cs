using Acme.BookStore.Books;
using Acme.BookStore.Province;
using AutoMapper;

namespace Acme.BookStore.Blazor;

public class BookStoreBlazorAutoMapperProfile : Profile
{
    public BookStoreBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<ProvincesDto, CreateUpdateProvincesDto>();
    }
}
