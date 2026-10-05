using System;

namespace TH1_lab01
{
    internal class Nhiemvu212
    {
        static void Main(string[] args)
        {
            string ciphertext = "Max NBM bl t extwbgz bglmbmnmbhg ngwxk OGN-AVF, lixvblebsbgz bg max ybxew hy bgyhkftmbhg mxvaghehzr. Xlmtueblaxw pbma t fbllbhg mh yhlmxk bgghotmbhg tgw xqvxeexgvx bg BM xwnvtmbhg tgw kxlxtkva, NBM hyyxkl t pbwx ktgzx hy ngwxkzktwntmx tgw ihlmzktwntmx ikhzktfl tbfxw tm ikhwnvbgz abzaer ldbeexw ikhyxllbhgtel. Max ngboxklbmr bl kxvhzgbsxw yhk bml vnmmbgz-xwzx kxlxtkva bg tkxtl ebdx vruxklxvnkbmr, tkmbybvbte bgmxeebzxgvx, tgw lhymptkx xgzbgxxkbgz. Pbma lmtmx-hy-max-tkm ytvbebmbl tgw t lmkhgz xfiatlbl hg vheetuhktmbhg pbma bgwnlmkr, NBM xjnbil lmnwxgml pbma uhma maxhkxmbvte dghpexwzx tgw iktvmbvte ldbeel mh makbox bg max ktibwer xoheobgz mxva bgwnlmkr.";

            for (int key = 1; key <= 25; key++)
            {
                string plaintext = Decrypt(ciphertext, key);

                string lowerPlaintext = plaintext.ToLower();

                if (lowerPlaintext.Contains(" the ") &&
                    lowerPlaintext.Contains(" and "))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(plaintext);
                    Console.ResetColor();

                    Console.WriteLine("\nKey = " + key);
                    break;
                }
            }

            Console.ReadKey();
        }

        static string Decrypt(string cipherText, int key)
        {
            char[] buffer = cipherText.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';

                    buffer[i] = (char)((((letter - offset) - key + 26) % 26) + offset);
                }
            }

            return new string(buffer);
        }
    }
}