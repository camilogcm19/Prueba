using UnityEngine;
using UnityEngine.InputSystem; // Necesario para el nuevo sistema

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector2 entradaMovimiento;

    // Este método se activa con el componente Player Input
    public void AlMoverse(InputAction.CallbackContext context)
    {
        entradaMovimiento = context.ReadValue<Vector2>();
    }

    void Update()
    {
        // Movimiento simple en 3D (X y Z)
        Vector3 movimiento = new Vector3(entradaMovimiento.x, 0, entradaMovimiento.y);
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}
