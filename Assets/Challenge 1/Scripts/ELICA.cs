using JetBrains.Annotations;
using UnityEngine;

public class ELICA : MonoBehaviour
{
    public float speed = 5.0f; // degrees per sec
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
