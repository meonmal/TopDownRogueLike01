using UnityEngine;

public class GameScene : MonoBehaviour
{
    /// <summary>
    /// �÷��̾� ������Ʈ
    /// </summary>
    [SerializeField]
    private GameObject player;
    /// <summary>
    /// ���� ������Ʈ
    /// ���ʹ� ���������̱⿡ �迭�� ����
    /// </summary>
    [SerializeField]
    private GameObject[] monsters;

    /// <summary>
    /// ���� ���� ���۵ǰ� �ٷ� ȣ��Ǵ� �Լ�
    /// </summary>
    private void Awake()
    {

    }
}
