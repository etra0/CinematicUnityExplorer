﻿namespace UnityExplorer.Inspectors.MouseInspectors
{
    public abstract class MouseInspectorBase
    {
        public abstract void OnBeginMouseInspect();

        public abstract void UpdateMouseInspect(Vector2 mousePos);

        public abstract void OnSelectMouseInspect(Action<GameObject> inspectorAction);

        public abstract void ClearHitData();

        public abstract void OnEndInspect();
    }
}
