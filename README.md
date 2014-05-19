Dnv.ReSharper.Plugins.LowerSecond
=================================

Very small ReSharper 6.1 plugin. Introduces a new macro. 
Value of another variable with the first character replaced with '_' and second character in lower case. 
Example: IApplicationSettings => _applicationSettings"

#Installation

1. Build the solution. You can choose not to build Tests project by right clicking on it and select "Unload Project".
2. Copy Dnv.ReSharper.Plugins.LowerSecond.dll to c:\Program Files (x86)\JetBrains\ReSharper\v6.1\Bin\Plugins\LowerSecond.

#Can be used with Moq.

Create new live template with this text:

    private Mock<$Interface$> $mockName$;
    
Select value "Guess type expected at this point" for $Interface$ and "Value of another variable with the first character replaced with '_' and second character in lower case" for $mockName$.


