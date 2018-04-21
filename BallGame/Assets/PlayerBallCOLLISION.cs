
using UnityEngine;

public class PlayerBallCOLLISION : MonoBehaviour {

   // public CameraMovment Movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
         Debug.Log(collisionInfo.collider.name);
       // if (collisionInfo.collider.tag == "Obsetcle")
        //{
          //  Movement.enabled = false;
           

          //  Debug.Log("we hit an Obsetcle");
        }
    }



