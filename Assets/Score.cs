using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    Text _text;

    void Awake()
    {
        _text = GetComponent<Text>();
	}

    void OnEnable()
    {
        EventManager.StartListening("COLLISION", HandleCollision);
    }

    void OnDisable()
    {
        EventManager.StopListening("COLLISION", HandleCollision);
    }

    void HandleCollision()
    {
        _text.text = Global.score.ToString();
    }
}
