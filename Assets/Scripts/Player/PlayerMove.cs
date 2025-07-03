using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// 플레이어의 이동 속도
    /// </summary>
    [SerializeField]
    private float moveSpeed;
    /// <summary>
    /// 플레이어의 이동 방향
    /// </summary>
    [SerializeField]
    private Vector2 moveDir = Vector2.zero;

    /// <summary>
    /// 플레이어의 Rigidbody2D
    /// </summary>
    private Rigidbody2D rigid;

    /// <summary>
    /// 게임 씬이 시작되고 바로 호출되는 함수
    /// </summary>
    private void Awake()
    {
        // Rigidbody2D 컴포넌트 가져오기
        rigid = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// 매 프레임마다 함수의 호출 간격이 일정함.
    /// </summary>
    private void FixedUpdate()
    {
        // InputSystem에 있는 Horizontal과 Vertical을 가져온다.
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // moveDir에 위에서 가져온 것들을 담는다.
        // 다만 대각선으로 이동하면 이동속도가 달라질 수 있기에 뒤에 normalized를 해준다.
        moveDir = new Vector2(horizontal, vertical).normalized;

        // 리지드바디2D를 이용해 이동을 실행한다.
        rigid.MovePosition(rigid.position + moveDir * moveSpeed * Time.fixedDeltaTime);
    }
}
