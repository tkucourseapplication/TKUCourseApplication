# TKUCourseApplication
This is a program to help you on TKU curriculum online system.

[TKU Curriculum Online System(Chinese)](http://www.ais.tku.edu.tw/elecos/)  [TKU Curriculum Online System(English)](http://www.ais.tku.edu.tw/EleCos_English/loginE.aspx)

This program only provides ease of enrollment, developer for not assume any responsibility for the following conditions:

1. Any error when using this program (including the program crashes, the school system revision, etc.).

2. The use of any improper use.

3. The breakdown of the above statements since many developers retain the final interpretation.

![image](http://i.imgur.com/iXwweYR.png)

# [Executable File Download](https://sourceforge.net/projects/tkucourseapplication/files/latest/download)

Before excute the file, you need to install the Microsoft .NET Framework 3.5.([click here](https://www.microsoft.com/en-us/download/details.aspx?id=21) to download)

# The Application Using Method

Please use “>”, “#” and ”,” these symbols to separate your course codes.

※“,” is your region divide symbol\n※“>” is your order divide symbol

※“#” is drop course symbol, should be used at the beginning of the course code, be extra careful using this!!

#Course Code Input Example : 

0000>1111>2222,#3333,4444,5555>6666,7777>#8888>9999,1234>#2345>3456

If course 0000,4444,5555,6666,7777 are full, the application will execute as fellow :

-> Add 0000 (full, use alternate) 

-> Add 1111(success, jump to the next region)

->Drop 3333(always drop)

->Add 4444(full, always add)

->Add 5555(full, use alternate)

->Add 6666(full, no alternative just jump to the next region)

->Add 7777(full, use alternate)

->Drop 8888(always drop and use next alternate)

->Add 9999(success, jump to the next)

->Add 1234(success, jump to the next)

-> end(no next region)

Before you click the start button, it will jump the message box to confirm your command.

![image](http://i.imgur.com/dlO2tEw.png)
