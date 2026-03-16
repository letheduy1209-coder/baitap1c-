using System;
using System.Collections.Generic;
using System.Linq;

// Bài 1 – Class Product
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        // Bài 2 – Danh sách sản phẩm
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Laptop", Price=1500, Category="Electronics"},
            new Product{Id=2, Name="Mouse", Price=200, Category="Electronics"},
            new Product{Id=3, Name="Keyboard", Price=300, Category="Electronics"},
            new Product{Id=4, Name="Phone", Price=800, Category="Electronics"},
            new Product{Id=5, Name="Table", Price=600, Category="Furniture"},
            new Product{Id=6, Name="Chair", Price=400, Category="Furniture"}
        };

        // Bài 3 – LINQ

        // 1. Lấy sản phẩm giá > 500
        var giaLonHon500 = products.Where(p => p.Price > 500);
        Console.WriteLine("San pham gia > 500:");
        foreach (var p in giaLonHon500)
        {
            Console.WriteLine($"{p.Name} - {p.Price}");
        }

        // 2. Sắp xếp theo Price tăng dần
        var sapXep = products.OrderBy(p => p.Price);
        Console.WriteLine("\nSap xep theo gia tang dan:");
        foreach (var p in sapXep)
        {
            Console.WriteLine($"{p.Name} - {p.Price}");
        }

        // 3. Lấy 3 sản phẩm rẻ nhất
        var reNhat = products.OrderBy(p => p.Price).Take(3);
        Console.WriteLine("\n3 san pham re nhat:");
        foreach (var p in reNhat)
        {
            Console.WriteLine($"{p.Name} - {p.Price}");
        }

        // 4. Tìm sản phẩm theo tên nhập từ bàn phím
        Console.WriteLine("\nNhap ten san pham can tim:");
        string keyword = Console.ReadLine();

        var timKiem = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));

        Console.WriteLine("Ket qua tim kiem:");
        foreach (var p in timKiem)
        {
            Console.WriteLine($"{p.Name} - {p.Price}");
        }

        // Bài 4 – Thống kê

        // Tổng giá trị sản phẩm
        double tongGia = products.Sum(p => p.Price);

        // Giá trung bình
        double giaTB = products.Average(p => p.Price);

        Console.WriteLine("\nTong gia tri san pham: " + tongGia);
        Console.WriteLine("Gia trung binh: " + giaTB);
    }
}