using Blazored.TextEditor;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using XpertStudio.Common.Controls;
using XpertStudio.Common.Functions;
using XS.WinForms.Controls;

namespace BlazorPWA.Client.Pages
{
    public partial class XSTextEditorLocal : BlazoredTextEditor, IXSCommonInput<string>, IXpertEntryBase
    {
        private string? _Text;
        public string? Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                LoadContent(value).AndForget();
                _Text = XpertCommonFunctions.myCstr(_Text);
            }
        }
        private bool _Enabled;
        public bool Enabled
        {
            get { return _Enabled; }
            set
            {
                _Enabled = value;
                this.EnableEditor(value).AndForget();
            }
        }
        private string? _Value;
        public string? Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public string? Label
        {
            get { return Placeholder; }
            set { Placeholder = value; }
        }

        //IXpertEntryBase
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Field Name: Name of the field in class as well as database.")]
        [DisplayName("Field Name")]
        public string? Field_Name { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Display Name: Name by which the field will be visible to end user on screen.")]
        [DisplayName("Display Name")]
        public string? Display_Name { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Field Description: Any description to describe the field.")]
        [DisplayName("Field Description")]
        public string? Field_Description { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Column Name: Name of the column of in database mapped with field.")]
        [DisplayName("Column Name")]
        public string? Column_Name { get; set; }

        [Browsable(true), ReadOnly(false)]
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Metadata Type: Auto/Manual/NotMapped.")]
        [DisplayName("Metadata Type")]
        public XpertMetadataTypes? Metadata_Type { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Calculative: select whether field is calculative(Yes or No)")]
        public bool Calculative { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Calculation Type: select None/Database/Designer/Both")]
        [DisplayName("Calculation Type")]
        public CalculationTypes Calculation_Type { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Calculation Expression: Enter formula/expression for Calculation")]
        [DisplayName("Calculation Expression")]
        public string? Calculation_Expression { get; set; }

        [Browsable(false)]
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("MendatroryField: select whether field is mandatory or optional(Yes or No)")]
        [DisplayName("Mandatory")]
        public bool MendatroryField { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Field_Type: select Domain Field Type from the list.")]
        [DisplayName("Field Domain Type")]
        public XpertFieldTypes Field_Type { get; set; }


        private XpertFieldCreateOptions _Create_Option;
        [DisplayName("Create Option")]
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Create Option: select physical existence of the field in different layers of the application.")]
        public XpertFieldCreateOptions Create_Option
        {
            get { return _Create_Option; }
            set { _Create_Option = value; }
        }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Custom Data?: Select true if the control have a separate logic for to format its value at Model layer.")]
        [DisplayName("Custom Data?")]
        public bool Custom_Data
        {
            get;
            set;
        }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control Name: Name of the control.")]
        [DisplayName("Custom Format?")]
        public bool Custom_Default { get; set; }


        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control Name: Name of the control.")]
        [DisplayName("Control Name")]
        public string? Control_Name
        {
            get;
            set;
        }

        private ControlGroups _Control_Group;
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control_Group: Read only property of the control group")]
        [ReadOnly(true)]
        [DisplayName("Control Group")]
        public ControlGroups Control_Group
        {
            get { return ControlGroups.DataEntry; }
            set { _Control_Group = value; }
        }

        private ControlTypes _Control_Type;
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control_Type: Read only property of the control Type")]
        [ReadOnly(true)]
        [DisplayName("Control Type")]
        public ControlTypes Control_Type
        {
            get { return ControlTypes.TextEditor; }
            set { _Control_Type = value; }
        }


        private XS_SkipTypes _XS_Skip;

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Skip Code Generation: Select Skip Type to skip the standard code generation of XpertStudio to customize selected field and associated property.")]
        [DisplayName("Skip Code Generation")]
        public XS_SkipTypes XS_Skip
        {
            get
            {
                return _XS_Skip;
            }
            set
            {
                _XS_Skip = value;
                //Visible = !value;
            }
        }
        [NotMapped]
        [Browsable(false)]
        public bool Generated { get; set; }

        private string? _XSMapper_Control;
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Mapped Control: Respective Blazor control for WinForms controls and WinForms control for Web Controls.")]
        [DisplayName("Mapped Control")]
        [Browsable(false)]
        public virtual string? XSMapper_Control
        {
            get
            {
                if (XpertCommonFunctions.myLen(_XSMapper_Control) <= 0)
                {
                    _XSMapper_Control = "XpertTextEditor";
                }
                return _XSMapper_Control;
            }
            set
            {
                _XSMapper_Control = value;
            }
        }
        public int TabIndex { get; set; }
    }
}
