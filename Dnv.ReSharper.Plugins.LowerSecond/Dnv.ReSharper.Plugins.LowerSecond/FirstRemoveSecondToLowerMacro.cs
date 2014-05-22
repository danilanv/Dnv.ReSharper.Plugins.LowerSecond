﻿using System.Collections.Generic;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace Dnv.ReSharper.Plugins.LowerSecond
{
    [Macro("CustomTemplateMacros.FirstDeleteSecondToLowerMacro",
        ShortDescription = "Value of {#0:another variable} with the first character removed and second character in lower case.",
        LongDescription = "Value of {#0:another variable} with the first character removed and second character in lower case. Example: IApplicationSettings => applicationSettings")]
    public class FirstRemoveSecondToLowerMacro : IMacro
    {
        private readonly ParameterInfo[] _parameters = new ParameterInfo[1] { new ParameterInfo(ParameterType.VariableReference) };

        public FirstRemoveSecondToLowerMacro()
        {
            _parameters = new ParameterInfo[1] { new ParameterInfo(ParameterType.VariableReference) { } };
        }


        public string GetPlaceholder(IDocument document)
        {
            return "_a";
        }

        public bool HandleExpansion(IHotspotContext context, IList<string> arguments)
        {
            return false;
        }

        public HotspotItems GetLookupItems(IHotspotContext context, IList<string> arguments)
        {
            return null;
        }

        public string EvaluateQuickResult(IHotspotContext context, IList<string> arguments)
        {
            if (arguments.Count == 1)
            {
                var arg = arguments[0];

                if (arg.Length == 1)
                    return arg[0].ToString().ToLower();

                if (arg.Length >= 2)
                {
                    var result = arg[1].ToString().ToLower();
                    if (arg.Length > 2)
                        result += arg.Substring(2);

                    return result;
                }
            }

            return "";
        }

        public ParameterInfo[] Parameters
        {
            get { return _parameters; }
        }
    }
}
