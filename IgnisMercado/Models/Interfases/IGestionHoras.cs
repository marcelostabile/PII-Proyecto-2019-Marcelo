namespace IgnisMercado 
{
    /// <summary>
    /// Implementada por la clase Solicitud.
    /// </summary>
    public interface IGestionHoras
    {
        void AgregarHoras(int CantidadHoras);

        void RestarHoras(int CantidadHoras);
    }
}