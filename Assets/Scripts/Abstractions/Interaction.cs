using UnityEngine;

namespace Abstractions
{
    public class Interaction : MonoBehaviour, IInteraction
    {
        public static Interaction CreateInstance()
        {
            return new Interaction();
        }
    }

   
}
