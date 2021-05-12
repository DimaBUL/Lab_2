using System;
using System.Runtime.Serialization;

namespace Lab_2
{
    public class Shed : ICloneable, IComparable
    {
        public string Name { get; private set; }    //Властивості сараю
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Length { get; private set; }

        public Shed(string name, int width, int height, int length)  //Конструктор класу
        {
            Name = name;
            Width = width;
            Height = height;
            Length = length;
        }


        public void TypeAttrShed()   //Пише атрибути поточного об'єкту
        {
            Console.WriteLine("Name of shed : " + Name);
            Console.WriteLine("Width : " + Width);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("Length : " + Length);
        }
        
        //Метод який повертає розміри сараю(об'єм) за допомогою перемноження товщини, висоти, і довжини
        public int GetSize()
        {
            int size = Width * Height * Length;
            return size;
        }

        
        //Повертає імя сараю
        public string GetName()     
        {
            string name_shed = Name;
            return name_shed;
        }

        //Деякий розширювач розмірів сараю
        public void ExpandSize(int w, int h, int l)   //Метод в якості параметрів приймає значення на 
        {                                             //які ми хочемо розширити властивості
            Width += w;
            Height += h;
            Length += l;
        }

        public override bool Equals(object obj)   //Порівнює об'єкти за їх властивостями
        {
            if (!(obj is Shed shed)) return false;
            return shed.Name == Name && shed.Length == Length && shed.Height == Height && shed.Width == Width;
        }

        public override string ToString() => Name;   //Повертає рядок, який представляє поточний об'єкт

        public int CompareTo(object obj)      //Порівнює об'єкти за довжиною 
        {
            if (!(obj is Shed shed) || shed.Length == Length) return 0; //Виводить 0, якщо довж. 1го об'єкту рівна довж. 2го об'єкту
            if (shed.Length > Length)                                 //Виводить -1, якщо довж. 1го об'єкту більша за довж. 2го об'єкту
            {                                                          //Виводить 1 , якщо довж. 1го об'єкту більша за довж. 2го об'єкт
                return -1;
            }

            return 1;

        }

        public object Clone() => new Shed(Name, Width, Height, Length);    //Клонує, як в Наруто. 1й об'єкт копіює властивості 2го
    }
}