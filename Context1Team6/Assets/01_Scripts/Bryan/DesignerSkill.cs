using UnityEngine;
using UnityEngine.InputSystem;

namespace _01_Scripts.Bryan
{
    public class DesignerSkill : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _playerMovement;

        private PlayerControls _input;

        // Start is called before the first frame update
        void Start()
        {

            SetDesingerChildOn();

             _playerMovement = GetComponent<PlayerMovement>();
            
            _input = new PlayerControls();
            _input.Designer.GravityCycle.performed += ctx => { CycleBetweenGravityValues(); };
            _input.Designer.JumpHeightCycle.performed += ctx => { CycleBetweenJumpHeightValues(); };
            _input.Designer.MovementSpeedCycle.performed += ctx => { CycleBetweenMovementSpeedValues(); };
            _input.Designer.Enable();
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(_playerMovement);
        }

        public void CycleBetweenMovementSpeedValues()
        {
            _playerMovement.playerSpeed = _playerMovement.playerSpeed * 2f;

            if (_playerMovement.playerSpeed > 24f)
            {
                _playerMovement.playerSpeed = 6f;
            }

            Debug.Log(_playerMovement.playerSpeed);
        }

        public void CycleBetweenGravityValues()
        {
            _playerMovement.gravityValue = _playerMovement.gravityValue + 2f;

            if (_playerMovement.gravityValue > -2f)
            {
                _playerMovement.gravityValue = -9.81f;
            }

            Debug.Log(_playerMovement.gravityValue);
        }

        public void CycleBetweenJumpHeightValues()
        {
            _playerMovement.jumpHeight = _playerMovement.jumpHeight * 2f;

            if (_playerMovement.jumpHeight > 16f)
            {
                _playerMovement.jumpHeight = 8f;
            }

            Debug.Log(_playerMovement.jumpHeight);
        }

        private void SetDesingerChildOn()
        {
            //alle skills uitzetten
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(false);

            //Designer aanzetten
            transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}