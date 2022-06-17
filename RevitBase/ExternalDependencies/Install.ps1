$addinsFolder = "C:\ProgramData\Autodesk\Revit\Addins"

foreach ($i in Get-ChildItem -Path $addinsFolder -Recurse)
{
     if (($i.Name -notmatch "^20[0-9][0-9]$"))
     {
        continue;
     }
     Get-ChildItem -Path ./Addins | Copy-Item -Destination $i.FullName

     Write-Host "added to: " $i " Revit Plugins"
}

pause