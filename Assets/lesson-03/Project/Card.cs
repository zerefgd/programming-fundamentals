using UnityEngine;

namespace Lesson03.Project
{
    public class Card : MonoBehaviour
    {      
        public int value;
        public Material frontMaterial;
        public Material backMaterial;

        private CardGameManager gameManager;
        private bool isFlipped = false;
        private bool isMatched = false;
        private MeshRenderer cardRenderer;
        private Vector3 startScale;

        public void Initialize(int cardValue, Material frontMat, Material backMat, CardGameManager manager)
        {
            value = cardValue;
            frontMaterial = frontMat;
            backMaterial = backMat;
            gameManager = manager;
            cardRenderer = GetComponent<MeshRenderer>();
            cardRenderer.material = backMaterial;
            startScale = transform.localScale;
        }

        void OnMouseDown()
        {
            if (!isFlipped && !isMatched && gameManager != null)
            {
                string[] nameParts = gameObject.name.Split('_');
                if(nameParts.Length >= 3)
                {
                    int x = int.Parse(nameParts[1]);
                    int y = int.Parse(nameParts[2]);
                    gameManager.CardClicked(x, y);
                }
            }
        }

        public void Flip(bool flipUp)
        {
            if(flipUp && !isFlipped)
            {
                cardRenderer.material = frontMaterial;
                isFlipped = true;
            }
            else if(!flipUp && isFlipped && !isMatched)
            {
                cardRenderer.material = backMaterial;
                isFlipped = false;
            }
        }

        public void SetMatched(bool matched)
        {
            isMatched = matched;
            if(matched)
            {
                transform.localScale *= 1.1f; // Slightly enlarge matched cards
                Invoke(nameof(ResetSize), 0.5f);
            }
        }

        void ResetSize()
        {
            transform.localScale = startScale;
        }
    }
}