using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptWebSyte.Models
{
    public class PropertyEncrypt
    {
        [Required(ErrorMessage = "Поле для ввода ключа шифрования не заполнено")]
        public string InputEncryptKey { get; set; }
        [Required(ErrorMessage = "Поле для ввода текста не заполнено")]
        public string InputText { get; set; }
        public string DescryptKey { get; set; }
        public string ResultText { get; set; }

        private const int sizeOfBlock = 128; //в DES размер блока 64 бит, но поскольку в unicode символ в два раза длинее, то увеличим блок тоже в два раза
        
        private const int sizeOfChar = 16; //размер одного символа (in Unicode 16 bit)

        private const int shiftKey = 2; //сдвиг ключа 

        private const int quantityOfRounds = 16; //количество раундов

        string[] Blocks; //сами блоки в двоичном формате

        public PropertyEncrypt(string InputText, string InputEncryptKey)
        {
            this.InputText = InputText;
            this.InputEncryptKey = InputEncryptKey;
        }

        public void StartEncrypt()
        {
            InputText = StringToRightLength(InputText);
            CutStringIntoBlocks(InputText);
            InputEncryptKey = CorrectKeyWord(InputEncryptKey, InputText.Length / (2 * Blocks.Length));
            DescryptKey = StringToBinaryFormat(InputEncryptKey);

            for (int j = 0; j < quantityOfRounds; j++)
            {
                for (int i = 0; i < Blocks.Length; i++)
                    Blocks[i] = EncodeDES_One_Round(Blocks[i], DescryptKey);

                DescryptKey = KeyToNextRound(DescryptKey);
            }

            DescryptKey = KeyToPrevRound(DescryptKey);

            DescryptKey = StringFromBinaryToNormalFormat(DescryptKey);

            string result = "";

            for (int i = 0; i < Blocks.Length; i++)
                result += Blocks[i];
            InputText = InputText.Replace("|","");
            InputEncryptKey = InputEncryptKey.Replace("|", "");
            ResultText = StringFromBinaryToNormalFormat(result);
        }

        //доводим строку до размера, чтобы делилась на sizeOfBlock
        private string StringToRightLength(string InputText)
        {
            while (((InputText.Length * sizeOfChar) % sizeOfBlock) != 0)
                InputText += "|";

            return InputText;
        }

        //разбиение обычной строки на блоки
        private void CutStringIntoBlocks(string InputText)
        {
            Blocks = new string[(InputText.Length * sizeOfChar) / sizeOfBlock];

            int lengthOfBlock = InputText.Length / Blocks.Length;

            for (int i = 0; i < Blocks.Length; i++)
            {
                Blocks[i] = InputText.Substring(i * lengthOfBlock, lengthOfBlock);
                Blocks[i] = StringToBinaryFormat(Blocks[i]);
            }
        }

        //перевод строки в двоичный формат
        private string StringToBinaryFormat(string InputText)
        {
            string output = "";

            for (int i = 0; i < InputText.Length; i++)
            {
                string char_binary = Convert.ToString(InputText[i], 2);
                while (char_binary.Length < sizeOfChar)
                    char_binary = "0" + char_binary;

                output = output + char_binary;
            }

            return output;
        }

        //доводим длину ключа до нужной
        private string CorrectKeyWord(string InputEncryptKey, int LengthKey)
        {
            if (InputEncryptKey.Length > LengthKey)
                InputEncryptKey = InputEncryptKey.Substring(0, LengthKey);
            else
                while (InputEncryptKey.Length < LengthKey)
                    InputEncryptKey = "|" + InputEncryptKey;

            return InputEncryptKey;
        }

        //шифрование DES один раунд
        private string EncodeDES_One_Round(string InputText, string KeyEncode)
        {
            string L = InputText.Substring(0, InputText.Length / 2);
            string R = InputText.Substring(InputText.Length / 2, InputText.Length / 2);

            return (R + XOR(L, EncryptFunction(R, KeyEncode)));
        }

        //XOR двух строк с двоичными данными
        private string XOR(string s1, string s2)
        {
            string result = "";

            for (int i = 0; i < s1.Length; i++)
            {
                bool a = Convert.ToBoolean(Convert.ToInt32(s1[i].ToString()));
                bool b = Convert.ToBoolean(Convert.ToInt32(s2[i].ToString()));

                if (a ^ b)
                    result += "1";
                else
                    result += "0";
            }
            return result;
        }

        //шифрующая функция EncryptFunction. в данном случае это XOR
        private string EncryptFunction(string s1, string s2)
        {
            return XOR(s1, s2);
        }

        //вычисление ключа для следующего раунда шифрования. циклический сдвиг >> 2
        private string KeyToNextRound(string Key)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                Key = Key[Key.Length - 1] + Key;
                Key = Key.Remove(Key.Length - 1);
            }

            return Key;
        }

        //вычисление ключа для следующего раунда расшифровки. циклический сдвиг << 2
        private string KeyToPrevRound(string KeyDecode)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                KeyDecode = KeyDecode + KeyDecode[0];
                KeyDecode = KeyDecode.Remove(0, 1);
            }

            return KeyDecode;
        }

        //переводим строку с двоичными данными в символьный формат
        private string StringFromBinaryToNormalFormat(string input)
        {
            string output = "";

            while (input.Length > 0)
            {
                string char_binary = input.Substring(0, sizeOfChar);
                input = input.Remove(0, sizeOfChar);

                int a = 0;
                int degree = char_binary.Length - 1;

                foreach (char c in char_binary)
                    a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);

                output += ((char)a).ToString();
            }

            // Удалить нули из результат (последние символы в блоке)
            // string ResultText = output.Substring(output%).Replace()

            return output;
        }
    }
}
