using UnityEngine;

namespace Lesson12.Project
{
    public class Blaster : MonoBehaviour
    {
        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out RaycastHit hitInfo))
                {
                    IShootable shootable = hitInfo.collider.GetComponent<IShootable>();
                    if(shootable != null)
                    {
                        shootable.OnHit();
                    }
                }
            }
        }
    }
}