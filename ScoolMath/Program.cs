using System;

namespace Answers
{
    public static class Program
    {
        public static void Main()
        {
            // Считываем числитель дроби.
            var numerator = Convert.ToInt32(Console.ReadLine());
            // Считываем знаменатель дроби.
            var denominator = Convert.ToInt32(Console.ReadLine());

            // Копируем значения числителя и знаменателя во временные переменные.
            var tempNumerator = numerator;
            var tempDenominator = denominator;

            // Используем алгоритм Евклида для нахождения НОД:
            // Пока числитель и знаменатель не равны нулю.
            while (tempNumerator != 0 && tempDenominator != 0)
            {
                // Если числитель больше знаменателя.
                if (tempNumerator > tempDenominator)
                {
                    // Числителю присваиваем значение, равное остатку от деления числителя на знаменатель.
                    tempNumerator %= tempDenominator;
                }
                else
                {
                    // Иначе, знаменателю присваиваем значение, равное остатку от деления знаменателя на числитель.
                    tempDenominator %= tempNumerator;
                }
            }

            // Вычисляем НОД.
            var greatestCommonDivisor = tempNumerator + tempDenominator;
            
            // Вычисляем новый числитель (после сокращения дроби).
            var newNumerator = numerator / greatestCommonDivisor;
            // Вычисляем новый знаменатель (после сокращения дроби).
            var newDenominator = denominator / greatestCommonDivisor;

            // Выводим новый числитель и знаменятель на экран.
            Console.WriteLine(newNumerator + " " + newDenominator);
        }
    }
}