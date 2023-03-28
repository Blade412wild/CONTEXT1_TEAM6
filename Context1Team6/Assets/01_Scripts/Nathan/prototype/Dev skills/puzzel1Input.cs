using Unity.VisualScripting;
using UnityEngine;

namespace _01_Scripts.Nathan.prototype.Dev_skills
{
    public class puzzel1Input : MonoBehaviour
    {
        public PlayerMovement CanvasPlayermovement;

        public Canvas DevPuzzel1Canvas;
        public GameObject GamepadCursorDoor;


        public bool Passed;
        [SerializeField] private GameObject _correspondingObject;

        [Header("vragen")][SerializeField] private TMPro.TMP_Dropdown vraag1;

        [SerializeField] private TMPro.TMP_Dropdown vraag2;

        [SerializeField] private TMPro.TMP_Dropdown vraag3;

        [SerializeField] private TMPro.TMP_Dropdown vraag4;

        [SerializeField] private TMPro.TMP_Dropdown vraag5;

        [Header("antwoorden")]
        [SerializeField]
        private int antwoord1Index;

        [SerializeField] private int antwoord2Index;

        [SerializeField] private int antwoord3Index;

        [SerializeField] private int antwoord4Index;

        [SerializeField] private int antwoord5Index;

        private void Start()
        {
            Passed = false;
            DevPuzzel1Canvas = GetComponent<Canvas>();
            
        }

        private void Update()
        {
            if (Passed)
            {
                CanvasPlayermovement.enabled = true;
            }

            if (vraag1.value == antwoord1Index && vraag2.value == antwoord2Index && vraag3.value == antwoord3Index &&
                vraag4.value == antwoord4Index && vraag5.value == antwoord5Index)
            {
                Debug.Log("passed");

                Passed = true;
                
                CanvasPlayermovement.enabled = true;
                GamepadCursorDoor.SetActive(false);
                DevPuzzel1Canvas.enabled = false;


                _correspondingObject.transform.position = new Vector3(transform.position.x, transform.position.y - 0.1216f,
                    transform.position.z);

                vraag1.value = antwoord1Index + 1;
            }
        }
    }
}