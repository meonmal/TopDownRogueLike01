using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    /// <summary>
    /// ī�޶� �Ѿƴٴ� ���(�÷��̾�)
    /// </summary>
    [SerializeField]
    private GameObject target;

    /// <summary>
    /// ��� Update(FixedUpdate����)�� ȣ��ǰ� ���� ȣ��Ǵ� �Լ�
    /// </summary>
    private void LateUpdate()
    {
        // ���� �÷��̾ ���ٸ� ����
        if(target == null)
        {
            // �� �Լ��� �����ض�.
            return;
        }

        // ī�޶��� ��ġ�� Ÿ�ٿ��� ������Ű��, z�ุ -10���� �Ѵ�.
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
    }
}
