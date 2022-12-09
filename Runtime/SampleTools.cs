using UnityEngine;

namespace GDT.Utils
{
    public class SampleTools : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("Awake");
        }

        private void OnEnable()
        {
            Debug.Log("OnEnable");
        }

        private void OnDisable()
        {
            Debug.Log("OnDisable");
        }
    }
}