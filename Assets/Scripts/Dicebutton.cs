using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Button mybutton;
        [SerializeField] private Image myimage;
        
        private int dem = 0; 
        private void Start()
        {
            mybutton.onClick.AddListener(() =>
            {
                if (dem % 2 == 0)
                {
                    myimage.gameObject.SetActive(true);
                    
                }
                else
                {
                    myimage.gameObject.SetActive(false);
                }
                dem += 1;
            });
        }
    }
}