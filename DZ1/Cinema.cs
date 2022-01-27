using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class Cinema
    {
        internal Ticket[,] TicketsArray { get; set; }
        internal int Rows { get; set; }
        internal int Seats { get; set; }
        internal List<User> UsersList { get; set; }

        internal Cinema(int rows, int seats, Ticket[,] ticketArr)
        {
            Rows = rows;
            Seats = seats;
            TicketsArray = ticketArr;
            UsersList = new List<User>() {new User("admin", "admin", true, 0)};
        }
        /*        internal void SetRowsNSeats()
                {
                    int _rows = 0;
                    int _seats = 0;
                    bool initCheckFlag = true;
                    while (initCheckFlag)
                    {
                        try
                        {
                            Console.WriteLine("Введите размер зала:");
                            string[] hallSize = Console.ReadLine().Split(' ');
                            _rows = int.Parse(hallSize[0]);
                            _seats = int.Parse(hallSize[1]);
                            if ((_rows & _seats) > 0)
                            {
                                initCheckFlag = false;
                            }
                            else
                            {
                                Console.WriteLine("Числа должны быть положительными! Попробуйте снова");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Неверный формат ввода! Попробуйте снова");
                        }
                    }
                    Rows = _rows;
                    Seats = _seats;
                }*/

        /*        internal void SetTicketsArray()
                {
                    Ticket[,] _ticketsArr = new Ticket[Rows, Seats];
                    bool initChekFlag = true;
                    while (initChekFlag)
                    {
                        try
                        {
                            Console.WriteLine("Введите стоимость билетов в зале:");
                            for (int i = 0; i < Rows; i++)
                            {
                                int[] rowPrices = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                                for (int j = 0; j < Seats; j++)
                                {
                                    if (rowPrices[j] > 0)
                                    {
                                        _ticketsArr[i, j] = new Ticket(rowPrices[j]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Числа должны быть положительными! Введите последню строку снова");
                                        j--;
                                    }
                                }
                            }
                            initChekFlag = false;
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Неверный формат ввода! Попробуйте снова");
                        }
                    }
                    TicketsArray = _ticketsArr;
                }*/
    }
}
