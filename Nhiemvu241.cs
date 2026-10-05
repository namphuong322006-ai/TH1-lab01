using System;

namespace TH1_lab01
{
    internal class Nhiemvu241 
    {
        static char[,] TaoMaTran(string key)
        {
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string chuoi = "";

            key = key.ToUpper();

            foreach (char c in key)
            {
                char x = c;

                if (x == 'J')
                    x = 'I';

                if (x >= 'A' && x <= 'Z' && !chuoi.Contains(x))
                    chuoi += x;
            }

            foreach (char c in alphabet)
            {
                if (!chuoi.Contains(c))
                    chuoi += c;
            }

            char[,] matrix = new char[5, 5];

            int index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = chuoi[index];
                    index++;
                }
            }

            return matrix;
        }

        static void HienThiMaTran(char[,] matrix)
        {
            Console.WriteLine("\nMa tran Playfair 5 x 5:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("| ");

                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " | ");
                }

                Console.WriteLine();
            }
        }

        static string ChuanBiVanBan(string text)
        {
            string result = "";

            text = text.ToUpper();

            foreach (char c in text)
            {
                char x = c;

                if (x == 'J')
                    x = 'I';

                if (x >= 'A' && x <= 'Z')
                    result += x;
            }

            return result;
        }

        static string TaoCapKyTu(string text)
        {
            string result = "";

            int i = 0;

            while (i < text.Length)
            {
                char a = text[i];

                if (i + 1 >= text.Length)
                {
                    result += a;
                    result += 'X';
                    i++;
                }
                else
                {
                    char b = text[i + 1];

                    if (a == b)
                    {
                        result += a;
                        result += 'X';
                        i++;
                    }
                    else
                    {
                        result += a;
                        result += b;
                        i += 2;
                    }
                }
            }

            return result;
        }

        static void TimViTri(char[,] matrix, char c, out int row, out int col)
        {
            if (c == 'J')
                c = 'I';

            row = -1;
            col = -1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == c)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }

        static string MaHoa(string plaintext, char[,] matrix)
        {
            plaintext = ChuanBiVanBan(plaintext);
            plaintext = TaoCapKyTu(plaintext);

            string ciphertext = "";

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                char a = plaintext[i];
                char b = plaintext[i + 1];

                TimViTri(matrix, a, out int rowA, out int colA);
                TimViTri(matrix, b, out int rowB, out int colB);

                if (rowA == rowB)
                {
                    ciphertext += matrix[rowA, (colA + 1) % 5];
                    ciphertext += matrix[rowB, (colB + 1) % 5];
                }
                else if (colA == colB)
                {
                    ciphertext += matrix[(rowA + 1) % 5, colA];
                    ciphertext += matrix[(rowB + 1) % 5, colB];
                }
                else
                {
                    ciphertext += matrix[rowA, colB];
                    ciphertext += matrix[rowB, colA];
                }
            }

            return ciphertext;
        }

        static string GiaiMa(string ciphertext, char[,] matrix)
        {
            ciphertext = ChuanBiVanBan(ciphertext);

            if (ciphertext.Length % 2 != 0)
                ciphertext += 'X';

            string plaintext = "";

            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                char a = ciphertext[i];
                char b = ciphertext[i + 1];

                TimViTri(matrix, a, out int rowA, out int colA);
                TimViTri(matrix, b, out int rowB, out int colB);

                if (rowA == rowB)
                {
                    plaintext += matrix[rowA, (colA + 4) % 5];
                    plaintext += matrix[rowB, (colB + 4) % 5];
                }
                else if (colA == colB)
                {
                    plaintext += matrix[(rowA + 4) % 5, colA];
                    plaintext += matrix[(rowB + 4) % 5, colB];
                }
                else
                {
                    plaintext += matrix[rowA, colB];
                    plaintext += matrix[rowB, colA];
                }
            }

            return plaintext;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine();

            Console.Write("Nhap lua chon (1-Ma hoa, 2-Giai ma): ");
            string choice = Console.ReadLine() ?? "";

            Console.Write("Nhap khoa: ");
            string key = Console.ReadLine() ?? "";

            char[,] matrix = TaoMaTran(key);

            HienThiMaTran(matrix);

            if (choice == "1")
            {
                Console.Write("\nNhap ban ro: ");
                string plaintext = Console.ReadLine() ?? "";

                string ciphertext = MaHoa(plaintext, matrix);

                Console.WriteLine("\nBan ro: " + plaintext);
                Console.WriteLine("Ban ma: " + ciphertext);
            }
            else if (choice == "2")
            {
                Console.Write("\nNhap ciphertext: ");
                string ciphertext = Console.ReadLine() ?? "";

                string plaintext = GiaiMa(ciphertext, matrix);

                Console.WriteLine("\nCiphertext: " + ciphertext);
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