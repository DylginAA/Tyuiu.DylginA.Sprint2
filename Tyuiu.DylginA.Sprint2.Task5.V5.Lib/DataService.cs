﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DylginA.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string res;
            switch (value)
            {
                case 6:
                    res = "Шестерка";
                    break;

                case 7:
                    res = "Семерка";
                    break;

                case 8:
                    res = "Восьмерка";
                    break;
                case 9:
                    res = "Девятка";
                    break;
                case 10:
                    res = "Десятка";
                    break;
                case 11:
                    res = "Валет";
                    break;
                case 12:
                    res = "Дама";
                    break;
                case 13:
                    res = "Король";
                    break;
                case 14:
                    res = "Туз";
                    break;


                default:
                   res =  "Число не входит в диапазон от 6 до 14";
                    break;
            }
            return res;
        }
    }
}
