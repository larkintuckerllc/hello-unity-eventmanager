using UnityEngine;

public class Ball : MonoBehaviour {

    static Vector3 VELOCITY = new Vector3(3.0f, 0.0f, 4.0f);

    Rigidbody _rigidBody;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        EventManager.StartListening("START", HandleStart);
    }

    void OnDisable()
    {
        EventManager.StopListening("START", HandleStart);
    }

	void HandleStart()
    {
        _rigidBody.velocity = VELOCITY;
    }
}
