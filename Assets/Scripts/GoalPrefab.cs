using TMPro;
using UnityEngine;

public class GoalPrefab : MonoBehaviour
{
    // SerializeField -> privateな変数をInspector上に表示
    [SerializeField]
    private TextMeshProUGUI goalText;

    // IsTrigerに反応があるか確認
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        // canvasにゴール情報を送る
        goalText.enabled = true;
    }
}
