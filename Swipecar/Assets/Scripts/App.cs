using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{ 
    //������ ������ ����
    //�ʵ带 ����� A, B(gameobject)
    public GameObject A;
    public GameObject B;

    [SerializeField] private Transform b;  

    private void Start()
    {
        A.transform.position = Vector3.zero;
    }

    //�̺�Ʈ �Լ�
    private void Update()
    {
        //���� ���콺 ��ư�� ������ �� ���
        bool isDown = Input.GetMouseButtonDown(0); //0: ���� Ŭ��
        if (isDown)
        {
            Debug.Log("ȸ���� �������ϴ�");
            Vector3 mousePos = Input.mousePosition;
            Debug.Log($"���콺 �ȼ� ��ġ : {mousePos}");
        }
    }
}
