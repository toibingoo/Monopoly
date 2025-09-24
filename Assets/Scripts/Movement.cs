using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Movement : MonoBehaviour
    {
        [Header("Movement Settings")]
        public float moveSpeed = 2f;
        public float totalTime = 5f;
        public float maxHeight = 1.2f; // Độ cao tối đa của đường parabol
        
        private float elapsedTime = 0f;
        private Vector3 startPosition;
        private Vector3 targetPosition;
        
        private void Start()
        {
            startPosition = transform.position;
            // Tính toán vị trí đích (có thể thay đổi theo nhu cầu)
            targetPosition = startPosition + new Vector3(0, 0, 10f);
        }
        
        private void Update()
        {
            elapsedTime += Time.deltaTime;
            
            if (elapsedTime <= totalTime)
            {
                // Tính toán tỷ lệ hoàn thành (0 đến 1)
                float t = elapsedTime / totalTime;
                
                // Di chuyển theo đường parabol
                MoveInParabola(t);
            }
        }
        
        private void MoveInParabola(float t)
        {
            // Tính toán vị trí hiện tại theo đường thẳng
            Vector3 currentPosition = Vector3.Lerp(startPosition, targetPosition, t);
            
            // Tính toán độ cao theo đường parabol (y = -4h(x - 0.5)² + h)
            float parabolaHeight = -4f * maxHeight * Mathf.Pow(t - 0.5f, 2) + maxHeight;
            
            // Áp dụng độ cao vào vị trí
            currentPosition.y = startPosition.y + parabolaHeight;
            
            // Cập nhật vị trí
            transform.position = currentPosition;
            
            // (Tùy chọn) Xoay object theo hướng di chuyển
        }
        
        
        // Phương thức để thiết lập điểm đích mới
        public void SetTargetPosition(Vector3 newTarget)
        {
            startPosition = transform.position;
            targetPosition = newTarget;
            elapsedTime = 0f;
        }
    }
}