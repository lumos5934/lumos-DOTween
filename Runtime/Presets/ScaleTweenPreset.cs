using UnityEngine;
using TriInspector;

namespace LumosLib.DOTween
{
    [CreateAssetMenu(fileName = "ScaleTweenPreset", menuName = "[ LumosLib ]/Scriptable Objects/Tween Preset/Scale", order = int.MinValue)]
    public class ScaleTweenPreset : BaseTweenPreset
    {
        #region >--------------------------------------------------- FIELD


        
        [PropertySpace(20f)]
        [Title("Scale")]
        
        [SerializeField] private Vector3 _scale;
        
        [SerializeField] private bool _useInitScale;
        [SerializeField, ShowIf("_useInitScale")] private Vector3 _initScale;
        
        
        #endregion
        #region >--------------------------------------------------- GET
       
        public Vector3 GetScale()
        {
            return _scale;
        }

        public bool GetUseInitScale()
        {
            return _useInitScale;
        }

        public Vector3 GetInitScale()
        {
            return _initScale;
        }

        #endregion
    }
}