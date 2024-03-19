using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletshot = 6.0f;
    
    private void OnEnable()
    {
        transform.position = new Vector3(-7, 0, 0);
    }
    void Update()
    {
        transform.Translate(Vector3.right * bulletshot * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "RightBox") gameObject.SetActive(false); 
    }
}
