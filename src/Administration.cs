#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using Strategies;
using System;
using UnityEngine;

public class Administration : MonoBehaviour
{
    public BTButton btnAccept;
    public BTButton btnCancel;
    public Texture defaultIcon;
    public UISlider effectSlider;
    public UISlider effectSliderVisual;
    public static Administration Instance;
    public SpriteTextRich investmentText;
    public RomfarerPanelManager pmSelectionButtons;
    public RomfarerPanelManager pmSelectionEffects;
    public RomfarerPanelManager pmSelectionText;
    public GameObject prefabActiveStrat;
    public GameObject prefabKerbalItem;
    public GameObject prefabStratList;
    public GameObject prefabStratListContainer;
    public RDScrollbar scrollBarH;
    public RomfarerSlider scrollBarV;
    public UIScrollList scrollListActive;
    public UIScrollList scrollListKerbals;
    public ScrollListResizer scrollListResizer;
    public RomfarerDoubleScrollList scrollListStrategies;
    public RUIScrollableRichTextAreaWimage strategyImageAndTitle;
    public RUIScrollableRichTextArea strategyText;

    public Administration();

    public int ActiveStrategyCount { get; }
    public int MaxActiveStrategies { get; }
    public float MaxStrategyCommitLevel { get; }
    public Administration.StrategyWrapper SelectedWrapper { get; }

    public void RedrawPanels();
    public void SetSelectedStrategy(Administration.StrategyWrapper wrapper);
    public void UnselectStrategy();

    public class StrategyWrapper
    {
        public StrategyWrapper(Strategy strategy, AdministrationStrategyListIcon stratListIcon);
        public StrategyWrapper(Strategy strategy, RUIToggleButton button);

        public RUIToggleButton button { get; }
        public RUIToggleButton ButtonInUse { get; }
        public Strategy strategy { get; }
        public AdministrationStrategyListIcon stratListIcon { get; }

        public void OnFalse();
        public void OnTrue();
    }
}
