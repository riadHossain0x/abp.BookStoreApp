using AutoMapper;
using BookStoreApp.Books;

namespace BookStoreApp;

public class BookStoreAppApplicationAutoMapperProfile : Profile
{
    public BookStoreAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
    }
}
