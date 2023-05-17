using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW_11
{
    internal class CarCollection
    {
        //Додавання машин (навза машини та рік її випуску)
        //Індексатор
        //Властивість тільки для читання для отриманя загальної кількості елементів
        //Видалення всіх машин з автопарку
        public int Count { get; set; }
        List<Car> carPark = new List<Car>();
        public void Add(string nameOfCar, int numberOfCar)
        {
            Car car = new Car(nameOfCar, numberOfCar);
            carPark.Add(car);
            Count++;
        }
        public Car this[int index]
        {
            get
            {
                return carPark[index];
            }
        }
        public void CountCars()
        {
            Count = carPark.Count;
            Console.WriteLine(carPark.Count); 
        }
        public void DeleteAll()
        {
            carPark.Clear();
        }

        public void Show()
        {
            foreach(Car car in carPark)
            {
                Console.WriteLine(car);
            }
        }

    }
}
