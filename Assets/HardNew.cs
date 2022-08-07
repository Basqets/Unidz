using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardNew : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Decode("2like1I4games3play"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Decode(string message)
    {
        string[] words = message.Split("0123456789".ToCharArray());
        string a = string.Join(" ", words).Trim().Replace("  ", " ");
        words = a.Split(new char[] { ' ' });
        char[] chars = message.ToCharArray();
        int[] digits = new int[words.Length];
        int p = 0;
        string decode = "";

        for (int i = 0; i < chars.Length; i++)
        {

            if (char.IsDigit(chars[i]))
            {
                if (i != 0)
                {
                    if (char.IsDigit(chars[i - 1]))
                    {
                        string num = int.Parse(chars[i - 1].ToString()).ToString() + int.Parse(chars[i].ToString()).ToString();

                        digits[p] = int.Parse(num);
                        p++;

                    }
                    else if (!char.IsDigit(chars[i + 1]))
                    {
                        digits[p] = int.Parse(chars[i].ToString());
                        p++;
                    }
                }
                else
                {
                    digits[p] = int.Parse(chars[i].ToString());
                    p++;
                }
            }
        }
        int temp;
        string tempWord;

        for (int i = 0; i < digits.Length - 1; i++)
        {
            for (int j = i + 1; j < digits.Length; j++)
            {
                if (digits[i] > digits[j])
                {
                    temp = digits[i];
                    tempWord = words[i];

                    digits[i] = digits[j];
                    words[i] = words[j];

                    digits[j] = temp;
                    words[j] = tempWord;
                }
            }
        }
        decode = string.Join(" ", words);
        return decode;
    }
}
