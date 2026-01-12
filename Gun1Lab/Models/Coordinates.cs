// ------------------------------------------
// Dosya: Models/Coordinates.cs
// ------------------------------------------
using System;

namespace Week4.Gun1Lab.Models
{
    /// <summary>
    /// Bir noktanin X ve Y koordinatlarini tutan hafif yapi (Struct).
    /// Value Type oldugu icin Stack'te tutulur.
    /// </summary>
    public struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"Struct {X},{Y}";
    }

    /// <summary>
    /// Koordinatlari tutan Sinif
    /// /// Reference Type oldugu icin Heapte yasar
    /// </summary>
    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"Struct {X},{Y}";
    }
}
