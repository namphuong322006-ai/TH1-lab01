
using System;

namespace TH1_lab01
{
    internal class Nhiemvu211
    {
        static string MaHoa(string text, int key)
        {
            string result = "";
            key = key % 26;

            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    char newChar = (char)((c - 'A' + key) % 26 + 'A');
                    result += newChar;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    char newChar = (char)((c - 'a' + key) % 26 + 'a');
                    result += newChar;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        static string GiaiMa(string text, int key)
        {
            string result = "";
            key = key % 26;

            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    char newChar = (char)((c - 'A' - key + 26) % 26 + 'A');
                    result += newChar;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    char newChar = (char)((c - 'a' - key + 26) % 26 + 'a');
                    result += newChar;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        static void BruteForce(string cipherText)
        {
            for (int key = 0; key < 26; key++)
            {
                string plaintext = GiaiMa(cipherText, key);

                Console.WriteLine("\nKey = " + key);
                Console.WriteLine(plaintext);
            }

            Console.WriteLine("\nBan ro voi key = 19:");
            Console.WriteLine(GiaiMa(cipherText, 19));
        }

        static void Main(string[] args)
        {
            int choice;

            do
            {
                
                Console.Write("Nhap lua chon: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1;
                }

                if (choice == 1)
                {
                    Console.Write("Nhap khoa K: ");
                    if (!int.TryParse(Console.ReadLine(), out int key))
                    {
                        Console.WriteLine("Khoa khong hop le!");
                        continue;
                    }

                    Console.Write("Nhap chuoi can ma hoa: ");
                    string text = Console.ReadLine() ?? "";

                    Console.WriteLine("Ban ma: " + MaHoa(text, key));
                }
                else if (choice == 2)
                {
                    Console.Write("Nhap khoa K: ");
                    if (!int.TryParse(Console.ReadLine(), out int key))
                    {
                        Console.WriteLine("Khoa khong hop le!");
                        continue;
                    }

                    Console.Write("Nhap chuoi can giai ma: ");
                    string text = Console.ReadLine() ?? "";

                    Console.WriteLine("Ban ro: " + GiaiMa(text, key));
                }
                else if (choice == 3)
                {
                    Console.Write("Nhap ciphertext: ");
                    string cipherText = Console.ReadLine() ?? "";

                    BruteForce(cipherText);
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Ket thuc chuong trinh.");
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le!");
                }

            } while (choice != 0);
        }
    }
}