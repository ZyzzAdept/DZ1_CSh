using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = InitCinema();
            Console.WriteLine(cinema.Rows);

        }


        static (int, int) ReadHallSize()
        {
            int rows = 0;
            int seats = 0;
            while (true)
            {
                Console.WriteLine("Введите размер зала");
                try
                {
                    int[] rowsNSeats = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                    if (rowsNSeats[0] > 0 & rowsNSeats[1] > 0)
                    {
                        rows = rowsNSeats[0];
                        seats = rowsNSeats[1];
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат ввода! Поробуйте снова");
                }
            }
            return (rows, seats);
            

        }

        static Ticket[,] ReadPrices(int rows, int seats)
        {
            Ticket[,] _ticketsArr = new Ticket[rows, seats];
            bool initChekFlag = true;
            while (initChekFlag)
            {
                try
                {
                    Console.WriteLine("Введите стоимость билетов в зале:");
                    for (int i = 0; i < rows; i++)
                    {
                        int[] rowPrices = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                        for (int j = 0; j < seats; j++)
                        {
                            if (rowPrices[j] > 0)
                            {
                                _ticketsArr[i, j] = new Ticket(rowPrices[j]);
                            }
                            else
                            {
                                Console.WriteLine("Числа должны быть положительными! Введите последню строку снова");
                                i--;
                            }
                        }
                    }
                    initChekFlag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат ввода! Попробуйте снова");
                }
            }
            return _ticketsArr;
        }

        static Cinema InitCinema()
        {
            var (rows, seats) = ReadHallSize();
            Ticket[,] ticketArray = ReadPrices(rows, seats);
            Cinema _cinema = new Cinema(rows, seats, ticketArray);
            return _cinema;
        }

/*        static User Authorization(List<User> users)
        {
            while (true)
            {
                var (login, password) = GetUserInfo();
                foreach (User user in users)
                {
                    if (user.Name == login & user.Password == password)
                    {
                        User authorizatedUser = user;
                        return authorizatedUser;
                    }
                }
                Console.WriteLine("Пользователь не найден! Попробуйте снова");
                return null;
            }
        }

        static (string, string) GetUserInfo()
        {
            string login;
            string password;
            while (true)
                try
                {
                    Console.WriteLine("Введите логин и пароль:");
                    string loginNPassword = Console.ReadLine();
                    login = loginNPassword.Split(' ')[0];
                    password = loginNPassword.Split(' ')[1];
                    return (login, password);
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат ввода! Попробуйте снова");
                }
        }*/
    }
}
