using UnityEngine;
using DG.Tweening;
using TriInspector;

namespace LumosLib.DOTween
{
    public abstract class BaseTweenPreset : ScriptableObject
    {
        [Title("Base")]
        [SerializeField] private Ease _ease;
        [SerializeField] private float _duration;
        [SerializeField] private bool _useRandomDuration;
        [SerializeField, ShowIf("_useRandomDuration"), Range(0, 1)] private float _durationRandomFactor;

        [PropertySpace(20f)] 
        [Title("Loop")] 
        [SerializeField] private bool _useLoop;
        [SerializeField, ShowIf("_useLoop")] private LoopType _loopType;
        [SerializeField, ShowIf("_useLoop")] private int _loopCount;
        

        public Ease GetEase()
        {
            return _ease;
        }

        public bool GetUseLoop()
        {
            return _useLoop;
        }

        public LoopType GetLoopType()
        {
            return  _loopType;
        }

        public int GetLoopCount()
        {
            return  _loopCount;
        }
        
        public float GetDuration()
        {
            return _useRandomDuration 
                ? _duration * Random.Range(1 - _durationRandomFactor, 1 + _durationRandomFactor) 
                : _duration;
        }
    }
}