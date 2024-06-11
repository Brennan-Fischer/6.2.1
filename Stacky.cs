using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._1
{
    internal class Stacky
    {
        int Pointer {  get; set; }
        int[] Value { get; set; }
        int Size { get; set; }
        public Stacky(int size) 
        {
            Pointer = 0;
            Size = size;
            Value = new int[size];
        }
        public void Push(int newValue)
        {
            if(Pointer==Size)
            {
                Console.WriteLine("Stack is full. Must pop prior to adding more values");
                return;
            }
            Value[Pointer++] = newValue;
            return;
        }
        public int Pop()
        {
            int var = Value[Pointer - 1];
            Pointer--;
            return var;
        }
        public void Print()
        {
            if(Pointer==0) 
            {
                Console.WriteLine("No Values in Array");
                return;
            }
            for(int i = 0; i < Pointer; i++)
            {
                Console.WriteLine(Value[i]);
            }
            return;
        }


    }
}
