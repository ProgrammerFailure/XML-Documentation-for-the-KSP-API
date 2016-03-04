#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

public class CurrencyModifierQuery
{
    public TransactionReasons reason;

    public CurrencyModifierQuery(TransactionReasons reason, float f0, float s0, float r0);

    public void AddDelta(Currency c, float val);
    public float GetEffectDelta(Currency c);
    public string GetEffectDeltaText(Currency c, string format, CurrencyModifierQuery.TextStyling textStyle = CurrencyModifierQuery.TextStyling.None);
    public string GetEffectPercentageText(Currency c, string format, CurrencyModifierQuery.TextStyling textStyle = CurrencyModifierQuery.TextStyling.None);
    public float GetInput(Currency c);
    public static CurrencyModifierQuery RunQuery(TransactionReasons reason, float f0, float s0, float r0);

    public enum TextStyling
    {
        None = 0,
        OnGUI = 1,
        EzGUIRichText = 2,
        OnGUI_LessIsGood = 3,
        EzGUIRichText_LessIsGood = 4,
    }
}
