using UnityEngine;

namespace DefaultNamespace
{
    public class Randomdice : MonoBehaviour
    {
        private void Start()
        {
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                // Generate a random number between 1 and 6 (inclusive)
                int randomValue = UnityEngine.Random.Range(1, 6);
        
                // Print the random number to the console
                Debug.Log("Random Value: " + randomValue);
            }
        }
    }
}