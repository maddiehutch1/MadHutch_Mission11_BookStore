using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MadHutch_Mission11_BookStore.Models;

public partial class Book
{
    [Key]
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string Classification { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int PageCount { get; set; }

    public double Price { get; set; }
}
