using System;
using System.Collections.Generic;

namespace Demo_Factories_Pattern
{
    
    public interface IAnimal
    {
        void AboutMe(); // mô tả thông tin của đối tượng động vật
    }

   
    public class Lion : IAnimal
    {
        public void AboutMe() => Console.WriteLine("This is Lion."); // hiển thị thông tin Lion
    }

    public class Tiger : IAnimal
    {
        public void AboutMe() => Console.WriteLine("This is Tiger."); // hiển thị thông tin Tiger
    }

    
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal(); //tạo ra một đối tượng
    }

    // triển khai AnimalFactory tạo ra các đối tượng lion
    public class LionFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Lion(); // Tạo và trả về một đối tượng mới
    }

   
    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger(); 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo. ***\n");

            // tạo một danh sách AnimalFactory
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
            {
                new TigerFactory(), // thêm vào danh sách 
                new LionFactory()   
            };

            // duyệt từng animal và tạo ra mỗi cái một factory
            foreach (var animalFactory in animalFactoryList)
            {
                var animal = animalFactory.CreateAnimal(); // taooj ra một đối tượng Animal
                animal.AboutMe(); // hiển thị thong tin
            }

            Console.ReadLine();
        }
    }
}
