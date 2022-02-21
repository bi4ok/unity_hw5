using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        firstTask();
        secondTask();
        thirdTask(5);
    }

    public void firstTask()
    {
        for (int i = 1; i < 9; i+=2)
        {
            Debug.Log(i + 1);
        }
    }

    public void secondTask()
    {
        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                Debug.Log($"{i} * {j} = {i * j}");
            }
        }
    }

    public void thirdTask(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        Debug.Log($"{result}");
    }   
}

