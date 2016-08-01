@ echo off

md %2output\bin\"
echo %date% - %time% > %2\output\bin\remark.txt
md %2output\Plugins\%1"

copy bin\CACS.Plugin.Enterprise.dll					%2\output\Plugins\%1
copy bin\CACS.Plugin.Enterprise.Services.dll		%2\output\Plugins\%1
copy bin\CACS.Plugin.Enterprise.WebSite.dll			%2\output\Plugins\%1
copy bin\Description.xml							%2\output\Plugins\%1

@ echo.