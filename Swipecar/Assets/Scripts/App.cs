using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public InputManager inputManager;
    public CarController carController;
    public Transform flagTrans;
    public GameDirector gameDirector;

    public void Start()
    {
        this.CalcDistanceAndUpdateUI();

        this.inputManager.swipeAction = (direction) => {

            Debug.Log(direction);

            carController.Move(direction);

        };

        carController.moveAction = () => {

            this.CalcDistanceAndUpdateUI();

        };
    }

    //�ڵ��� ������Ʈ�� ��� ������Ʈ�� �Ÿ��� ����� gameDirector�� UpdateUI�� ȣ�� �ϴ� �޼��� 

    private void CalcDistanceAndUpdateUI()
    {
        Vector3 carPos = carController.gameObject.transform.position;
        Vector3 flagPos = this.flagTrans.position;

        float distanceX = flagPos.x - carPos.x;

        gameDirector.UpdateUI(distanceX);
    }
}
