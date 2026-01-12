using UnityEngine;
namespace Lesson05.Tasks
{
    [System.Serializable]
    public class Book
    {
        public string Title;
        public int PageCount;
    }

    public class Library : MonoBehaviour
    {
        [SerializeField] private Book _book;

        private void Start()
        {
            Debug.Log($"Book Title: {_book.Title}, Page Count: {_book.PageCount}");
        }
    }
}