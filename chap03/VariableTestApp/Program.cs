﻿using System;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int v1 = 30, v2 = 40;
            int result = v1 + v2;
            Console.WriteLine("결과는" + result);*/
            sbyte sbMinVal = sbyte.MinValue;
            sbyte sbMaxVal = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소, 최대값은 {sbMinVal},{sbMaxVal} 입니다.");
            //byte
            byte bMinVal = byte.MinValue, bMaxVal = byte.MaxValue;
            Console.WriteLine($"byte 최소, 최대값은 {bMinVal},{bMaxVal} 입니다.");
            //short
            short shMinVal = short.MinValue,  shMaxval = short.MaxValue;
            Console.WriteLine($"short 최소, 최대값은 {shMinVal},{shMaxval} 입니다.");
            //ushort
            ushort usMinVal=ushort.MinValue, usMaxVal = ushort.MaxValue;
            Console.WriteLine($"usshort 최소, 최대값은 {usMinVal},{usMaxVal} 입니다.");
            //int
            int inMinVal = int.MinValue, inMaxVal = int.MaxValue;
            Console.WriteLine($"int 최소, 최대값은 {inMinVal},{inMaxVal} 입니다.");
            //long
            long lnMinVal = long.MinValue, lnMaxVal = long.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {lnMinVal},{lnMaxVal} 입니다.");
            //ulong
            ulong ulMinVal = ulong.MinValue, ulMaxVal = ulong.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {ulMinVal},{ulMaxVal} 입니다.");
        }
    }
}
