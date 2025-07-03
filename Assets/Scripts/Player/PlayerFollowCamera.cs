using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    /// <summary>
    /// 카메라가 쫓아다닐 대상(플레이어)
    /// </summary>
    [SerializeField]
    private GameObject target;

    /// <summary>
    /// 모든 Update(FixedUpdate포함)가 호출되고 나서 호출되는 함수
    /// </summary>
    private void LateUpdate()
    {
        // 만약 플레이어가 없다면 실행
        if(target == null)
        {
            // 이 함수를 종료해라.
            return;
        }

        // 카메라의 위치는 타겟에게 고정시키고, z축만 -10으로 한다.
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
    }
}
