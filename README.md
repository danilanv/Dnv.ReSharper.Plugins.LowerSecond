Dnv.ReSharper.Plugins.LowerSecond
=================================

Very small ReSharper 6.1 plugin. Introduces a new macro. 
Value of another variable with the first character replaced with '_' and second character in lower case. 
Example: IApplicationSettings => _applicationSettings"

#Installation

1. Build the solution. You can choose not to build Tests project by right clicking on it and select "Unload Project".
2. Copy Dnv.ReSharper.Plugins.LowerSecond.dll to c:\Program Files (x86)\JetBrains\ReSharper\v6.1\Bin\Plugins\LowerSecond.

#Usage

Create new live template. In VS main menu: ReSharper->Templates Explorer, then in "Live Templates" tab press "New Template" and fill the text like in the picture below:

https://dl.dropboxusercontent.com/u/4554470/retempl.png
    
Select value "Guess type expected at this point" for $Interface$ and "Value of another variable with the first character replaced with '_' and second character in lower case" for $mockName$.

https://dl.dropboxusercontent.com/u/4554470/retempl_choose_macro.png

then press another variable

https://dl.dropboxusercontent.com/u/4554470/retempl_value.png

and choose Interface 

https://dl.dropboxusercontent.com/u/4554470/retempl_choose%20var_ref.png




