
using UnityEngine;

public class dag_naar_nacht : MonoBehaviour
{
    
    public GameObject light;
    public GameObject night_light;

    public Material nacht;

    private bool on = true;

    void OnTriggerStay(Collider plyr) 
    {
        if (plyr.tag == "Player") ;
        {
            light.SetActive(false);
            on = false;

            night_light.SetActive(true);
            on = true;

            RenderSettings.skybox = nacht;
        }

    }
}
