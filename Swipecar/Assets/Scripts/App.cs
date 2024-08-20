using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{ 
    //벡터의 뺄셈을 연습
    //필드를 만든다 A, B(gameobject)
    public GameObject A;
    public GameObject B;

    [SerializeField] private Transform b;  

    private void Start()
    {
        A.transform.position = Vector3.zero;
    }

    //이벤트 함수
    private void Update()
    {
        //왼쪽 마우스 버튼을 눌렀을 때 출력
        bool isDown = Input.GetMouseButtonDown(0); //0: 왼쪽 클릭
        if (isDown)
        {
            Debug.Log("회면을 눌렀습니다");
            Vector3 mousePos = Input.mousePosition;
            Debug.Log($"마우스 픽셀 위치 : {mousePos}");
        }
    }
}
