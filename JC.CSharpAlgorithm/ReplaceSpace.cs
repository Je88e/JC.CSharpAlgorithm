using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JC.CSharpAlgorithm
{
    //https://www.cnblogs.com/edisonchou/p/4738106.html
    public static class ReplaceSpace
    {
        public static string Replace1()
        {
            const int length = 100;
            char[] target = new char[length];
            for (int i = 0; i < length; i++)
            {
                target[i] = '\0';
            }
            target[0] = 'H';
            target[1] = 'o';
            target[2] = 'w';
            target[3] = ' ';
            target[4] = 'A';
            target[5] = 'r';
            target[6] = 'e';
            target[7] = ' ';
            target[8] = 'Y';
            target[9] = 'o';
            target[10] = 'u';
            target[11] = '?';

            ReplaceBlank(target, length);

            char[] newTarget = GenerateNewTarget(target);

            return new string(newTarget);
        }

        public static string Replace2(string text)
        {
            ArgumentNullException.ThrowIfNull(text, "text");
            string result = string.Empty;
            char[] chars = text.ToCharArray();

            int spaceCount = 0;
            int i = chars.Length - 1; 
            int tailIndex = i;
            List<string> strings = new List<string>();
            while (i > 0)
            {
                if (chars[i] == ' ')
                { 
                    strings.Add(text.Substring(i + 1, tailIndex - i - strings.Count));
                    tailIndex = i;
                }
                i--;
            }
            strings.Add(text.Substring(0, tailIndex)); 
            return string.Join("%20", strings.ToArray().Reverse());
        } 
        
        public static string Replace3(string text)
        { 
            return text.Replace(" ", "%20");
        }

        public static char[] GenerateNewTarget(char[] target)
        {
            int length = 0;
            for (int i = 0; i < 100 && target[i] != '\0'; i++)
            {
                length++;
            }

            char[] newTarget = new char[length];

            for (int i = 0; i < 100 && target[i] != '\0'; i++)
            {
                newTarget[i] = target[i];
            }

            return newTarget;
        }

        public static void ReplaceBlank(char[] target, int maxLength)
        {
            if (target == null || maxLength <= 0)
            {
                return;
            }

            // originalLength 为字符串target的实际长度
            int originalLength = 0;
            int blankCount = 0;
            int i = 0;

            while (target[i] != '\0')
            {
                originalLength++;
                // 计算空格数量
                if (target[i] == ' ')
                {
                    blankCount++;
                }
                i++;
            }

            // newLength 为把空格替换成'%20'之后的长度
            int newLength = originalLength + 2 * blankCount;
            if (newLength > maxLength)
            {
                return;
            }

            // 设置两个指针，一个指向原始字符串的末尾，另一个指向替换之后的字符串的末尾
            int indexOfOriginal = originalLength;
            int indexOfNew = newLength;

            while (indexOfOriginal >= 0 && indexOfNew >= 0)
            {
                if (target[indexOfOriginal] == ' ')
                {
                    target[indexOfNew--] = '0';
                    target[indexOfNew--] = '2';
                    target[indexOfNew--] = '%';
                }
                else
                {
                    target[indexOfNew--] = target[indexOfOriginal];
                }

                indexOfOriginal--;
            }
        }
    }
}
