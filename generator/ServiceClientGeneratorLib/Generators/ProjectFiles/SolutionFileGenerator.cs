﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class SolutionFileGenerator : SolutionFileGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.30723.0
MinimumVisualStudioVersion = 10.0.40219.1
Project(""{2150E333-8FDC-42A3-9474-1A3956D46DE8}"") = ""Core"", ""Core"", ""{1523203C-CD16-4B4A-8F9D-8ECCA3A327AA}""
EndProject
Project(""{2150E333-8FDC-42A3-9474-1A3956D46DE8}"") = ""Services"", ""Services"", ""{03245B8D-0A27-4C11-9AAC-7047A9F6DFB0}""
EndProject
Project(""{2150E333-8FDC-42A3-9474-1A3956D46DE8}"") = ""Tests"", ""Tests"", ""{AAB6968E-1FCE-47C8-B34C-4850E27458F1}""
EndProject
");
            
            #line 16 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    foreach(var project in (List<SolutionFileCreator.Project>)this.Session["CoreProjects"])
    {

            
            #line default
            #line hidden
            this.Write("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"");
            
            #line 20 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 20 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectPath));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 20 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 22 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    }

    foreach(var folder in (List<SolutionFileCreator.ServiceSolutionFolder>)this.Session["ServiceSolutionFolders"])
    {

            
            #line default
            #line hidden
            this.Write("Project(\"{2150E333-8FDC-42A3-9474-1A3956D46DE8}\") = \"");
            
            #line 28 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 28 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 28 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 30 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"


        foreach(var project in folder.Projects)
        { 

            
            #line default
            #line hidden
            this.Write("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"");
            
            #line 35 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 35 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectPath));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 35 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 37 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

        }
    }

            
            #line default
            #line hidden
            
            #line 41 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    foreach(var project in (List<SolutionFileCreator.Project>)this.Session["TestProjects"])
    {

            
            #line default
            #line hidden
            this.Write("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"");
            
            #line 45 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 45 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectPath));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 45 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 47 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    }

            
            #line default
            #line hidden
            this.Write("Global\r\n\tGlobalSection(SolutionConfigurationPlatforms) = preSolution\r\n");
            
            #line 52 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    foreach (var c in (List<string>)this.Session["Configurations"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 56 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(c));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 56 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(c));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 57 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    }

            
            #line default
            #line hidden
            this.Write("\tEndGlobalSection\r\n    GlobalSection(ProjectConfigurationPlatforms) = postSolutio" +
                    "n\r\n");
            
            #line 62 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    var allProjectConfigurations = this.Session["AllProjects"] as Dictionary<string, ProjectFileCreator.ProjectConfigurationData>;
    foreach(var project in (List<SolutionFileCreator.Project>)this.Session["CoreProjects"])
    {
        var projectConfigurations = allProjectConfigurations[project.Name];
        foreach (var config in projectConfigurations.ConfigurationPlatforms)
        {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 70 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 70 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write(".ActiveCfg = ");
            
            #line 70 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 71 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 71 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write(".Build.0 = ");
            
            #line 71 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 72 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

        }
    }

    foreach(var folder in (List<SolutionFileCreator.ServiceSolutionFolder>)this.Session["ServiceSolutionFolders"])
    {
        foreach(var project in folder.Projects)
        { 
            var projectConfigurations = allProjectConfigurations[project.Name];
            foreach (var config in projectConfigurations.ConfigurationPlatforms)
            {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 84 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 84 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write(".ActiveCfg = ");
            
            #line 84 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 85 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 85 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write(".Build.0 = ");
            
            #line 85 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 86 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

            }
        }
    }

            
            #line default
            #line hidden
            
            #line 91 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    foreach(var project in (List<SolutionFileCreator.Project>)this.Session["TestProjects"])
    {
        var projectConfigurations = allProjectConfigurations[project.Name];
        foreach (var config in projectConfigurations.ConfigurationPlatforms)
        {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 98 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 98 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write(".ActiveCfg = ");
            
            #line 98 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 99 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 99 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write(".Build.0 = ");
            
            #line 99 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(config));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 100 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("    EndGlobalSection\r\n\tGlobalSection(SolutionProperties) = preSolution\r\n\t\tHideSol" +
                    "utionNode = FALSE\r\n\tEndGlobalSection\r\n\tGlobalSection(NestedProjects) = preSoluti" +
                    "on\r\n");
            
            #line 109 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    foreach(var project in (List<SolutionFileCreator.Project>)this.Session["CoreProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 113 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = {1523203C-CD16-4B4A-8F9D-8ECCA3A327AA}\r\n");
            
            #line 114 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    }

    foreach(var folder in (List<SolutionFileCreator.ServiceSolutionFolder>)this.Session["ServiceSolutionFolders"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 120 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = {03245B8D-0A27-4C11-9AAC-7047A9F6DFB0}\r\n");
            
            #line 121 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

        foreach(var project in folder.Projects)
        { 

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 125 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 125 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(folder.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 126 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

        }
    }

            
            #line default
            #line hidden
            
            #line 130 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    foreach(var project in (List<SolutionFileCreator.Project>)this.Session["TestProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 134 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = {AAB6968E-1FCE-47C8-B34C-4850E27458F1}\r\n");
            
            #line 135 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\SolutionFileGenerator.tt"

    }

            
            #line default
            #line hidden
            this.Write("\tEndGlobalSection\r\nEndGlobal");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class SolutionFileGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
