using UnityEngine;

namespace _01_Scripts.Nathan.prototype.Dev_skills
{
    public class TweedePuzzelInput : MonoBehaviour
    {
        public bool PassedTest;

        public PlayerMovement CanvasPlayermovement;

        public GameObject GamepadCursorTower;

        [SerializeField] private GameObject _correspondingObject;

        [Header("vragen")] [SerializeField] private TMPro.TMP_Dropdown vraag1;

        [SerializeField] private TMPro.TMP_Dropdown vraag2;

        [SerializeField] private TMPro.TMP_Dropdown vraag3;

        [SerializeField] private TMPro.TMP_Dropdown vraag4;

        [SerializeField] private TMPro.TMP_Dropdown vraag5;

        [Header("antwoorden")] [SerializeField]
        private int antwoord1Index;

        [SerializeField] private int antwoord2Index;

        [SerializeField] private int antwoord3Index;

        [SerializeField] private int antwoord4Index;

        [SerializeField] private int antwoord5Index;

        private void Start()
        {
            PassedTest = false;
            
        }

        private void Update()
        {
            if (vraag1.value == antwoord1Index && vraag2.value == antwoord2Index && vraag3.value == antwoord3Index &&
                vraag4.value == antwoord4Index && vraag5.value == antwoord5Index)
            {
                Debug.Log("passed second test");
    
                PassedTest = true;

                GamepadCursorTower.SetActive(false);

                CanvasPlayermovement.enabled = true;


                _correspondingObject.transform.position = new Vector3(_correspondingObject.transform.position.x, _correspondingObject.transform.position.y + 17f,
                    _correspondingObject.transform.position.z);
            
                vraag1.value = antwoord1Index + 1;
            }
        }
    }
}
