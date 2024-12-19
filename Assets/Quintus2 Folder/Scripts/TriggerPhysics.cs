using UnityEngine;

public class TriggerPhysics : MonoBehaviour
{
    public string pickup_Item_string;
    public string letgo_Item_string;
    public GameObject parentBone;
    public GameObject objectToParent;
    public Rigidbody rb;

    private void Start()
    {
        rb = objectToParent.GetComponent<Rigidbody>();
    }

    public void animevent(string s)
    {
        Debug.Log("PrintEvent called at " + Time.time + " with a value of " + s);
        if (s == pickup_Item_string)
        {
            Debug.Log("gelukt");
            objectToParent.transform.SetParent(parentBone.transform);
            rb.isKinematic = true;
        }
        else if (s == letgo_Item_string)
        {
            Debug.Log("laat los");
            objectToParent.transform.parent = null;
            rb.isKinematic = false;
        }
        else
        {
            Debug.LogError("je hebt een animatie event getriggered maar geen triggerstring aangegeven. er zal dus niets gebeuren");
        }

    }
}
