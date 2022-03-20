using UnityEngine;

public class ObstacleCollides : MonoBehaviour
{
    public Renderer _renderer;
    public Material material;
    public Color color;
    private MaterialPropertyBlock _propBlock;
    void Awake(){
        _propBlock = new MaterialPropertyBlock();
    }
    void Update(){

    }
    void OnTriggerEnter(Collider collider){
        if(collider.tag=="Player"){
            // Get the current value of the material properties in the renderer.
            _renderer.GetPropertyBlock(_propBlock);
            // Assign our new value.
            _propBlock.SetColor("_Color",Color.red);
            // Apply the edited values to the renderer.
            _renderer.SetPropertyBlock(_propBlock);
        }
    }

    void OnTriggerExit(Collider collider){
        if(collider.tag=="Player"){
            // Get the current value of the material properties in the renderer.
            _renderer.GetPropertyBlock(_propBlock);
            // Assign our new value.    
            _propBlock.SetColor("_Color",Color.white);
            // Apply the edited values to the renderer.
            _renderer.SetPropertyBlock(_propBlock);
        }    
    }
}
