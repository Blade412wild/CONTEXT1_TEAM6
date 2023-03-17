using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace _01_Scripts.Bryan
{
    public class LerpADoor : MonoBehaviour
    {
        [SerializeField] private float _heightChangeForLerp;
        
        private Vector3 _startPos;
        private Vector3 _endPos;
        private float _moveOverSeconds = 3f;
        private float _elapsedTime;
        

        // Start is called before the first frame update
        void Start()
        {
            _startPos = transform.position; //Transform van waar dit script aan vast zit.
        }

        // Update is called once per frame
        void Update()
        {
            MoveGameObject();
        }

        private void MoveGameObject()
        {
            //Verander de Y-waarde naar hoeveel "afstand" het gameObject moet bewegen in de Y-as.
            //Voor X en Z moet je hetzelfde doen, mocht je de deur niet willen laten openen langs de y-as.
            Vector3 _endPos = new Vector3(transform.position.x, _heightChangeForLerp, transform.position.z);
            
            _elapsedTime = _elapsedTime + Time.deltaTime;

            float percentageComplete = _elapsedTime / _moveOverSeconds;

            transform.position = Vector3.Lerp(_startPos, _endPos, percentageComplete);
        }
    }
}