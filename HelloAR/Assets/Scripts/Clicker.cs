using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public List<GameObject> objects;
    public GameObject rock;

    int min_objects = 2;
    int max_objects = 7;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    int object_id = Random.Range(0, objects.Count);
                    GameObject new_object = Instantiate(objects[object_id], transform.parent);
                    new_object.transform.position = hit.point;
                    Debug.DrawLine(ray.origin, hit.point, Color.red, 100.0f);
                }
                if (Input.GetMouseButtonDown(1))
                {
                    int number = Random.Range(min_objects, max_objects);
                    for (int i = 0; i < number; i++)
                    {
                        GameObject new_go = Instantiate(rock, transform.parent);
                        new_go.transform.position = hit.point + new Vector3(Random.Range(-0.05f, 0.05f), 0.3f + Random.Range(-0.1f, 0.1f), Random.Range(-0.05f, 0.05f));
                    }
                }
            }
        }
    }
}
