using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

// 동기(Synchronous)
// Task(작업)을 순차적으로 실행하는 방식
// 하나의 작업이 완료될 때 까지 다음 작업은 대기 상태로 유지


// 비동기(Asynchronous)
// 여러 Task를 동시에 처리하는 방식
// 
public class AsyncSample : MonoBehaviour
{
    bool proc = false;

    //void Start()
    //{
    //    Debug.Log("작업을 시작합니다.");
    //    Sample1();
    //    Debug.Log("Process A");
    //    Task.Delay(1000);
    //    proc = true;
    //}

    // async 키워드는 비동기 메소드를 선언할 때 사용하는 키워드
    // 메소드의 실행 방식으로 비동기적으로 설정

    // 해당 키워드는 메소드, 람다식 등에 사용
    // 해당 키워드가 붙은 메소드는 Task, Task<T> 또는 void를 return

    // Task는 비동기 작업을 나타내는 클래스
    // System.Threading.Tasks에 존재

    // await는 비동기 메소드 내에서 사용되는 키워드
    // 해당 키워드는 Task나 Task<T>를 return하는 메소드나 표현식 앞에 사용

    // 해당 비동기 작업이 완료될 때까지 현재의 메소드를 중지
    // 작업이 완료되면 다시 해당 메소드를 계속 진행

    //private async void Sample1()
    //{
    //    bool bbb = false;
    //    Debug.Log("Process B");
    //    //await Task.Delay(5000);
    //    //if (bbb = await proc)
    //    {

    //    }
    //    Debug.Log("Process C");
    //}
}
