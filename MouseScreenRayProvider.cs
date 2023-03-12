public class MouseScreenRayProvider : MonoBehaviour, IRayProvider
{
	private Ray CreateRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}