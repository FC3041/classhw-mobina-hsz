// using System;
// using System.Threading;

// class Program
// {
//     static object lockObject = new object();
//     public static int money = 1000;

//     static void Main()
//     {
//         Thread thread1 = new Thread(SimpleBank);
//         Thread thread2 = new Thread(SimpleBank);

//         thread1.Start();
//         thread2.Start();

//         thread1.Join();
//         thread2.Join();
//     }

//     public static void SimpleBank()
//     {
//         while ( true )
//         {
//             lock (lockObject)
//             {
//                 money -= 10;
//                 if (money < 0) break; 
//                 Thread.Sleep(1);
//                 Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {money}");
//             }
//         }
//     }

//     static void Countdown()
//     {
//         for (int i = 10; i >= 1; i--)
//         {
//             lock (lockObject)
//             {
//                 Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
//                 Thread.Sleep(100); // شبیه‌سازی کار زمان‌بر
//             }
//         }
//     }

// }