using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CalcPerimeter(3, 7));
        Debug.Log(Delitel(4, 8));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float CalcPerimeter(int katetA, int katetB)
    {
        float hipotenyse = Mathf.Sqrt(katetA * katetA + katetB * katetB);

        float perimeter = katetA + katetB + hipotenyse;
        return perimeter;
    }

    bool Delitel(int x, int y)
    {
        if (y % x == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
