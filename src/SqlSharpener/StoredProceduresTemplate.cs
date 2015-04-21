﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SqlSharpener
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class StoredProceduresTemplate : StoredProceduresTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 11 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"

  /// This creates a pre-compiled template that can be called from
  /// within a project to generate C# wrappers for stored procedures.

  var helper = new SqlSharpenerHelper();
  var meta = new MetaBuilder(sqlPaths.ToArray());
  meta.ProcedurePrefix = procedurePrefix ?? "";

/////////////////Begin Template//////////////////
 
            
            #line default
            #line hidden
            this.Write(@"// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by SqlSharpener.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ");
            
            #line 29 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetNamespace(outputNamespace)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tusing System;\r\n\tusing System.IO;\r\n\tusing System.Data;\r\n\tusing System.Data.S" +
                    "qlClient;\r\n\tusing System.Configuration;\r\n\tusing System.Collections.Generic;\r\n\r\n\t" +
                    "public interface IStoredProcedures\r\n\t{\r\n");
            
            #line 40 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
foreach(var proc in meta.Procedures){ 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 41 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetReturnType(proc)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 41 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(proc.Name));
            
            #line default
            #line hidden
            this.Write("( ");
            
            #line 41 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetMethodParamList(proc)));
            
            #line default
            #line hidden
            this.Write(" );\r\n");
            
            #line 42 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t}\r\n\r\n\tpublic partial class StoredProcedures : IStoredProcedures\r\n\t{\r\n");
            
            #line 47 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
foreach(var proc in meta.Procedures){ 
            
            #line default
            #line hidden
            this.Write("\t\t/// <summary>Calls the \"");
            
            #line 48 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(proc.RawName));
            
            #line default
            #line hidden
            this.Write("\" stored procedure</summary>\r\n\t\tpublic ");
            
            #line 49 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetReturnType(proc)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 49 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(proc.Name));
            
            #line default
            #line hidden
            this.Write("( ");
            
            #line 49 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetMethodParamList(proc)));
            
            #line default
            #line hidden
            this.Write(" )\r\n\t\t{\r\n\t\t\t");
            
            #line 51 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetReturnVariable(proc)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tvar connectionString = ConfigurationManager.ConnectionStrings[\"");
            
            #line 52 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetConnStrVar(connectionStringVariableName)));
            
            #line default
            #line hidden
            this.Write("\"].ConnectionString;\r\n\t\t\tusing(var conn = new SqlConnection(connectionString))\r\n\t" +
                    "\t\t{\r\n\t\t\t\tconn.Open();\r\n\t\t\t\tusing (var cmd = conn.CreateCommand())\r\n\t\t\t\t{\r\n\t\t\t\t\tc" +
                    "md.CommandType = CommandType.StoredProcedure;\r\n\t\t\t\t\tcmd.CommandText = \"");
            
            #line 59 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(proc.RawName));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 60 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetSqlParamList(proc, 5)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 61 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetExecuteStatement(proc, 5)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t}\r\n\t\t\t\tconn.Close();\r\n\t\t\t}\r\n\t\t\treturn result;\r\n\t\t}\r\n\r\n");
            
            #line 68 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write(@"
		/// <summary>Helper function to get the bytes out of varbinary columns</summary>
		private byte[] GetBytes(IDataReader reader, int ordinal)
		{
			MemoryStream ms = new MemoryStream();
			BinaryWriter writer = new BinaryWriter(ms);
			byte[] buffer = new byte[1024];
			long blobSize = reader.GetBytes(ordinal, 0, null, 0, 0);
			long currPos = 0;
			while (currPos < blobSize) {
				currPos += reader.GetBytes(ordinal, currPos, buffer, 0, 1024);
				writer.Write(buffer);
				writer.Flush();
			}
			writer.Close();
			return ms.ToArray();
		}
	}

");
            
            #line 88 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
foreach(var proc in meta.Procedures){ 
            
            #line default
            #line hidden
            
            #line 89 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(helper.GetDtoObject(proc, 1)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 90 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Users\M139798\Documents\Visual Studio 2013\Projects\src\SqlSharpener\StoredProceduresTemplate.tt"

private string _outputNamespaceField;

/// <summary>
/// Access the outputNamespace parameter of the template.
/// </summary>
private string outputNamespace
{
    get
    {
        return this._outputNamespaceField;
    }
}

private string _connectionStringVariableNameField;

/// <summary>
/// Access the connectionStringVariableName parameter of the template.
/// </summary>
private string connectionStringVariableName
{
    get
    {
        return this._connectionStringVariableNameField;
    }
}

private string _procedurePrefixField;

/// <summary>
/// Access the procedurePrefix parameter of the template.
/// </summary>
private string procedurePrefix
{
    get
    {
        return this._procedurePrefixField;
    }
}

private global::System.Collections.Generic.List<string> _sqlPathsField;

/// <summary>
/// Access the sqlPaths parameter of the template.
/// </summary>
private global::System.Collections.Generic.List<string> sqlPaths
{
    get
    {
        return this._sqlPathsField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool outputNamespaceValueAcquired = false;
if (this.Session.ContainsKey("outputNamespace"))
{
    this._outputNamespaceField = ((string)(this.Session["outputNamespace"]));
    outputNamespaceValueAcquired = true;
}
if ((outputNamespaceValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("outputNamespace");
    if ((data != null))
    {
        this._outputNamespaceField = ((string)(data));
    }
}
bool connectionStringVariableNameValueAcquired = false;
if (this.Session.ContainsKey("connectionStringVariableName"))
{
    this._connectionStringVariableNameField = ((string)(this.Session["connectionStringVariableName"]));
    connectionStringVariableNameValueAcquired = true;
}
if ((connectionStringVariableNameValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("connectionStringVariableName");
    if ((data != null))
    {
        this._connectionStringVariableNameField = ((string)(data));
    }
}
bool procedurePrefixValueAcquired = false;
if (this.Session.ContainsKey("procedurePrefix"))
{
    this._procedurePrefixField = ((string)(this.Session["procedurePrefix"]));
    procedurePrefixValueAcquired = true;
}
if ((procedurePrefixValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("procedurePrefix");
    if ((data != null))
    {
        this._procedurePrefixField = ((string)(data));
    }
}
bool sqlPathsValueAcquired = false;
if (this.Session.ContainsKey("sqlPaths"))
{
    this._sqlPathsField = ((global::System.Collections.Generic.List<string>)(this.Session["sqlPaths"]));
    sqlPathsValueAcquired = true;
}
if ((sqlPathsValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("sqlPaths");
    if ((data != null))
    {
        this._sqlPathsField = ((global::System.Collections.Generic.List<string>)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class StoredProceduresTemplateBase
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
