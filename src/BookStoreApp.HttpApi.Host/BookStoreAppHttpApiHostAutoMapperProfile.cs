using AutoMapper;
using BookStoreApp.Books;

namespace BookStoreApp;

public class BookStoreAppHttpApiHostAutoMapperProfile : Profile
{
    public BookStoreAppHttpApiHostAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
    }
}
