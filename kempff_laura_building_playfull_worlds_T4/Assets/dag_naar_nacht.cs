
using UnityEngine;

public class dag_naar_nacht : MonoBehaviour
{
    
    public GameObject day_light;
    public GameObject night_light;
    //public Light nacht_light;

    public Material nacht;


   

    void OnTriggerStay(Collider plyr) 
    {
        if (plyr.tag == "Player")
        {
            day_light.SetActive(false);


            night_light.SetActive(true);


            RenderSettings.skybox = nacht;
            //RenderSettings.sun = nacht_light;

        }
        
        
    }
}
