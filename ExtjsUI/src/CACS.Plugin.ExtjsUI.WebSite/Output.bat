@ echo off

md %2output\bin\"
echo %date% - %time% > %2\output\bin\remark.txt
md %2output\Plugins\%1"

copy bin\CACS.Plugin.ExtjsUI.dll					%2\output\Plugins\%1
copy bin\CACS.Plugin.ExtjsUI.Services.dll			%2\output\Plugins\%1
copy bin\CACS.Plugin.ExtjsUI.WebSite.dll			%2\output\Plugins\%1
copy bin\Description.xml							%2\output\Plugins\%1

@ echo.