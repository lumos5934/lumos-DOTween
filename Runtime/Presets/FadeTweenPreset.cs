using TriInspector;
using UnityEngine;

namespace LumosLib.DOTween
{
    [CreateAssetMenu(fileName = "FadeTweenPreset", menuName = "[ LumosLib ]/Scriptable Objects/Tween Preset/Fade", order = int.MinValue)]
    public class FadeTweenPreset : BaseTweenPreset
    {
        [Title("Fade")] 
        [SerializeField] private float _fade;
        
        [SerializeField] private bool _useInitFade;
        [SerializeField, ShowIf("_useInitFade")] private float _initFade;


        public float GetFade() =>  _fade;
        public bool GetUseInitFade() => _useInitFade;
        public float GetInitFade() => _initFade;
    }
}