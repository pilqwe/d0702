using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; // Rigidbody 컴포넌트를 저장할 변수
    public float speed = 5f; // 플레이어 이동 속도
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            // 위쪽 방향키 입력이 감지 된 경우 z 방향 힘가기
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            // 아래쪽 방향키 입력이 감지 된 경우 -z 방향 힘가기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            // 오른쪽 방향키 입력이 감지 된 경우 x 방향 힘가기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            // 왼쪽 방향키 입력이 감지 된 경우 -x 방향 힘가기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
}
