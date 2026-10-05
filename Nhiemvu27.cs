using System;

namespace TH1_lab01
{
    internal class Nhiemvu27
    {
        static string MaHoa(string plaintext, int rails)
        {
            if (rails <= 1)
                return plaintext;

            string[] rows = new string[rails];

            for (int i = 0; i < rails; i++)
                rows[i] = "";

            int row = 0;
            int direction = 1;

            foreach (char c in plaintext)
            {
                rows[row] += c;

                if (row == 0)
                    direction = 1;
                else if (row == rails - 1)
                    direction = -1;

                row += direction;
            }

            string ciphertext = "";

            for (int i = 0; i < rails; i++)
                ciphertext += rows[i];

            return ciphertext;
        }

        static string GiaiMa(string ciphertext, int rails)
        {
            if (rails <= 1)
                return ciphertext;

            int length = ciphertext.Length;

            char[,] matrix = new char[rails, length];

            int row = 0;
            int direction = 1;

            for (int i = 0; i < length; i++)
            {
                matrix[row, i] = '*';

                if (row == 0)
                    direction = 1;
                else if (row == rails - 1)
                    direction = -1;

                row += direction;
            }

            int index = 0;

            for (int i = 0; i < rails; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (matrix[i, j] == '*' && index < length)
                    {
                        matrix[i, j] = ciphertext[index];
                        index++;
                    }
                }
            }

            string plaintext = "";

            row = 0;
            direction = 1;

            for (int i = 0; i < length; i++)
            {
                plaintext += matrix[row, i];

                if (row == 0)
                    direction = 1;
                else if (row == rails - 1)
                    direction = -1;

                row += direction;
            }

            return plaintext;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine();

            Console.Write("Nhap lua chon (1-Ma hoa, 2-Giai ma): ");
            string choice = Console.ReadLine() ?? "";

            Console.Write("Nhap so hang: ");
            int rails = int.Parse(Console.ReadLine() ?? "3");

            if (choice == "1")
            {
                Console.Write("Nhap ban ro: ");
                string plaintext = Console.ReadLine() ?? "";

                string ciphertext = MaHoa(plaintext, rails);

                Console.WriteLine("\nBan ro: " + plaintext);
                Console.WriteLine("So hang: " + rails);
                Console.WriteLine("Ban ma: " + ciphertext);
            }
            else if (choice == "2")
            {
                Console.Write("Nhap ciphertext: ");
                string ciphertext = Console.ReadLine() ?? "";

                string plaintext = GiaiMa(ciphertext, rails);

                Console.WriteLine("\nCiphertext: " + ciphertext);
                Console.WriteLine("So hang: " + rails);
                Console.WriteLine("Ban ro: " + plaintext);
            }
            else
            {
                Console.WriteLine("\nLua chon khong hop le!");
            }

            Console.ReadKey();
        }
    }
}