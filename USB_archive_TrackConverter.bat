chcp 1251
call rem_cache.bat
set day=%DATE:~0,2%
set month=%DATE:~3,2%
set year=%DATE:~6,4%
"C:\Program Files\7-Zip\7z.exe" a -tzip -ssw -mx7 -r0 -x@exclusions_arhive_project.txt "J:\TrackConverter_%day%-%month%-%year%.zip" "D:\Clouds\Projects\CS\TrackConverter"