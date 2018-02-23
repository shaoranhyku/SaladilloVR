///////////////////////////////
// Francisco Javier Florín Cárdenas
// Curso 2017/18
// SaladilloVR
// LoadButton.cs
///////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoadButtonScript : MonoBehaviour
{
    // Objeto donde se va a crear la información de los clientes
    public GameObject Information;

    // Objeto que se crea para un cliente
    public GameObject ModelClient;

    /// <summary>
    /// Método que se ejeccuta cuando se pulsa el botón Load.
    /// </summary>
    /// <remarks>
    /// Obtiene la lista de clientes.
    /// </remarks>
    public void OnClick()
    {
        GetClients();
    }

    /// <summary>
    /// Obtiene la lista de clientes.
    /// </summary>
    /// <remarks>
    /// Llama a una corrutina que llama a la web API
    /// para obtener la información.
    /// </remarks>
    private void GetClients()
    {
        StartCoroutine(GetClientsWebApi());
    }

    private IEnumerator GetClientsWebApi()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(
            Uri.EscapeUriString(string.Format(GameManager.WEB_API_GET_CLIENTS, GameManager.IpAddress))))
        {
            // Envía la petición a la web API y espera la respuesta
            yield return www.SendWebRequest();

            // Acción a realizar si la petición se ha
            // ejecutado sin error
            if (!www.isNetworkError)
            {
                // Se recupera la lista de clientes
                ClientList clientList = JsonUtility.FromJson<ClientList>(www.downloadHandler.text);

                for (int i = 0; i < clientList.clients.Length; i++)
                {
                    // Se crea el objeto para un cliente
                    GameObject clientItem = Instantiate(ModelClient);
                    // Se asigna el texto que debe mostrar
                    clientItem.GetComponentInChildren<Text>().text = String.Format("{0} - {1}",
                        clientList.clients[i].dni, clientList.clients[i].name);
                    // Se establece su padre que este en la escena
                    clientItem.transform.SetParent(Information.transform);
                    // Se posiciona en la escena
                    clientItem.GetComponent<RectTransform>().localPosition = new Vector3(0, -0.13f * (i+1), 0);
                }
            }
        }
    }

    #region Entidades

    public class ClientList
    {
        public Client[] clients;
    }

    [Serializable]
    public class Client
    {
        public string dni;
        public string name;
    }

    #endregion
}