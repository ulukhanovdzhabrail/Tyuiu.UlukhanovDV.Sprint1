using Tyuiu.UlukhanovDV.Sprint1.Task3.V5.Lib;
// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Улуханов Д. В. | СМАРТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложенияx                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Улуханов Джабраил Вагифович | СМАРТб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами,    *");
Console.WriteLine("* изображенными на карте.                                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
double mapScale = 120.0;
double distanceBetweenPoints = 3.5;

Console.WriteLine("Введите значение масштаба карты:" + mapScale);
Console.WriteLine("Введите значение расстояния между точками, изображающими населенные пункты (см):" +  distanceBetweenPoints);
Console.WriteLine("*********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                            *");
Console.WriteLine("*********************************************************");
Console.WriteLine("Расстояние между населенными пунктами = " + ds.DistanceLength(mapScale, distanceBetweenPoints) + "км");
Console.ReadKey();