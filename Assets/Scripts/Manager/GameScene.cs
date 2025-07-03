using UnityEngine;

public class GameScene : MonoBehaviour
{
    /// <summary>
    /// 플레이어 오브젝트
    /// </summary>
    [SerializeField]
    private GameObject player;
    /// <summary>
    /// 몬스터 오브젝트
    /// 몬스터는 여러마리이기에 배열로 선언
    /// </summary>
    [SerializeField]
    private GameObject[] monsters;

    /// <summary>
    /// 게임 씬이 시작되고 바로 호출되는 함수
    /// </summary>
    private void Awake()
    {

    }
}
