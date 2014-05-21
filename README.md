Dnv.ReSharper.Plugins.LowerSecond
=================================

Very small ReSharper 6.1 plugin. Introduces a new macro. 
Value of another variable with the first character replaced with '_' and second character in lower case. 
Example: IApplicationSettings => _applicationSettings

#Installation

1. Build the solution. You can choose not to build Tests project by right clicking on it and selecting "Unload Project".
2. Copy Dnv.ReSharper.Plugins.LowerSecond.dll to c:\Program Files (x86)\JetBrains\ReSharper\v6.1\Bin\Plugins

#Usage

Create new live template. In VS main menu: ReSharper->Templates Explorer, then in "Live Templates" tab press "New Template" and fill the text like in the picture below:

![](https://dl.dropboxusercontent.com/u/4554470/retempl.png)
    
Select value _"Guess type expected at this point"_ for $Interface$ and _"Value of another variable with the first character replaced with '_' _and second character in lower case"_ for $mockName$.

In code editor type _moqf_

![](https://dl.dropboxusercontent.com/u/4554470/retempl_templ.png)

then presss enter and start typing the interface name in the template specification, you will get field automatically renamed:

![](https://dl.dropboxusercontent.com/u/4554470/retempl_result.png)



