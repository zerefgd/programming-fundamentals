using System;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace Lesson03.Project
{
    public class CardGameManager : MonoBehaviour
    {
        public GameObject cardPrefab;
        public Material[] cardFrontMaterials;
        public Material cardBackMaterial;

        public int gridWidth = 4;
        public int gridHeight = 4;
        public float cardSpacing = 1.5f;

        public TMP_Text scoresText;
        public TMP_Text movesText;
        public TMP_Text winText;

        private GameObject[,] cards;
        private int[,] cardValues;
        private bool[,] cardMatched;
        private bool[,] cardFlipped;

        private int firstFlippedX = -1, firstFlippedY = -1;
        private int secondFlippedX = -1, secondFlippedY = -1;

        private bool canFlip = true;
        private int score = 0;
        private int moves = 0;
        private int totalPairs;
        private int matchedPairs = 0;

        private void Start()
        {
            totalPairs = (gridWidth * gridHeight) / 2;
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Implementation for initializing the game
            cards = new GameObject[gridWidth, gridHeight];
            cardValues = new int[gridWidth, gridHeight];
            cardFlipped = new bool[gridWidth, gridHeight];
            cardMatched = new bool[gridWidth, gridHeight];

            score = 0;
            moves = 0;
            matchedPairs = 0;
            UpdateUI();

            if (winText != null)
            {
                winText.gameObject.SetActive(false);
            }

            int[] cardPool = new int[totalPairs * 2];
            int poolIndex = 0;
            for (int i = 0; i < totalPairs; i++)
            {
                cardPool[poolIndex++] = i;
                cardPool[poolIndex++] = i;
            }
            ShuffleArray(cardPool);
            CreateCardGrid(cardPool);
        }

        private void CreateCardGrid(int[] cardPool)
        {
            float startX = -(gridWidth - 1) * cardSpacing / 2;
            float startZ = -(gridHeight - 1) * cardSpacing / 2;
            int index = 0;
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    GameObject cardObj = Instantiate(
                        cardPrefab,
                        new Vector3(startX + x * cardSpacing, 0, startZ + y * cardSpacing),
                        Quaternion.identity);
                    cardObj.name = $"Card_{x}_{y}";
                    Card cardComponent = cardObj.GetComponent<Card>();
                    int cardValue = cardPool[index++];
                    cardValues[x, y] = cardValue;
                    cardComponent.Initialize(cardValue, cardFrontMaterials[cardValue], cardBackMaterial, this);
                    cards[x, y] = cardObj;
                }
            }
        }

        public void CardClicked(int x, int y)
        {
            if (!canFlip || cardMatched[x, y] || cardFlipped[x, y])
                return;
            Card card = cards[x, y].GetComponent<Card>();
            card.Flip(true);
            cardFlipped[x, y] = true;
            if (firstFlippedX == -1 && firstFlippedY == -1)
            {
                firstFlippedX = x;
                firstFlippedY = y;
            }
            else if (secondFlippedX == -1 && secondFlippedY == -1)
            {
                secondFlippedX = x;
                secondFlippedY = y;
                moves++;
                UpdateUI();
                canFlip = false;
                Invoke(nameof(CheckForMatch), 1.0f);
            }
        }

        private void CheckForMatch()
        {
            if (cardValues[firstFlippedX, firstFlippedY] == cardValues[secondFlippedX, secondFlippedY])
            {
                cardMatched[firstFlippedX, firstFlippedY] = true;
                cardMatched[secondFlippedX, secondFlippedY] = true;
                score += 10;
                matchedPairs++;
                if (matchedPairs >= totalPairs)
                {
                    WinGame();
                }
            }
            else
            {
                Card firstCard = cards[firstFlippedX, firstFlippedY].GetComponent<Card>();
                Card secondCard = cards[secondFlippedX, secondFlippedY].GetComponent<Card>();
                firstCard.Flip(false);
                secondCard.Flip(false);
                cardFlipped[firstFlippedX, firstFlippedY] = false;
                cardFlipped[secondFlippedX, secondFlippedY] = false;
            }
            firstFlippedX = -1;
            firstFlippedY = -1;
            secondFlippedX = -1;
            secondFlippedY = -1;
            canFlip = true;
            UpdateUI();
        }

        private void WinGame()
        {
            if (winText != null)
            {
                winText.gameObject.SetActive(true);
                winText.text = $"You Win! Final Score: {score} in {moves} moves. Press R to Restart.";
            }
        }

        private void UpdateUI()
        {
            if (scoresText != null)
            {
                scoresText.text = $"Score: {score}";
            }
            if (movesText != null)
            {
                movesText.text = $"Moves: {moves}";
            }
        }

        private void ShuffleArray(int[] cardPool)
        {
            System.Random rand = new System.Random();
            for (int i = cardPool.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = cardPool[i];
                cardPool[i] = cardPool[j];
                cardPool[j] = temp;
            }
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                foreach (var card in cards)
                {
                    Destroy(card);
                }
                InitializeGame();
            }
        }
    }
}