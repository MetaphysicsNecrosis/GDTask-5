using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_5
{
    class ToHashSetAndBack<template> 
    {
        static public List<template> ToHashSet(List<template> list) 
        {
            List<template> answer = new List<template>();
            for (var itter = list.Count - 1; itter >= 0; itter--) 
            {
                if (answer.Contains(list[itter])) 
                {
                    continue;
                }

                answer.Add(list[itter]);
            }
            answer.Reverse();
            return answer;
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            arr = ToHashSetAndBack<int>.ToHashSet(arr);
            for(int i = 0; i < arr.Count;i++) 
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
