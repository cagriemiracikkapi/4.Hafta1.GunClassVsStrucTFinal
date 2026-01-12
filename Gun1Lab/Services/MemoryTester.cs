// ------------------------------------------
// Dosya: Services/MemoryTester.cs
// ------------------------------------------
using System;
using Week4.Gun1Lab.Models;

namespace Week4.Gun1Lab.Services
{
    public class MemoryTester
    {
        /// <summary>
        /// Struct ve Class arasindaki kopyalama davranisini test eder
        /// </summary>
        public void RunTester()
        {
            Console.WriteLine($"--- Struct (Value Type) Davranisi");
            PointStruct ps1 = new PointStruct(10, 10);
            PointStruct ps2 = ps1; // Deger kopyalandi => ps2 yeni bir allocation.

            ps2.X = 999; // sadece ps2 degisir/
            Console.WriteLine($"PS1: {ps1} PS2: {ps2}");

            Console.WriteLine($"--- Class (Reference Type) Davranisi");
            PointClass pc1 = new PointClass(10, 10);
            PointClass pc2 = pc1; // pc2 adressi pc1 valuesini gosteriyor ayni adresse bakiyorlar

            pc2.X = 888; // pc1 ve pc2 degisir.

            Console.WriteLine($"PC1: {pc1} PC2: {pc2}");
        }
    }
}
