using UnityEngine;
using TriInspector;

namespace LumosLib.DOTween
{
    [CreateAssetMenu(fileName = "ScaleTweenPreset", menuName = "[ LumosLib ]/Scriptable Objects/Tween Preset/Scale", order = int.MinValue)]
    public class ScaleTweenPreset : BaseTweenPreset
    {
        [PropertySpace(20f)]
        [Title("Scale")]
        
        [SerializeField] private Vector3 _scale;
        
        [SerializeField] private bool _useInitScale;
        [SerializeField, ShowIf("_useInitScale")] private Vector3 _initScale;
        
       
        public Vector3 GetScale() => _scale;
        public bool GetUseInitScale() => _useInitScale;
        public Vector3 GetInitScale() => _initScale;
    }
}