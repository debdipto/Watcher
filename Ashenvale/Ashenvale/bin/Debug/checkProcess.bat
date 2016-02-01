tasklist /FI "IMAGENAME eq myapp.exe" 2>NUL | find /I /N "myapp.exe">NUL
if "%ERRORLEVEL%"=="0" echo Programm is running