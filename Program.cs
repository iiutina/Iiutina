﻿
/*Задача. Написать программу, которая из имеющего массива строк формирует массив из строк,
 длина которых меньше либо равно 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
 выполнения алгоритма.
 */
 
   string [] array={"hello","2","world",":-)"};
   string [] array01= new string[array.Length];

        for (int i=0;i< array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            array01[i]=array[i];
           
        }

       Console.Write ( array01[i] + " ");   
    }
        
   


    


