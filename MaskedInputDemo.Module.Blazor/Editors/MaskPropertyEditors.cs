using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using System;

namespace MaskedInputDemo.Module.Blazor.Editors
{
    [PropertyEditor(typeof(string), false)]
    public class CustomTextMaskPropertyEditor : BlazorPropertyEditorBase
    {
        public CustomTextMaskPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new TextMaskAdapter(new TextMaskModel());
    }

    [PropertyEditor(typeof(decimal), false)]
    public class CustomNumericMaskPropertyEditor : BlazorPropertyEditorBase
    {
        public CustomNumericMaskPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new NumericMaskAdapter(new NumericMaskModel());
    }
    [PropertyEditor(typeof(string),false)]
    public class CustomDateTimeMaskPropertyEditor : BlazorPropertyEditorBase
    {
        public CustomDateTimeMaskPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new DateTimeMaskAdapter(new TextMaskModel());
    }
    [PropertyEditor(typeof(string), false)]
    public class CustomEmailMaskPropertyEditor : BlazorPropertyEditorBase
    {
        public CustomEmailMaskPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new EmailMaskAdapter(new TextMaskModel());
    }
}
