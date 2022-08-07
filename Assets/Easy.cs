using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy : MonoBehaviour
{
    private const float KgInPounds = 0.453f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CalcPerimeter(3, 7)); //1
        Debug.Log(Delitel(4, 8));       //2
        Debug.Log(GetDay(8));           //3
        Debug.Log(PoundsToKg(170));     //4
        Debug.Log(KgToPounds(70));      //4
        MaxMin(3, 7);                   //5
        Debug.Log(YearToCentury(701));  //6
    }

    float CalcPerimeter(int katetA, int katetB)
    {
        float hipotenyse = Mathf.Sqrt(katetA * katetA + katetB * katetB);

        float perimeter = katetA + katetB + hipotenyse;
        return perimeter;
    }

    bool IsDivison(int x, int y)
    {
        return y % x == 0;
    }

    DayWeek GetDay(int day)
    {
        switch (day)
        {
            case 1:
                return DayWeek.Ponedelnik;
            case 2:
                return DayWeek.Vtornik;
            case 3:
                return DayWeek.Sreda;
            case 4:
                return DayWeek.Chetverg;
            case 5:
                return DayWeek.Pyatnica;
            case 6:
                return DayWeek.Subbota;
            case 7:
                return DayWeek.Voskresenye;
            default:
                throw new Exception("Wrong day of the week!")
        }
    }

    enum DayWeek
    {
        Ponedelnik,
        Vtornik,
        Sreda,
        Chetverg,
        Pyatnica,
        Subbota,
        Voskresenye
    }

    float PoundsToKg(float pounds)
    {
        float kg = pounds * KgInPounds;
        return kg;
    }

    float KgToPounds(float kg)
    {
        float pounds = kg / KgInPounds;
        return pounds;
    }

    void MaxMin(float a, float b)
    {
        if (a > b)
        {
            Debug.Log($"Max: {a} Min: {b}");
        }
        else if (a < b)
        {
            Debug.Log($"Max: {b} Min: {a}");
        }
        else
        {
            Debug.Log($"{b} = {a}");
        }
    }
    
    int YearToCentury(int year)
    {
        int century = Mathf.CeilToInt((float)year / 100);
        return century;
    }
}
