using UnityEngine;

public class balanceObject : MonoBehaviour
{
    private Vector3 currentrotation; 

    void Start()
    {
        currentrotation = transform.eulerAngles; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(currentrotation.x, transform.eulerAngles.y, currentrotation.z);
    }
}