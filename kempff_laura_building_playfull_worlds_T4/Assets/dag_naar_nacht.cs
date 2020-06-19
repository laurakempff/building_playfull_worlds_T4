
using UnityEngine;

public class dag_naar_nacht : MonoBehaviour
{
    
    public GameObject day_light;
    public GameObject night_light;
    //public Light nacht_light;

    public Material nacht;
    //public Material dag;
    public AudioSource portal_sound;

    

    void OnTriggerStay(Collider plyr) 
    {
        if (plyr.tag == "Player")
        {
            day_light.SetActive(false);


            night_light.SetActive(true);

            portal_sound.Play();

            RenderSettings.skybox = nacht;
            //RenderSettings.sun = nacht_light;

        }

        //if (plyr.tag == "player" && RenderSettings.skybox == nacht)
        //{
        //    day_light.SetActive(true);


        //    night_light.SetActive(false);

        //    portal_sound.Play();
 
        //    RenderSettings.skybox = dag;
        //}
    }
}
