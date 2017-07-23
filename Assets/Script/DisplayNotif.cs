using UnityEngine;

public class DisplayNotif : MonoBehaviour
{
    AudioSource sound;
    // Use this for initialization
    void Start()
    {
		if(gameObject.GetComponent<AudioSource>() != null)
			{
				sound = gameObject.GetComponent<AudioSource>();
        		sound.Play();
			}
    }

    // Update is called once per frame
    void Update()
    {

    }


}
