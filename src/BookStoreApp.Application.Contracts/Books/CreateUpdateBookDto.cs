﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.Books;

public class CreateUpdateBookDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public BookType Type { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }

    [Required]
    public float Price { get; set; }
}
