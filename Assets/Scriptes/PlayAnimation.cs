using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void Play()
    {
        _animator.SetTrigger("IsUsed");
    }

    private void OnMouseUp()
    {
        Play();
    }
}
