using System;
using System.Collections.Generic;

public class Program
{

    public static void HienThiKieu<T>(T input)
    {
        // typeof(T) hoặc input.GetType() dùng để lấy tên kiểu dữ liệu
        Console.WriteLine($"Gia tri: {input} | Kieu du lieu la: {typeof(T).Name}");
    }

    public static void Main()
    {
        // 1. Thử với kiểu int (số nguyên)
        HienThiKieu(100);

        // 2. Thử với kiểu double (số thực)
        HienThiKieu(15.5);

        // 3. Thử với kiểu string (chuỗi)
        HienThiKieu("Chào bạn!");

        // 4. Thử với kiểu Object (Lớp Student như trên bảng)
        Student sv = new Student { Name = "Nguyen Van A" };
        HienThiKieu(sv);
    }
}

// Lớp Student để minh họa cho phần "obj -> class Student" trên bảng
public class Student
{
    public string Name { get; set; }
    public override string ToString() => Name; // Để hiển thị tên khi in ra
}