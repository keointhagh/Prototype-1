using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotateSpeed = 360f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,rotateSpeed) * Time.deltaTime);
    }
}
