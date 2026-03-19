using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSceneSwitch : NetworkCollider
{
    public GameObject sceneSwitch;



    // Start is called before the first frame update
    public override void Trigger()
    {
        StartCoroutine(EnableAfterTime());
    }

    IEnumerator EnableAfterTime()
    {
        yield return new WaitForSeconds(30.0f);
        sceneSwitch.SetActive(true);
        


    }
}