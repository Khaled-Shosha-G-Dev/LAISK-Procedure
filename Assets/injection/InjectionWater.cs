using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjectionWater : MonoBehaviour
{
    float flauidTime = 3f;
    float counter=0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.active)
        {
            counter += Time.deltaTime;
            if(counter > flauidTime)
                gameObject.SetActive(false);
        }
    }
    public void ActiveWater()
    {
        gameObject.SetActive (true);
        counter = 0f;
    }

}
