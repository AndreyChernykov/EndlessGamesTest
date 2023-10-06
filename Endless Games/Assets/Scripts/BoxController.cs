using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public float speed { get; set; }
    public float distance { get; set; }

    public IEnumerator Drag(List<GameObject> objectList, Transform startPoint)
    {
        while (true)
        {
            foreach (GameObject obj in objectList)
            {
                if (obj.activeSelf) obj.transform.position += Vector3.forward * speed * Time.deltaTime;
                if (startPoint.position.z + distance < obj.transform.position.z) obj.SetActive(false);
            }
            yield return new WaitForEndOfFrame();
        }


        
    }


}
