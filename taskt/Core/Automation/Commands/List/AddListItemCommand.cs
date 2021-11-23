﻿using System;
using System.Linq;
using System.Xml.Serialization;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using taskt.UI.CustomControls;
using taskt.UI.Forms;

namespace taskt.Core.Automation.Commands
{
    [Serializable]
    [Attributes.ClassAttributes.Group("List Commands")]
    [Attributes.ClassAttributes.Description("This command allows you to add list item.")]
    [Attributes.ClassAttributes.UsesDescription("Use this command when you want to add list item.  You can even use variables to modify other variables.")]
    [Attributes.ClassAttributes.ImplementationDescription("This command implements actions against VariableList from the scripting engine.")]
    public class AddListItemCommand : ScriptCommand
    {
        [XmlAttribute]
        [Attributes.PropertyAttributes.PropertyDescription("Please select a List Variable Name to modify")]
        [Attributes.PropertyAttributes.InputSpecification("Select or provide a variable from the variable list")]
        [Attributes.PropertyAttributes.SampleUsage("**vList** or **{{{vList}}}**")]
        [Attributes.PropertyAttributes.Remarks("If you have enabled the setting **Create Missing Variables at Runtime** then you are not required to pre-define your variables, however, it is highly recommended.")]
        [Attributes.PropertyAttributes.PropertyUIHelper(Attributes.PropertyAttributes.PropertyUIHelper.UIAdditionalHelperType.ShowVariableHelper)]
        [Attributes.PropertyAttributes.PropertyRecommendedUIControl(Attributes.PropertyAttributes.PropertyRecommendedUIControl.RecommendeUIControlType.ComboBox)]
        [Attributes.PropertyAttributes.PropertyInstanceType(Attributes.PropertyAttributes.PropertyInstanceType.InstanceType.List)]
        public string v_ListName { get; set; }

        [XmlAttribute]
        [Attributes.PropertyAttributes.PropertyDescription("Please define the input to be added to the variable")]
        [Attributes.PropertyAttributes.PropertyUIHelper(Attributes.PropertyAttributes.PropertyUIHelper.UIAdditionalHelperType.ShowVariableHelper)]
        [Attributes.PropertyAttributes.InputSpecification("Enter the input that the variable's value should be set to.")]
        [Attributes.PropertyAttributes.SampleUsage("**Hello** or **{{{vValue}}}**")]
        [Attributes.PropertyAttributes.Remarks("You can use variables in input if you encase them within brackets {{{vName}}}.  You can also perform basic math operations.")]
        [Attributes.PropertyAttributes.PropertyShowSampleUsageInDescription(true)]
        public string v_Input { get; set; }
        public AddListItemCommand()
        {
            this.CommandName = "AddListItemCommand";
            this.SelectionName = "Add List Item";
            this.CommandEnabled = true;
            this.CustomRendering = true;
        }

        public override void RunCommand(object sender)
        {
            //get sending instance
            var engine = (Core.Automation.Engine.AutomationEngineInstance)sender;

            //var requiredVariable = LookupVariable(engine);
            ////if still not found and user has elected option, create variable at runtime
            //if ((requiredVariable == null) && (engine.engineSettings.CreateMissingVariablesDuringExecution))
            //{
            //    engine.VariableList.Add(new Script.ScriptVariable() { VariableName = v_userVariableName });
            //    requiredVariable = LookupVariable(engine);
            //}

            var requiredVariable = v_ListName.GetRawVariable(engine);

            if (requiredVariable == null)
            {
                throw new Exception("Attempted to add data to a variable, but the variable was not found. Enclose variables within brackets, ex. {vVariable}");
            }
            if (!(requiredVariable.VariableValue is List<string>))
            {
                throw new Exception(v_ListName + " is not List or not-supported List");
            }

            var lst = (List<string>)requiredVariable.VariableValue;
            var variableInput = v_Input.ConvertToUserVariable(sender);
            lst.Add(variableInput);

            //if (requiredVariable.VariableValue is List<string>)
            //{
            //    var existingList = (List<string>)requiredVariable.VariableValue;
            //    existingList.Add(variableInput);
            //}
            //else
            //{
            //    var itemList = new List<string>();

            //    if (requiredVariable.GetDisplayValue() != "")
            //        itemList.Add(requiredVariable.GetDisplayValue());

            //    itemList.Add(variableInput);

            //    requiredVariable.VariableValue = itemList;

            //}
        }

        private Script.ScriptVariable LookupVariable(Core.Automation.Engine.AutomationEngineInstance sendingInstance)
        {
            //search for the variable
            var requiredVariable = sendingInstance.VariableList.Where(var => var.VariableName == v_ListName).FirstOrDefault();

            //if variable was not found but it starts with variable naming pattern
            if ((requiredVariable == null) && (v_ListName.StartsWith(sendingInstance.engineSettings.VariableStartMarker)) && (v_ListName.EndsWith(sendingInstance.engineSettings.VariableEndMarker)))
            {
                //reformat and attempt
                var reformattedVariable = v_ListName.Replace(sendingInstance.engineSettings.VariableStartMarker, "").Replace(sendingInstance.engineSettings.VariableEndMarker, "");
                requiredVariable = sendingInstance.VariableList.Where(var => var.VariableName == reformattedVariable).FirstOrDefault();
            }

            return requiredVariable;
        }

        public override string GetDisplayValue()
        {
            return base.GetDisplayValue() + " [Add List Item List: '" + v_Input + "', Item: '" + v_ListName + "']";
        }

        public override List<Control> Render(UI.Forms.frmCommandEditor editor)
        {
            //custom rendering
            base.Render(editor);

            //create control for variable name
            //RenderedControls.Add(CommandControls.CreateDefaultLabelFor("v_userVariableName", this));
            //var VariableNameControl = CommandControls.CreateStandardComboboxFor("v_userVariableName", this).AddVariableNames(editor);
            //RenderedControls.AddRange(CommandControls.CreateUIHelpersFor("v_userVariableName", this, new Control[] { VariableNameControl }, editor));
            //RenderedControls.Add(VariableNameControl);

            //RenderedControls.AddRange(CommandControls.CreateDefaultInputGroupFor("v_Input", this, editor));

            var ctrls = CommandControls.MultiCreateInferenceDefaultControlGroupFor(this, editor);
            RenderedControls.AddRange(ctrls);

            return RenderedControls;
        }

        public override bool IsValidate(frmCommandEditor editor)
        {
            base.IsValidate(editor);

            if (String.IsNullOrEmpty(this.v_ListName))
            {
                this.validationResult += "List variable is empty.\n";
                this.IsValid = false;
            }

            return this.IsValid;
        }
    }
}