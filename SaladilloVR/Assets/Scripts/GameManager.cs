using System;

public static class GameManager {
    
    // Clave para la dirección IP
    public const string IP_ADDRESS = "IP_ADDRESS";

    // Variable para almacenar la dirección IP de la web API
    public static string IpAddress;

    // Constante con la URL de la web API para comprobar la conectividad
    public const string WEB_API_CHECK_CONNECTIVITY =
        "http://{0}/SaladilloVR/api/SaladilloVR/CheckConnectivity";

    // Constante con la URL de la web API para obtener una lista de clientes
    public const string WEB_API_GET_CLIENTS = "http://{0}/SaladilloVR/api/SaladilloVR/GetClients";
    
    // Constante con la URL de la web API para guardar un cliente
    public const string WEB_API_LOG_CLIENTS = "http://{0}/SaladilloVR/api/SaladilloVR/LogClient";
}
