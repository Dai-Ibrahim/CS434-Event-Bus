using UnityEngine;
public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            EventBus.TriggerEvent("Shoot");
        }

        if (Input.GetKeyDown("l"))
        {
            EventBus.TriggerEvent("Launch");
        }
		if (Input.GetKeyDown("c"))
        {
            EventBus.TriggerEvent("Scream");
        }
		if (Input.GetKeyDown("h"))
        {
            EventBus.TriggerEvent("Honk");
        }

		if (Input.GetKeyDown("b"))
        {
            EventBus.TriggerEvent("Boom");
        }


    }
}