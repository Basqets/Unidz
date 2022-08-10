using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CalcPerimeter(3, 7)); //1
        Debug.Log(Divider(4, 8));       //2
        Debug.Log(GetDay(8));           //3
        Debug.Log(PoundsToKg(170));     //4
        Debug.Log(KgToPounds(70));      //4
        MaxMin(3, 7);                   //5
        Debug.Log(YearToCentury(701));  //6
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

    bool Divider(int x, int y)
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

    DayWeek GetDay(int day)
    {
        switch (day)
        {
            case 1:
                return DayWeek.Monday;
            case 2:
                return DayWeek.Tuesday;
            case 3:
                return DayWeek.Wednesday;
            case 4:
                return DayWeek.Thursday;
            case 5:
                return DayWeek.Friday;
            case 6:
                return DayWeek.Saturday;
            case 7:
                return DayWeek.Sunday;
            default:
                return DayWeek.IncorrectInput;
        }
    }

    enum DayWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
        IncorrectInput
    }


    float PoundsToKg(float pounds)
    {
        float kg = pounds * 453 / 1000;
        return kg;
    }

    float KgToPounds(float kg)
    {
        float pounds = kg * 1000 / 453;
        return pounds;
    }

    void MaxMin(float a, float b)
    {
        if (a == b)
        {
            Debug.Log($"{a} = {b}");
        }
        else if (a > b)
        {
            Debug.Log($"Max: {a} Min: {b}");
        }
        else
        {
            Debug.Log($"Max: {b} Min: {a}");
        }
    }
    
    int YearToCentury(int year)
    {
        int century = Mathf.CeilToInt((float)year / 100);
        return century;
    }
}
