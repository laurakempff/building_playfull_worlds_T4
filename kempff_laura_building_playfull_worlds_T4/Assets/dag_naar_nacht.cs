
using UnityEngine;

public class dag_naar_nacht : MonoBehaviour
{
    
    public GameObject day_light;
    public GameObject night_light;
    public Light nacht_light;

    public Material nacht;
    public Material dag;
    public AudioSource portal_sound;

    public bool isnacht;


    

    void OnTriggerEnter(Collider plyr )
    {
        if (plyr.tag == "Player" && isnacht == false)
        {
            day_light.SetActive(false);


            night_light.SetActive(true);

            portal_sound.Play();

            isnacht = true;

            RenderSettings.skybox = nacht;
            RenderSettings.sun = nacht_light;

        }

        else if (plyr.tag == "Player" && isnacht == true) 
        {
           day_light.SetActive(true);

            isnacht = false;

           night_light.SetActive(false);

           portal_sound.Play();
 
            RenderSettings.skybox = dag;
        }
    }
}
