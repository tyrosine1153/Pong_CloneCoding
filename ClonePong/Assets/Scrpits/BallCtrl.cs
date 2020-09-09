using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtrl : MonoBehaviour
{
    private Transform _transform;
    public float moveSpeed = 10.0f;
    private Vector3 BottomLeft;
    private Vector3 TopRight;
    private float rX, rY;
    void Start()
    {
        _transform = GetComponent<Transform>();
        BottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        TopRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        
        rX = Random.Range(-0.8f, 0.8f);
        rY = Random.Range(-1.0f, 1.0f);
        Debug.Log("Top : " + TopRight.y);
        Debug.Log("Bottom : " + BottomLeft.y);
    }

    void Update()
    {
        transform.Translate(new Vector3(rX, rY, 0) * moveSpeed * Time.deltaTime);
        //위아래 화면에 닿으면 방향을 바꾸는 코드
        Debug.Log("position.y : " + transform.position.y);
        if (transform.position.y > TopRight.y || BottomLeft.y > transform.position.y)
            rY *= -1;
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Brick"))
        {
            rX *= -1;
        }
    }
}
/*
ball이 해야하는 것
:속도 지정
시작할때 일정 범위 내 랜덤 위치에 있기
랜덤 방향으로 계속가기
벽이나 벽돌을 맞으면 반대방향으로 튕기기
 */