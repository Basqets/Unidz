using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard : MonoBehaviour
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
        int j = 0;
        string decode = "";

        int[,] indx = new int[message.Length, 2];

        int count = 0;

        for (int i = 0; i < message.Length; i++)
        {
            bool isDigit = char.IsDigit(message[i]);
            if (isDigit)
            {
                indx[j,0] = i + 1;
                indx[j + 1,0] = message.Length + 1;
                indx[j, 1] = message[i];

                count++;
                j++;
            }
        }
        string[,] words = new string[count, 2];
        for (int i = 0; i < count; i++)
        {
            words[i, 0] = message.Substring(indx[i,0], indx[i + 1,0] - indx[i,0] - 1);
            words[i, 1] = indx[i, 1].ToString();
        }
        string[,] temp = new string[1, 2];
        for (int i = 0; i < count - 1; i++)
        {
            for (int l = i + 1; l < count; l++)
            {
                if (int.Parse(words[i, 1]) > int.Parse(words[l, 1]))
                {
                    temp[0, 0] = words[i, 0];
                    temp[0, 1] = words[i, 1];

                    words[i, 0] = words[l, 0];
                    words[i, 1] = words[l, 1];

                    words[l, 0] = temp[0, 0];
                    words[l, 1] = temp[0, 1];
                }
            }
        }
        for (int i = 0; i < count; i++)
        {
            decode += words[i, 0] + " ";
        }

        return decode;
    }
}
