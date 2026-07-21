using System.Numerics;

public class Tile : MonoBehaviour {
    private string name;
    private Vector2 size;
    public List<Vector2> possibleConnections = [(1, 0), (0, 1), (-1, 0), (0, -1)];

    public void Start() {
        
    }
}