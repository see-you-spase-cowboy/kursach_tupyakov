﻿using System;
using System.Collections.Generic;
using System.Text;

namespace kursach_tupyakov
{
    public class Test
    {
        private int power; //Проверять тест на доступность: 0 - недост., 1 - дост.
        private int count; //Кол-во вопросов
        private string[] question = new string[10]; //Вопросы в массиве
        private int[] type = new int[10]; //Тип ответов: 0 - поле ввода, 1 - выбор 1, 2 - выбор неск.
        private string[] ans = new string[10]; // Ответы в массиве

        //Конструктор ввода
        public Test(int count, string[] question, int[] type, string[] ans)
        {
            this.power = 1;
            this.count = count;
            this.question = question;
            this.type = type;
            this.ans = ans;
        }
        //Пустой конструктор
        public Test()
        {

        }
    }
}
