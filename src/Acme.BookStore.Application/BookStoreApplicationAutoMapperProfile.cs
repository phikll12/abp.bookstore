
using Acme.BookStore.Books;
using Acme.BookStore.Province;
using AutoMapper;
using System.Diagnostics;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<Provinces, ProvincesDto>();
        CreateMap<CreateUpdateProvincesDto, Provinces>();
        CreateMap<Provinces, CreateUpdateProvincesDto>();
        //CreateMap<Author, AuthorDto>();
        //CreateMap<Author, AuthorLookupDto>();
    }   
}