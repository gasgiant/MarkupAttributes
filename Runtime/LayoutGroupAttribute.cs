using System;

namespace MarkupAttributes
{
    public abstract class LayoutGroupAttribute : Attribute
    {
        public string Path { get; protected set; }
        public LayoutGroupType Type { get; protected set; }
        public MarkupHeaderStyle HeaderStyle { get; protected set; } 
        public MarkupBodyStyle BodyStyle { get; protected set; } 
        public float LabelWidth { get; protected set; }
        public string[] Tabs { get; protected set; }
        public ConditionDescriptor Condition { get; protected set; }
        public bool Toggle { get; protected set; }
        public string ToggleShaderKeyword { get; protected set; }

        public bool HasCondition => Type == LayoutGroupType.DisableIf
            || Type == LayoutGroupType.HideIf;
    }

    public enum LayoutGroupType
    {
        LocalScope,
        Vertical,
        Horizontal,
        TabScope,
        Tab,
        DisableIf,
        HideIf
    }

    public enum MarkupHeaderStyle
    {
        None,
        Label,
        Foldable
    }

    public enum MarkupBodyStyle
    {
        None,
        SeparatorLine,
        ContentBox,
        Box
    }
}



