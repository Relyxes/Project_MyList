using System;
using System.Collections.Generic;

namespace Project_MyList
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //Создаем собственную коллекцию начальной емкостью в 2 элемента.
            MyList testList = new MyList(2);
            //Создаем собственную пустую коллекцию.
            MyList newMyList = new MyList();

            // Добавляем 2 элемента.
            testList.Add(123);
            testList.Add(345);

            // Добавляем 2 элемента.
            newMyList.Add(456);
            newMyList.Add(789);

            // Получаем количество элементов коллекции.
            Console.WriteLine("Количество элементов коллекции testList: {0}",testList.Count());
            Console.WriteLine("Количество элементов коллекции newMyList: {0}",newMyList.Count());

            //Выводим список элементов коллеции.
            Console.WriteLine("\nСписок элементов коллекции testList: ");
            testList.ShowMyList();
            Console.WriteLine("Список элементов коллекции newMyList: ");
            newMyList.ShowMyList();

            // Получаем индекс элемента из коллекции по имени.
            int index = testList.IndexOf(123);
            Console.WriteLine("\nИндекс элемента коллекции testList, по имени - {0}: {1}",123,index);

            // Удаляем элемент из коллекции по имени.
            testList.Remove(123);
            newMyList.Remove(789);

            Console.WriteLine("\nСписок элементов коллекции testList после удаления: ");
            testList.ShowMyList();
            Console.WriteLine("Список элементов коллекции newMyList после удаления: ");
            newMyList.ShowMyList();

            // Очищаем элементы коллекции.
            testList.Clear();
            Console.WriteLine("\nСписок элементов коллекции testList после очищения: ");
            testList.ShowMyList();

            Console.ReadLine();

        }
    }
}