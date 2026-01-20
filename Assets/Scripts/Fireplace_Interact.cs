using UnityEngine;
using FMODUnity;

public class Fireplace_Interact : MonoBehaviour, IInteractable 
{
    [Header("Ognisko")]
    [SerializeField] GameObject ognisko;
    [Header("Dzwieki")]
    [SerializeField] private EventReference fireplaceStart;
    [SerializeField] private EventReference fireplaceStop;
    [Header("Stan")]
    [SerializeField] private bool isActive = true;
   public void Interact ()
    {
        isActive = !isActive;
        if (ognisko != null)
        {
            ognisko.SetActive(isActive);
            PlayInterctSound();
        }


    }

    public void PlayInterctSound()

    {
        if (isActive)
        {
            RuntimeManager.PlayOneShot(fireplaceStart);
        }
        else
        {
            RuntimeManager.PlayOneShot(fireplaceStop);
        }

    }


}


