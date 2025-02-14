using UnityEngine;

// C# 일반화 프로그래밍(Generic Programming)
// 데이터 형식에 대한 일반화를 진행하는 기법
// 일반적으로는 <T>를 이용해서 설계하는 방식을 의미

public class GenericSample : MonoBehaviour
{
    // 배열을 전달받아서 배열의 요소를 순서대로 출력하는 코드
    public static void printIArray(int[] numbers)
    {
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }
    }

    public static void printFArray(float[] numbers)
    {
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }
    }

    public static void printSArray(string[] words)
    {
        foreach (string i in words)
        {
            Debug.Log(i);
        }
    }

    public static void printGArray<T>(T[] values)
    {
        foreach (T t in values)
        {
            Debug.Log(t);
        }
    }

    void Start()
    {
        int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        float[] num2 = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f };
        string[] words = { "hello", "momo", "nana", "nini", "hoho" };
        printGArray<int>(num1);
        printGArray(num2);
        printGArray(words);
    }
}
