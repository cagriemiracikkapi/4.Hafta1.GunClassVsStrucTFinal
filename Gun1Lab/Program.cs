using System;
using ObjectLayoutInspector;
using Week4.Gun1Lab.Models;
using Week4.Gun1Lab.Services;

class Program
{
    static void Main()
    {
        // 1. Normal Struct/Class testleri
        Console.WriteLine("=== STRUCT vs CLASS DAVRANIŞI ===\n");
        MemoryTester memoryTester = new MemoryTester();
        memoryTester.RunTester();

        // 2. ObjectLayoutInspector ile bellek analizi
        Console.WriteLine("\n=== BELLEK DÜZENİ ANALİZİ ===\n");
        AnalyzeMemoryLayout();
    }

    static void AnalyzeMemoryLayout()
    {
        // PointStruct bellek düzeni
        Console.WriteLine("--- PointStruct Bellek Düzeni ---");
        TypeLayout.PrintLayout<PointStruct>();

        Console.WriteLine("\n--- PointClass Bellek Düzeni ---");
        TypeLayout.PrintLayout<PointClass>();

        // Padding örneği - KÖTÜ sıralama
        Console.WriteLine("\n--- BadPaddingStruct (Kötü Sıralama) ---");
        TypeLayout.PrintLayout<BadPaddingStruct>();

        // Padding örneği - İYİ sıralama
        Console.WriteLine("\n--- GoodPaddingStruct (İyi Sıralama) ---");
        TypeLayout.PrintLayout<GoodPaddingStruct>();
    }
}

// ❌ KÖTÜ: Field sıralaması yüzünden 7 byte PADDING (boşluk) var!
public struct BadPaddingStruct
{
    public byte A; // 1 byte
    public long B; // 8 byte (ama 8'e hizalanmalı, 7 byte padding!)
    public byte C; // 1 byte
    public int D; // 4 byte (ama 4'e hizalanmalı, 3 byte padding!)
    // Toplam: 1 + 7(padding) + 8 + 1 + 3(padding) + 4 = 24 byte!
}

// ✅ İYİ: Büyükten küçüğe sıralandı, minimum padding
public struct GoodPaddingStruct
{
    public long E;
    public long B; // 8 byte (ilk, hizalama yok)
    public int D; // 4 byte
    public byte A; // 1 byte
    public byte C; // 1 byte
    // Toplam: 8 + 4 + 1 + 1 + 2(padding) = 16 byte!
}
