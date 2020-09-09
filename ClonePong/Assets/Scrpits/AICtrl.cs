using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICtrl : MonoBehaviour
{
    private Transform _transform;
    public float moveSpeed = 3.0f;
    private Vector3 TopLeft;
    private Vector3 BottomRight;
    
    // Camera.main.ScreenToWorldPoint() : 메인카메라상의 좌표를 매개변수로 주면 게임상의 좌표를 리턴받는다.
    // Screen.width, Screen.height :화면의 가로 세로 변수
    public GameObject ballOb;
    private Transform _ballTransform;
    private float _ballY;
    
    void Start()
    {
        _transform = GetComponent<Transform>();
        _ballTransform = ballOb.GetComponent<Transform>();
        TopLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        BottomRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

    }
    
    void Update()
    {
        _ballY = ballOb.transform.position.y;
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, _ballY, 0),
            moveSpeed * Time.deltaTime);
    }
    /*
 벽돌이 할 것
 ai일떄
 공의 y값을 가져와서 그 위치로 천천히 이동하기
 */
}
