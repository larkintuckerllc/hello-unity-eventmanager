using UnityEngine;

public class Pillar : MonoBehaviour
{
    void OnCollisionEnter()
	{
        Global.score += 1;
        EventManager.TriggerEvent("COLLISION");
	}
}
