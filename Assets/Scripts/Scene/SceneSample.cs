using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSample : MonoBehaviour
{
    // Unity life cycle
    // 유니티는 시작 단게부터 종료 단계까지 함수로 제공
    // ex) Awake(시작 전), Start(시작), Update(진행중) ...

    // 활성화 되었을 경우
    private void OnEnable()
    {
        Debug.Log("OnSceneLoaded가 등록되었습니다.");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    // 비활성화일 경우
    private void OnDisable()
    {
        Debug.Log("OnSceneLoaded가 해제되었습니다.");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
    {
        Debug.Log($"현재 로드된 씬의 이름은 {scene.name}입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("BRP Sample Scene");
            // 일반적인 경우 LoadSceneMode.Single로 처리
            // Single 모드의 설정은 씬을 갈아타도록 설정
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("BRP Sample Scene", LoadSceneMode.Additive);
            // LoadSceneMode가 Additive일 경우 기존 씬 위에 새로운 씬을 중복해서 로드하는 설정
            // 당연히 이 작업은 기본 오브젝트들(Main Camera, Direction Light) 등도 전부 로드되기 때문에 주의가 필요

        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            StartCoroutine("LoadSceneCoroutine");

            //SceneManager.LoadSceneAsync("BRP Sample Scene", LoadSceneMode.Additive);
            // 비동기적(async) 로드

            // 일반적인 씬의 로딩 작업은 동기적으로 처리됨
            // 씬이 로딩이 다 될 때까지 다른 요소들은 작동하지 않게 됨
        }
    }

    IEnumerator LoadSceneCoroutine()
    {
        yield return SceneManager.LoadSceneAsync("BRP Sample Scene", LoadSceneMode.Additive);
    }
}
