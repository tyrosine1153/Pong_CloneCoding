using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCtrl: MonoBehaviour
{
    private Transform _transform;
    public float moveSpeed = 3.0f;
    private Vector3 TopLeft;
    private Vector3 BottomRight;
    private float _v = 0.0f;
    void Start()
    {
        _transform = GetComponent<Transform>();
        Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        
    }

    void Update()
    {
        _v = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * _v * moveSpeed * Time.deltaTime);
    }
}
/*
 벽돌이 할 것
 플레이어 일때
 방향키에 따라 위아래로 움직이기
 */