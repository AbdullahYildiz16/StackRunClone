using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCodes : MonoBehaviour
{
    List<GameObject> collectedList;
    public float collectedDistance;

    private void Start()
    {
        collectedList = new List<GameObject>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collect"))
        {
            
            if (collectedList.Count == 0f)
            {
                other.gameObject.transform.position = gameObject.transform.position + new Vector3(0,0,-1f);

            }
            else
            {
                other.gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, -1f) + Vector3.up* collectedList.Count * collectedDistance;
            }
            other.gameObject.transform.parent = gameObject.transform;
            other.gameObject.tag = "Collected";
            collectedList.Add(other.gameObject);
        }
        if (other.CompareTag("Stack"))
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
            collectedList[collectedList.Count-1].SetActive(false);
            collectedList.RemoveAt(collectedList.Count -1);
        }
    }
}
