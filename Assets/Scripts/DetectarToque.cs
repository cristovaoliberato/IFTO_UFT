using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarToque : MonoBehaviour
{
    SelecionarFase select;
    void Start()
    {
        select = GameObject.FindGameObjectWithTag("Player").GetComponent<SelecionarFase>();
    }
    void OnMouseDown()
    {
        select.GameObjectToIndex(this.gameObject);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == this.gameObject.name)
                {
                    select.GameObjectToIndex(this.gameObject);
                }
            }
        }
    }
}
