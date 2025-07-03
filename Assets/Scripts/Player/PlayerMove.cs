using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// �÷��̾��� �̵� �ӵ�
    /// </summary>
    [SerializeField]
    private float moveSpeed;
    /// <summary>
    /// �÷��̾��� �̵� ����
    /// </summary>
    [SerializeField]
    private Vector2 moveDir = Vector2.zero;

    /// <summary>
    /// �÷��̾��� Rigidbody2D
    /// </summary>
    private Rigidbody2D rigid;

    /// <summary>
    /// ���� ���� ���۵ǰ� �ٷ� ȣ��Ǵ� �Լ�
    /// </summary>
    private void Awake()
    {
        // Rigidbody2D ������Ʈ ��������
        rigid = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// �� �����Ӹ��� �Լ��� ȣ�� ������ ������.
    /// </summary>
    private void FixedUpdate()
    {
        // InputSystem�� �ִ� Horizontal�� Vertical�� �����´�.
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // moveDir�� ������ ������ �͵��� ��´�.
        // �ٸ� �밢������ �̵��ϸ� �̵��ӵ��� �޶��� �� �ֱ⿡ �ڿ� normalized�� ���ش�.
        moveDir = new Vector2(horizontal, vertical).normalized;

        // ������ٵ�2D�� �̿��� �̵��� �����Ѵ�.
        rigid.MovePosition(rigid.position + moveDir * moveSpeed * Time.fixedDeltaTime);
    }
}
