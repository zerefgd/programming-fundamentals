using UnityEngine;
using System.Collections.Generic;

namespace Lesson10.Tasks
{
    public class PlayerPuzzleInteractor : MonoBehaviour
    {
        float interactionRange = 3f;
        public List<IPuzzleElement> puzzleElements;

        private void Awake()
        {
            var mbs = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None);
            puzzleElements = new List<IPuzzleElement>();

            foreach (var mb in mbs)
            {
                if (mb is IPuzzleElement puzzleElement && !puzzleElements.Contains(puzzleElement))
                {
                    puzzleElements.Add(puzzleElement);
                }
            }

            if (puzzleElements == null || puzzleElements.Count == 0)
            {
                Debug.LogWarning("No puzzle elements assigned to PlayerPuzzleInteractor.");
            }
        }

        private void Update()
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            IPuzzleElement puzzleElement = null;
            if (Physics.Raycast(ray, out hit, interactionRange))
            {
                puzzleElement = hit.collider.GetComponent<IPuzzleElement>();
                if (puzzleElement != null)
                {
                    Debug.Log("Press 'E' to interact. Hint: " + puzzleElement.GetHintText());
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        puzzleElement.Interact();
                        CheckPuzzleCompletion();
                    }
                }
            }
        }

        private void CheckPuzzleCompletion()
        {
            foreach (var element in puzzleElements)
            {
                if (!element.IsSolved())
                {
                    return;
                }
            }
            Debug.Log("Puzzle Solved!");
            enabled = false; // Disable further interactions
        }
    }
}