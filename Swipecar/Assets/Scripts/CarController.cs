using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CarController : MonoBehaviour
{
    public enum State
    {
        Move, Stop
    }

    private Vector3 startPos;
    private float moveSpeed;
    public float stopDistance = 0.1f;
    public Transform target;
    private State state;
    private bool isStop;
    public System.Action moveAction;

    void Update()
    {
        bool isDown = Input.GetMouseButtonDown(0);

        if (isDown)
        {
            this.startPos = Input.mousePosition;
            Debug.Log($"Down : {this.startPos}");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector3 endPos = Input.mousePosition;

            Debug.Log($"Up : {this.startPos}, {endPos}");

            float dirX = endPos.x - startPos.x;

            Debug.Log(dirX);

            if (dirX > 0)
            {
                Debug.Log($"오른쪽으로 {Mathf.Abs(dirX)}m이동합니다.");
                moveSpeed = 0.1f;



            }
            else if (dirX < 0)
            {
                Debug.Log($"왼쪽으로 {Mathf.Abs(dirX)}m이동합니다.");
                moveSpeed = -0.1f;

            }
            float distance = Vector3.Distance(transform.position, target.position);

            if (distance > stopDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            }
            else
            {
                Debug.Log("목표 지점을 지나쳤습니다!");
            }
        }

        this.transform.Translate(moveSpeed, 0, 0);

        moveSpeed *= 0.96f;
    }

    public void Move(InputManager.Direction direction)
    {
        AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.Play();

        int dir = (int)direction;
        Debug.Log($"<color=yellow>Move: {direction}, {dir}</color>");

        float speed = 0.1f;

        this.moveSpeed = dir * speed;

        Debug.Log($"<color=yellow>moveSpeed: {moveSpeed}</color>");

        this.state = State.Move;

        isStop = false;

        Debug.Log(state);

    }
}
