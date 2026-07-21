using UnityEngine;

public class donutRotation : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 50f * Time.deltaTime);
    }
}
