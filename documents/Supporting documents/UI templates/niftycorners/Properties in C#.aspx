<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><head><title>C# Station: C# Tutorial Lesson 10 - Properties</title>
    

   

<meta name="description" content="Learn how to apply the C# programming language to build .NET applications with C#Builder and Visual Studio .NET."><meta name="keywords" content="C#, C Sharp, programming language, programming languages, visual studio, visual studio .NET, .NET, ASP.NET, ADO.NET, XML, Web Services, Windows forms, Remoting."><link id="_ctl0_AdaptersInvariantImportCSS" rel="stylesheet" href="Properties%20in%20C%23_files/Import.css" type="text/css"><link href="Properties%20in%20C%23_files/CssLayout.css" rel="stylesheet" type="text/css"><!--[if lt IE 7]>
    <link id="_ctl0_IEMenu6CSS" rel="stylesheet" href="../CSS/BrowserSpecific/IEMenu6.css" type="text/css" />
<![endif]-->
 
<link href="Properties%20in%20C%23_files/CSharpStation.css" type="text/css" rel="stylesheet"><link href="Properties%20in%20C%23_files/GridView.css" type="text/css" rel="stylesheet"><link href="Properties%20in%20C%23_files/Menu.css" type="text/css" rel="stylesheet"><style type="text/css">
	._ctl0_Menu2_0 { background-color:white;visibility:hidden;display:none;position:absolute;left:0px;top:0px; }
	._ctl0_Menu2_1 { color:Black;font-family:Tahoma;font-size:Small;text-decoration:none; }
	._ctl0_Menu2_2 { color:Black;font-family:Tahoma;font-size:Small; }
	._ctl0_Menu2_3 { color:Black;border-style:none; }
	._ctl0_Menu2_4 { border-color:#648ABD;border-width:1px;border-style:Solid;width:9em;padding:3px 2px 3px 2px; }
	._ctl0_Menu2_5 { color:Black;font-size:Small;border-style:none; }
	._ctl0_Menu2_6 { border-color:#648ABD;border-width:1px;border-style:Solid;width:10.5em;padding:3px 2px 3px 2px; }
	._ctl0_Menu2_7 { color:White; }
	._ctl0_Menu2_8 { color:White;background-color:#4682B3; }
	._ctl0_Menu2_9 { color:White;border-style:none; }
	._ctl0_Menu2_10 { color:White;background-color:#4682B3; }

</style><link href="Properties%20in%20C%23_files/n2CoreLibs-n2v1-12794.css" type="text/css" rel="stylesheet"></head><body><div><div id="goPopElem" class="n2Pop" style="display: block; visibility: hidden; left: 0px; top: 0px; position: absolute;" onmouseover="goPop.mouseOver();" onmouseout="goPop.mouseOut(event);" onmousemove="goPop.mouseMove(event);" onmousedown="goPop._click(event);"><div class="n2"><div id="goPopElem_titleBar" class="popStaticTitle" style="visibility: inherit; min-height: 18px; height: 22px;"><div style="margin: 0px; padding: 2px 3px; float: right; background-color: rgb(239, 237, 212);" id="goPopElem_titleBarTd2"><span class="clickable" onclick="goPop.goBack()"><img style="display: none;" id="goPopElem_backBtn" class="clickable" src="Properties%20in%20C%23_files/back-tan-sm.gif" onmousedown="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/back-tan-sm-dn._V46913462_.gif';" onmouseup="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/back-tan-sm._V46922606_.gif';" border="0" height="16" width="46"></span><img style="display: none;" id="goPopElem_backBtnDis" class="clickable" src="Properties%20in%20C%23_files/back-tan-sm-dis.gif" border="0" height="16" width="46"><span class="clickable" onclick="goPop.goForward()"><img style="display: none;" id="goPopElem_nextBtn" class="clickable" src="Properties%20in%20C%23_files/next-tan-sm.gif" onmousedown="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/next-tan-sm-dn._V46686641_.gif';" onmouseup="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/next-tan-sm._V46865265_.gif';" border="0" height="16" width="46"></span><img style="display: none;" id="goPopElem_nextBtnDis" class="clickable" src="Properties%20in%20C%23_files/next-tan-sm-dis.gif" border="0" height="16" width="46"><span class="clickable" onclick="goPop.hide()"><img id="goPopElem_closeX" class="clickable" src="Properties%20in%20C%23_files/close-box-up.gif" onmousedown="this.src='http://z-ecx.images-amazon.com/images/G/01/nav2/images/close-box-down';" onmouseup="this.src='http://z-ecx.images-amazon.com/images/G/01/nav2/images/close-box-up';" border="0" height="15" width="15"></span></div><span style="display: block; padding-left: 0px; padding-top: 0px; background-color: rgb(239, 237, 212);" id="goPopElem_titleBarTitle" class="popTitle"></span></div><div id="goPopElem_main" class="n2PopBody" style="border-style: none solid solid; border-color: rgb(239, 237, 212); border-width: 5px; clear: both;">--CONTENT GOES HERE (static)--</div></div></div></div><a style="z-index: 225; display: none; position: absolute; background-color: transparent;" id="n2SPopClickGrab"></a><div><div id="goN2ExplorerDiv" class="n2Pop" style="display: block; visibility: hidden; left: 0px; top: 0px; position: absolute;" onmouseover="goN2Explorer.mouseOver();" onmouseout="goN2Explorer.mouseOut(event);" onmousemove="goN2Explorer.mouseMove(event);" onmousedown="goN2Explorer._click(event);"><div class="n2"><div id="goN2ExplorerDiv_titleBar" class="popStaticTitle" style="visibility: inherit; min-height: 18px;"><div style="padding: 3px 4px 0pt 0pt; float: right;" id="goN2ExplorerDiv_titleBarTd2"><span class="clickable" onclick="goN2Explorer.goBack()"><img style="display: none;" id="goN2ExplorerDiv_backBtn" class="clickable" src="Properties%20in%20C%23_files/back-tan-sm.gif" onmousedown="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/back-tan-sm-dn._V46913462_.gif';" onmouseup="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/back-tan-sm._V46922606_.gif';" border="0" height="16" width="46"></span><img style="display: none;" id="goN2ExplorerDiv_backBtnDis" class="clickable" src="Properties%20in%20C%23_files/back-tan-sm-dis.gif" border="0" height="16" width="46"><span class="clickable" onclick="goN2Explorer.goForward()"><img style="display: none;" id="goN2ExplorerDiv_nextBtn" class="clickable" src="Properties%20in%20C%23_files/next-tan-sm.gif" onmousedown="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/next-tan-sm-dn._V46686641_.gif';" onmouseup="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/next-tan-sm._V46865265_.gif';" border="0" height="16" width="46"></span><img style="display: none;" id="goN2ExplorerDiv_nextBtnDis" class="clickable" src="Properties%20in%20C%23_files/next-tan-sm-dis.gif" border="0" height="16" width="46"><span class="clickable" onclick="goN2Explorer.hide()"><img id="goN2ExplorerDiv_closeX" class="clickable" src="Properties%20in%20C%23_files/close-tan-sm.gif" onmousedown="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/close-tan-sm-dn._V46881222_.gif';" onmouseup="this.src='http://g-ecx.images-amazon.com/images/G/01/nav2/images/close-tan-sm._V46903531_.gif';" border="0" height="16" width="46"></span></div><span id="goN2ExplorerDiv_titleBarTitle" class="popTitle"></span></div><div id="goN2ExplorerDiv_main" class="n2PopBody" style="clear: both;">--CONTENT GOES HERE (static)--</div></div></div></div>
    <form name="aspnetForm" method="post" action="Lesson10.aspx" id="aspnetForm">
<input name="__VIEWSTATE" id="__VIEWSTATE" value="/wEPDwUJMzkwOTQ2NTExD2QWAmYPZBYCAgMPZBYCAgcQPCsADQIADxYCHgtfIURhdGFCb3VuZGdkDBQrAAcFFzA6MCwwOjEsMDoyLDA6MywwOjQsMDo1FCsAAhYQHgRUZXh0BQRIb21lHgVWYWx1ZQUESG9tZR4LTmF2aWdhdGVVcmwFDS9EZWZhdWx0LmFzcHgeB1Rvb2xUaXAFHE1haW4gQyMgU3RhdGlvbiBMYW5kaW5nIFBhZ2UeB0VuYWJsZWRnHgpTZWxlY3RhYmxlZx4IRGF0YVBhdGgFDS9kZWZhdWx0LmFzcHgeCURhdGFCb3VuZGdkFCsAAhYOHwEFBUFib3V0HwIFBUFib3V0HwQFMExlYXJuIEFib3V0LCBDb21tdW5pY2F0ZSwgYW5kIFN1cHBvcnQgQyMgU3RhdGlvbh8FZx8GaB8HBSQyMGVmYmM4Yy1kMDNhLTQ0ZWUtODVjZS0xYjNhMzk5ODEzNjMfCGcUKwAGBRMwOjAsMDoxLDA6MiwwOjMsMDo0FCsAAhYQHwEFBUFib3V0HwIFBUFib3V0HwMFCy9BYm91dC5hc3B4HwQFH1doYXQgaXMgQXZhaWxhYmxlIGF0IEMjIFN0YXRpb24fBWcfBmcfBwULL2Fib3V0LmFzcHgfCGdkFCsAAhYQHwEFB0NvbnRhY3QfAgUHQ29udGFjdB8DBQ0vQ29udGFjdC5hc3B4HwQFJkNvbW11bmljYXRlIHdpdGggQyMgU3RhdGlvbiBNYW5hZ2VtZW50HwVnHwZnHwcFDS9jb250YWN0LmFzcHgfCGdkFCsAAhYQHwEFB0xpbmsyTWUfAgUHTGluazJNZR8DBQ0vTGluazJNZS5hc3B4HwQFJUluZm9ybWF0aW9uIGZvciBMaW5raW5nIHRvIEMjIFN0YXRpb24fBWcfBmcfBwUNL2xpbmsybWUuYXNweB8IZ2QUKwACFhAfAQUGU3VibWl0HwIFBlN1Ym1pdB8DBQwvU3VibWl0LmFzcHgfBAUjQXNrIEMjIFN0YXRpb24gdG8gTGluayB0byBZb3VyIFNpdGUfBWcfBmcfBwUML3N1Ym1pdC5hc3B4HwhnZBQrAAIWEB8BBRJTdXBwb3J0IEMjIFN0YXRpb24fAgUSU3VwcG9ydCBDIyBTdGF0aW9uHwMFHC9JV2FudFRvU3VwcG9ydFRoaXNTaXRlLmFzcHgfBAUtSWYgWW91IExpa2UgQyMgU3RhdGlvbiBhbmQgV2FudCB0byBTdXBwb3J0IEl0HwVnHwZnHwcFHC9pd2FudHRvc3VwcG9ydHRoaXNzaXRlLmFzcHgfCGdkFCsAAhYOHwEFDUFydGljbGVzL0RvY3MfAgUNQXJ0aWNsZXMvRG9jcx8EBR1BcnRpY2xlcyBhbmQgQyMgRG9jdW1lbnRhdGlvbh8FZx8GaB8HBSRlNDIyODlkMy05ODU0LTRhMWMtOTE5NS00ZWUwNzNlYmQxYzUfCGcUKwADBQcwOjAsMDoxFCsAAhYQHwEFCEFydGljbGVzHwIFCEFydGljbGVzHwMFDi9BcnRpY2xlcy5hc3B4HwQFE0MjIFN0YXRpb24gQXJ0aWNsZXMfBWcfBmcfBwUOL2FydGljbGVzLmFzcHgfCGdkFCsAAhYQHwEFDURvY3VtZW50YXRpb24fAgUNRG9jdW1lbnRhdGlvbh8DBRMvRG9jdW1lbnRhdGlvbi5hc3B4HwQFJkxpbmtzIHRvIEMjIERvY3VtZW50YXRpb24sIFNwZWNzLCBFdGMuHwVnHwZnHwcFEy9kb2N1bWVudGF0aW9uLmFzcHgfCGdkFCsAAhYQHwEFBUJvb2tzHwIFBUJvb2tzHwMFFy9Cb29rcy9Cb29rU2VydmljZS5hc3B4HwQFH0xpc3Qgb2YgTW9zdCBBdmFpbGFibGUgQyMgQm9va3MfBWcfBmcfBwUXL2Jvb2tzL2Jvb2tzZXJ2aWNlLmFzcHgfCGdkFCsAAhYOHwEFBUxpbmtzHwIFBUxpbmtzHwQFK0xpbmtzIHRvIE90aGVyIFVzZWZ1bCBDIyBhbmQgLk5FVCBSZXNvdXJjZXMfBWcfBmgfBwUkNWNiNTUwMWEtNjk3Yy00NWE2LTg4YWYtYTkxY2IxNDc4ODcyHwhnFCsACgUjMDowLDA6MSwwOjIsMDozLDA6NCwwOjUsMDo2LDA6NywwOjgUKwACFhAfAQUHQVNQLk5FVB8CBQdBU1AuTkVUHwMFPC9MaW5rcy9TaG93TGlua3MuYXNweD9jYXQ9QXNwRG90TmV0U2l0ZXMmdGl0bGU9QVNQLk5FVCBTaXRlcx8EBQ1BU1AuTkVUIExpbmtzHwVnHwZnHwcFPC9saW5rcy9zaG93bGlua3MuYXNweD9jYXQ9YXNwZG90bmV0c2l0ZXMmdGl0bGU9YXNwLm5ldCBzaXRlcx8IZ2QUKwACFhAfAQUCQyMfAgUCQyMfAwU5L0xpbmtzL1Nob3dMaW5rcy5hc3B4P2NhdD1DU2hhcnBTaXRlcyZ0aXRsZT1DIFNoYXJwIFNpdGVzHwQFCEMjIExpbmtzHwVnHwZnHwcFOS9saW5rcy9zaG93bGlua3MuYXNweD9jYXQ9Y3NoYXJwc2l0ZXMmdGl0bGU9YyBzaGFycCBzaXRlcx8IZ2QUKwACFhAfAQUELk5FVB8CBQQuTkVUHwMFNi9MaW5rcy9TaG93TGlua3MuYXNweD9jYXQ9RG90TmV0U2l0ZXMmdGl0bGU9Lk5FVCBTaXRlcx8EBQouTkVUIExpbmtzHwVnHwZnHwcFNi9saW5rcy9zaG93bGlua3MuYXNweD9jYXQ9ZG90bmV0c2l0ZXMmdGl0bGU9Lm5ldCBzaXRlcx8IZ2QUKwACFhAfAQUESm9icx8CBQRKb2JzHwMFMi9MaW5rcy9TaG93TGlua3MuYXNweD9jYXQ9Sm9iU2l0ZXMmdGl0bGU9Sm9iIFNpdGVzHwQFCUpvYiBMaW5rcx8FZx8GZx8HBTIvbGlua3Mvc2hvd2xpbmtzLmFzcHg/Y2F0PWpvYnNpdGVzJnRpdGxlPWpvYiBzaXRlcx8IZ2QUKwACFhAfAQUDT09QHwIFA09PUB8DBUkvTGlua3MvU2hvd0xpbmtzLmFzcHg/Y2F0PU9iamVjdE9yaWVudGVkU2l0ZXMmdGl0bGU9T2JqZWN0IE9yaWVudGVkIFNpdGVzHwQFCU9PUCBMaW5rcx8FZx8GZx8HBUkvbGlua3Mvc2hvd2xpbmtzLmFzcHg/Y2F0PW9iamVjdG9yaWVudGVkc2l0ZXMmdGl0bGU9b2JqZWN0IG9yaWVudGVkIHNpdGVzHwhnZBQrAAIWEB8BBQVPdGhlch8CBQVPdGhlch8DBTYvTGlua3MvU2hvd0xpbmtzLmFzcHg/Y2F0PU90aGVyU2l0ZXMmdGl0bGU9T3RoZXIgU2l0ZXMfBAULT3RoZXIgTGlua3MfBWcfBmcfBwU2L2xpbmtzL3Nob3dsaW5rcy5hc3B4P2NhdD1vdGhlcnNpdGVzJnRpdGxlPW90aGVyIHNpdGVzHwhnZBQrAAIWEB8BBQVUb29scx8CBQVUb29scx8DBQsvVG9vbHMuYXNweB8EBTZVc2VmdWwgTGlzdCBvZiBUb29scyB0byBIZWxwIFlvdSBCdWlsZCBDIyBBcHBsaWNhdGlvbnMfBWcfBmcfBwULL3Rvb2xzLmFzcHgfCGdkFCsAAhYQHwEFBlZCLk5FVB8CBQZWQi5ORVQfAwU6L0xpbmtzL1Nob3dMaW5rcy5hc3B4P2NhdD1WYkRvdE5ldFNpdGVzJnRpdGxlPVZCLk5FVCBTaXRlcx8EBQxWQi5ORVQgTGlua3MfBWcfBmcfBwU6L2xpbmtzL3Nob3dsaW5rcy5hc3B4P2NhdD12YmRvdG5ldHNpdGVzJnRpdGxlPXZiLm5ldCBzaXRlcx8IZ2QUKwACFhAfAQUMV2ViIFNlcnZpY2VzHwIFDFdlYiBTZXJ2aWNlcx8DBUIvTGlua3MvU2hvd0xpbmtzLmFzcHg/Y2F0PVdlYlNlcnZpY2VzU2l0ZXMmdGl0bGU9V2ViIFNlcnZpY2UgU2l0ZXMfBAURV2ViIFNlcnZpY2UgTGlua3MfBWcfBmcfBwVCL2xpbmtzL3Nob3dsaW5rcy5hc3B4P2NhdD13ZWJzZXJ2aWNlc3NpdGVzJnRpdGxlPXdlYiBzZXJ2aWNlIHNpdGVzHwhnZBQrAAIWDh8BBQlUdXRvcmlhbHMfAgUJVHV0b3JpYWxzHwQFM0ZSRUUgQURPLk5FVCBhbmQgQyMgVHV0b3JpYWxzIC0gV3JpdHRlbiBieSBKb2UgTWF5bx8FZx8GaB8HBSQwMjdmNDZmMS00N2Q3LTQ5ZGEtOTIyNC00NzhkN2MzNjMzN2UfCGcUKwADBQcwOjAsMDoxFCsAAhYOHwEFFFRoZSBBRE8uTkVUIFR1dG9yaWFsHwIFFFRoZSBBRE8uTkVUIFR1dG9yaWFsHwQFIUdldCBTdGFydGVkIExlYXJuaW5nIEFETy5ORVQgRmFzdB8FZx8GaB8HBSQxN2EwMDA4OC05NTdkLTRmNDItOGQwOS03ZGU4MDk5N2U1ZWUfCGcUKwAIBRswOjAsMDoxLDA6MiwwOjMsMDo0LDA6NSwwOjYUKwACFhAfAQUiTGVzc29uIDAxOiBJbnRyb2R1Y3Rpb24gdG8gQURPLk5FVB8CBSJMZXNzb24gMDE6IEludHJvZHVjdGlvbiB0byBBRE8uTkVUHwMFIi9UdXRvcmlhbHMvQWRvRG90TmV0L0xlc3NvbjAxLmFzcHgfBAUiTGVzc29uIDAxOiBJbnRyb2R1Y3Rpb24gdG8gQURPLk5FVB8FZx8GZx8HBSIvdHV0b3JpYWxzL2Fkb2RvdG5ldC9sZXNzb24wMS5hc3B4HwhnZBQrAAIWEB8BBSNMZXNzb24gMDI6IFRoZSBTcWxDb25uZWN0aW9uIE9iamVjdB8CBSNMZXNzb24gMDI6IFRoZSBTcWxDb25uZWN0aW9uIE9iamVjdB8DBSIvVHV0b3JpYWxzL0Fkb0RvdE5ldC9MZXNzb24wMi5hc3B4HwQFI0xlc3NvbiAwMjogVGhlIFNxbENvbm5lY3Rpb24gT2JqZWN0HwVnHwZnHwcFIi90dXRvcmlhbHMvYWRvZG90bmV0L2xlc3NvbjAyLmFzcHgfCGdkFCsAAhYQHwEFIExlc3NvbiAwMzogVGhlIFNxbENvbW1hbmQgT2JqZWN0HwIFIExlc3NvbiAwMzogVGhlIFNxbENvbW1hbmQgT2JqZWN0HwMFIi9UdXRvcmlhbHMvQWRvRG90TmV0L0xlc3NvbjAzLmFzcHgfBAUgTGVzc29uIDAzOiBUaGUgU3FsQ29tbWFuZCBPYmplY3QfBWcfBmcfBwUiL3R1dG9yaWFscy9hZG9kb3RuZXQvbGVzc29uMDMuYXNweB8IZ2QUKwACFhAfAQUuTGVzc29uIDA0OiBSZWFkaW5nIERhdGEgd2l0aCB0aGUgU3FsRGF0YVJlYWRlch8CBS5MZXNzb24gMDQ6IFJlYWRpbmcgRGF0YSB3aXRoIHRoZSBTcWxEYXRhUmVhZGVyHwMFIi9UdXRvcmlhbHMvQWRvRG90TmV0L0xlc3NvbjA0LmFzcHgfBAUuTGVzc29uIDA0OiBSZWFkaW5nIERhdGEgd2l0aCB0aGUgU3FsRGF0YVJlYWRlch8FZx8GZx8HBSIvdHV0b3JpYWxzL2Fkb2RvdG5ldC9sZXNzb24wNC5hc3B4HwhnZBQrAAIWEB8BBSlMZXNzb24gMDU6IFdvcmtpbmcgd2l0aCBEaXNjb25uZWN0ZWQgRGF0YR8CBSlMZXNzb24gMDU6IFdvcmtpbmcgd2l0aCBEaXNjb25uZWN0ZWQgRGF0YR8DBSIvVHV0b3JpYWxzL0Fkb0RvdE5ldC9MZXNzb24wNS5hc3B4HwQFKUxlc3NvbiAwNTogV29ya2luZyB3aXRoIERpc2Nvbm5lY3RlZCBEYXRhHwVnHwZnHwcFIi90dXRvcmlhbHMvYWRvZG90bmV0L2xlc3NvbjA1LmFzcHgfCGdkFCsAAhYQHwEFKExlc3NvbiAwNjogQWRkaW5nIFBhcmFtZXRlcnMgdG8gQ29tbWFuZHMfAgUoTGVzc29uIDA2OiBBZGRpbmcgUGFyYW1ldGVycyB0byBDb21tYW5kcx8DBSIvVHV0b3JpYWxzL0Fkb0RvdE5ldC9MZXNzb24wNi5hc3B4HwQFKExlc3NvbiAwNjogQWRkaW5nIFBhcmFtZXRlcnMgdG8gQ29tbWFuZHMfBWcfBmcfBwUiL3R1dG9yaWFscy9hZG9kb3RuZXQvbGVzc29uMDYuYXNweB8IZ2QUKwACFhAfAQUiTGVzc29uIDA3OiBVc2luZyBTdG9yZWQgUHJvY2VkdXJlcx8CBSJMZXNzb24gMDc6IFVzaW5nIFN0b3JlZCBQcm9jZWR1cmVzHwMFIi9UdXRvcmlhbHMvQWRvRG90TmV0L0xlc3NvbjA3LmFzcHgfBAUiTGVzc29uIDA3OiBVc2luZyBTdG9yZWQgUHJvY2VkdXJlcx8FZx8GZx8HBSIvdHV0b3JpYWxzL2Fkb2RvdG5ldC9sZXNzb24wNy5hc3B4HwhnZBQrAAIWDh8BBQ9UaGUgQyMgVHV0b3JpYWwfAgUPVGhlIEMjIFR1dG9yaWFsHwQFHEdldCBTdGFydGVkIExlYXJuaW5nIEMjIEZhc3QfBWcfBmgfBwUkMzNjMGMwMjktODk3MS00ZGIzLTk5NjAtM2UyZWI4YTc0MjY3HwhnFCsAFQVZMDowLDA6MSwwOjIsMDozLDA6NCwwOjUsMDo2LDA6NywwOjgsMDo5LDA6MTAsMDoxMSwwOjEyLDA6MTMsMDoxNCwwOjE1LDA6MTYsMDoxNywwOjE4LDA6MTkUKwACFhAfAQUMSW50cm9kdWN0aW9uHwIFDEludHJvZHVjdGlvbh8DBQ4vVHV0b3JpYWwuYXNweB8EBSlJbnRyb2R1Y3Rpb24sIENvbnRlbnRzLCBhbmQgQ29kZSBEb3dubG9hZB8FZx8GZx8HBQ4vdHV0b3JpYWwuYXNweB8IZ2QUKwACFhAfAQUaTGVzc29uIDAxOiBHZXR0aW5nIFN0YXJ0ZWQfAgUaTGVzc29uIDAxOiBHZXR0aW5nIFN0YXJ0ZWQfAwUYL1R1dG9yaWFscy9MZXNzb24wMS5hc3B4HwQFGkxlc3NvbiAwMTogR2V0dGluZyBTdGFydGVkHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDEuYXNweB8IZ2QUKwACFhAfAQUqTGVzc29uIDAyOiBPcGVyYXRvcnMsIFR5cGVzLCBhbmQgVmFyaWFibGVzHwIFKkxlc3NvbiAwMjogT3BlcmF0b3JzLCBUeXBlcywgYW5kIFZhcmlhYmxlcx8DBRgvVHV0b3JpYWxzL0xlc3NvbjAyLmFzcHgfBAUqTGVzc29uIDAyOiBPcGVyYXRvcnMsIFR5cGVzLCBhbmQgVmFyaWFibGVzHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDIuYXNweB8IZ2QUKwACFhAfAQUpTGVzc29uIDAzOiBDb250cm9sIFN0YXRlbWVudHMgLSBTZWxlY3Rpb24fAgUpTGVzc29uIDAzOiBDb250cm9sIFN0YXRlbWVudHMgLSBTZWxlY3Rpb24fAwUYL1R1dG9yaWFscy9MZXNzb24wMy5hc3B4HwQFKUxlc3NvbiAwMzogQ29udHJvbCBTdGF0ZW1lbnRzIC0gU2VsZWN0aW9uHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDMuYXNweB8IZ2QUKwACFhAfAQUlTGVzc29uIDA0OiBDb250cm9sIFN0YXRlbWVudHMgLSBMb29wcx8CBSVMZXNzb24gMDQ6IENvbnRyb2wgU3RhdGVtZW50cyAtIExvb3BzHwMFGC9UdXRvcmlhbHMvTGVzc29uMDQuYXNweB8EBSVMZXNzb24gMDQ6IENvbnRyb2wgU3RhdGVtZW50cyAtIExvb3BzHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDQuYXNweB8IZ2QUKwACFhAfAQUSTGVzc29uIDA1OiBNZXRob2RzHwIFEkxlc3NvbiAwNTogTWV0aG9kcx8DBRgvVHV0b3JpYWxzL0xlc3NvbjA1LmFzcHgfBAUSTGVzc29uIDA1OiBNZXRob2RzHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDUuYXNweB8IZ2QUKwACFhAfAQUVTGVzc29uIDA2OiBOYW1lc3BhY2VzHwIFFUxlc3NvbiAwNjogTmFtZXNwYWNlcx8DBRgvVHV0b3JpYWxzL0xlc3NvbjA2LmFzcHgfBAUVTGVzc29uIDA2OiBOYW1lc3BhY2VzHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDYuYXNweB8IZ2QUKwACFhAfAQUiTGVzc29uIDA3OiBJbnRyb2R1Y3Rpb24gdG8gQ2xhc3Nlcx8CBSJMZXNzb24gMDc6IEludHJvZHVjdGlvbiB0byBDbGFzc2VzHwMFGC9UdXRvcmlhbHMvTGVzc29uMDcuYXNweB8EBSJMZXNzb24gMDc6IEludHJvZHVjdGlvbiB0byBDbGFzc2VzHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDcuYXNweB8IZ2QUKwACFhAfAQUcTGVzc29uIDA4OiBDbGFzcyBJbmhlcml0YW5jZR8CBRxMZXNzb24gMDg6IENsYXNzIEluaGVyaXRhbmNlHwMFGC9UdXRvcmlhbHMvTGVzc29uMDguYXNweB8EBRxMZXNzb24gMDg6IENsYXNzIEluaGVyaXRhbmNlHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDguYXNweB8IZ2QUKwACFhAfAQUXTGVzc29uIDA5OiBQb2x5bW9ycGhpc20fAgUXTGVzc29uIDA5OiBQb2x5bW9ycGhpc20fAwUYL1R1dG9yaWFscy9MZXNzb24wOS5hc3B4HwQFF0xlc3NvbiAwOTogUG9seW1vcnBoaXNtHwVnHwZnHwcFGC90dXRvcmlhbHMvbGVzc29uMDkuYXNweB8IZ2QUKwACFhIfAgUVTGVzc29uIDEwOiBQcm9wZXJ0aWVzHwhnHghTZWxlY3RlZGcfAQUVTGVzc29uIDEwOiBQcm9wZXJ0aWVzHwMFGC9UdXRvcmlhbHMvTGVzc29uMTAuYXNweB8FZx8GZx8EBRVMZXNzb24gMTA6IFByb3BlcnRpZXMfBwUYL3R1dG9yaWFscy9sZXNzb24xMC5hc3B4ZBQrAAIWEB8BBRNMZXNzb24gMTE6IEluZGV4ZXJzHwIFE0xlc3NvbiAxMTogSW5kZXhlcnMfAwUYL1R1dG9yaWFscy9MZXNzb24xMS5hc3B4HwQFE0xlc3NvbiAxMTogSW5kZXhlcnMfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xMS5hc3B4HwhnZBQrAAIWEB8BBRJMZXNzb24gMTI6IFN0cnVjdHMfAgUSTGVzc29uIDEyOiBTdHJ1Y3RzHwMFGC9UdXRvcmlhbHMvTGVzc29uMTIuYXNweB8EBRJMZXNzb24gMTI6IFN0cnVjdHMfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xMi5hc3B4HwhnZBQrAAIWEB8BBRVMZXNzb24gMTM6IEludGVyZmFjZXMfAgUVTGVzc29uIDEzOiBJbnRlcmZhY2VzHwMFGC9UdXRvcmlhbHMvTGVzc29uMTMuYXNweB8EBRVMZXNzb24gMTM6IEludGVyZmFjZXMfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xMy5hc3B4HwhnZBQrAAIWEB8BBS9MZXNzb24gMTQ6IEludHJvZHVjdGlvbiB0byBEZWxlZ2F0ZXMgYW5kIEV2ZW50cx8CBS9MZXNzb24gMTQ6IEludHJvZHVjdGlvbiB0byBEZWxlZ2F0ZXMgYW5kIEV2ZW50cx8DBRgvVHV0b3JpYWxzL0xlc3NvbjE0LmFzcHgfBAUvTGVzc29uIDE0OiBJbnRyb2R1Y3Rpb24gdG8gRGVsZWdhdGVzIGFuZCBFdmVudHMfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xNC5hc3B4HwhnZBQrAAIWEB8BBS1MZXNzb24gMTU6IEludHJvZHVjdGlvbiB0byBFeGNlcHRpb24gSGFuZGxpbmcfAgUtTGVzc29uIDE1OiBJbnRyb2R1Y3Rpb24gdG8gRXhjZXB0aW9uIEhhbmRsaW5nHwMFGC9UdXRvcmlhbHMvTGVzc29uMTUuYXNweB8EBS1MZXNzb24gMTU6IEludHJvZHVjdGlvbiB0byBFeGNlcHRpb24gSGFuZGxpbmcfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xNS5hc3B4HwhnZBQrAAIWEB8BBRtMZXNzb24gMTY6IFVzaW5nIEF0dHJpYnV0ZXMfAgUbTGVzc29uIDE2OiBVc2luZyBBdHRyaWJ1dGVzHwMFGC9UdXRvcmlhbHMvTGVzc29uMTYuYXNweB8EBRtMZXNzb24gMTY6IFVzaW5nIEF0dHJpYnV0ZXMfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xNi5hc3B4HwhnZBQrAAIWEB8BBRBMZXNzb24gMTc6IEVudW1zHwIFEExlc3NvbiAxNzogRW51bXMfAwUYL1R1dG9yaWFscy9MZXNzb24xNy5hc3B4HwQFEExlc3NvbiAxNzogRW51bXMfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xNy5hc3B4HwhnZBQrAAIWEB8BBSBMZXNzb24gMTg6IE92ZXJsb2FkaW5nIE9wZXJhdG9ycx8CBSBMZXNzb24gMTg6IE92ZXJsb2FkaW5nIE9wZXJhdG9ycx8DBRgvVHV0b3JpYWxzL0xlc3NvbjE4LmFzcHgfBAUgTGVzc29uIDE4OiBPdmVybG9hZGluZyBPcGVyYXRvcnMfBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xOC5hc3B4HwhnZBQrAAIWEB8BBRhMZXNzb24gMTk6IEVuY2Fwc3VsYXRpb24fAgUYTGVzc29uIDE5OiBFbmNhcHN1bGF0aW9uHwMFGC9UdXRvcmlhbHMvTGVzc29uMTkuYXNweB8EBRhMZXNzb24gMTk6IEVuY2Fwc3VsYXRpb24fBWcfBmcfBwUYL3R1dG9yaWFscy9sZXNzb24xOS5hc3B4HwhnZGRkGAEFC19jdGwwOk1lbnUyDw9kBS9UdXRvcmlhbHNcVGhlIEMjIFR1dG9yaWFsXExlc3NvbiAxMDogUHJvcGVydGllc2Qo4mTJMfkctyprSD2ZfMTSgynemQ==" type="hidden">


<script src="Properties%20in%20C%23_files/AdapterUtils.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/MenuAdapter.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/ScriptResource.js" type="text/javascript"></script>
        
        
        <div id="header" class="header">
            <!-- headerTop -->
            <div id="headerTop" class="headerTop">
                <a id="_ctl0_hlkCSharp" href="http://www.csharp-station.com/default.aspx"><img src="Properties%20in%20C%23_files/cstationlogo.jpg" alt="C# Station" border="0"></a>&nbsp;&nbsp;
                    <span class="googleAd">
                        <script type="text/javascript">
                        <!--
                            google_ad_client = "pub-1539990971670604";
                            google_ad_width = 468;
                            google_ad_height = 60;
                            google_ad_format = "468x60_as";
                            google_ad_channel ="";
                            google_color_border = "284E98";
                            google_color_bg = "B5C7DE";
                            google_color_link = "0000CC";
                            google_color_url = "008000";
                            google_color_text = "284E98";
                        //-->
                        </script>
                        <script type="text/javascript" src="Properties%20in%20C%23_files/show_ads.js">
                        </script><iframe name="google_ads_frame" src="Properties%20in%20C%23_files/ads.htm" marginwidth="0" marginheight="0" vspace="0" hspace="0" allowtransparency="true" frameborder="0" height="60" scrolling="no" width="468"></iframe>
                    </span>
            </div>
            <!-- headerBottom -->
            <div id="headerBottom" class="headerBottom">
                
<div class="PrettyMenu" id="_ctl0_Menu2">
	<div class="AspNet-Menu-Horizontal">
			<ul class="AspNet-Menu">
				<li class="AspNet-Menu-Leaf">
					<a href="http://www.csharp-station.com/Default.aspx" class="AspNet-Menu-Link" title="Main C# Station Landing Page">
						Home</a>
				</li>
				<li class="AspNet-Menu-WithChildren">
					<span class="AspNet-Menu-NonLink">
						About</span>
					<ul>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/About.aspx" class="AspNet-Menu-Link" title="What is Available at C# Station">
								About</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Contact.aspx" class="AspNet-Menu-Link" title="Communicate with C# Station Management">
								Contact</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Link2Me.aspx" class="AspNet-Menu-Link" title="Information for Linking to C# Station">
								Link2Me</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Submit.aspx" class="AspNet-Menu-Link" title="Ask C# Station to Link to Your Site">
								Submit</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/IWantToSupportThisSite.aspx" class="AspNet-Menu-Link" title="If You Like C# Station and Want to Support It">
								Support C# Station</a>
						</li>
					</ul>
				</li>
				<li class="AspNet-Menu-WithChildren">
					<span class="AspNet-Menu-NonLink">
						Articles/Docs</span>
					<ul>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Articles.aspx" class="AspNet-Menu-Link" title="C# Station Articles">
								Articles</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Documentation.aspx" class="AspNet-Menu-Link" title="Links to C# Documentation, Specs, Etc.">
								Documentation</a>
						</li>
					</ul>
				</li>
				<li class="AspNet-Menu-Leaf">
					<a href="http://www.csharp-station.com/Books/BookService.aspx" class="AspNet-Menu-Link" title="List of Most Available C# Books">
						Books</a>
				</li>
				<li class="AspNet-Menu-WithChildren">
					<span class="AspNet-Menu-NonLink">
						Links</span>
					<ul>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=AspDotNetSites&amp;title=ASP.NET%20Sites" class="AspNet-Menu-Link" title="ASP.NET Links">
								ASP.NET</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=CSharpSites&amp;title=C%20Sharp%20Sites" class="AspNet-Menu-Link" title="C# Links">
								C#</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=DotNetSites&amp;title=.NET%20Sites" class="AspNet-Menu-Link" title=".NET Links">
								.NET</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=JobSites&amp;title=Job%20Sites" class="AspNet-Menu-Link" title="Job Links">
								Jobs</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=ObjectOrientedSites&amp;title=Object%20Oriented%20Sites" class="AspNet-Menu-Link" title="OOP Links">
								OOP</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=OtherSites&amp;title=Other%20Sites" class="AspNet-Menu-Link" title="Other Links">
								Other</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Tools.aspx" class="AspNet-Menu-Link" title="Useful List of Tools to Help You Build C# Applications">
								Tools</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=VbDotNetSites&amp;title=VB.NET%20Sites" class="AspNet-Menu-Link" title="VB.NET Links">
								VB.NET</a>
						</li>
						<li class="AspNet-Menu-Leaf">
							<a href="http://www.csharp-station.com/Links/ShowLinks.aspx?cat=WebServicesSites&amp;title=Web%20Service%20Sites" class="AspNet-Menu-Link" title="Web Service Links">
								Web Services</a>
						</li>
					</ul>
				</li>
				<li class="AspNet-Menu-WithChildren AspNet-Menu-ChildSelected">
					<span class="AspNet-Menu-NonLink AspNet-Menu-ChildSelected">
						Tutorials</span>
					<ul>
						<li class="AspNet-Menu-WithChildren">
							<span class="AspNet-Menu-NonLink">
								The ADO.NET Tutorial</span>
							<ul>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson01.aspx" class="AspNet-Menu-Link" title="Lesson 01: Introduction to ADO.NET">
										Lesson 01: Introduction to ADO.NET</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson02.aspx" class="AspNet-Menu-Link" title="Lesson 02: The SqlConnection Object">
										Lesson 02: The SqlConnection Object</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson03.aspx" class="AspNet-Menu-Link" title="Lesson 03: The SqlCommand Object">
										Lesson 03: The SqlCommand Object</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson04.aspx" class="AspNet-Menu-Link" title="Lesson 04: Reading Data with the SqlDataReader">
										Lesson 04: Reading Data with the SqlDataReader</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson05.aspx" class="AspNet-Menu-Link" title="Lesson 05: Working with Disconnected Data">
										Lesson 05: Working with Disconnected Data</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson06.aspx" class="AspNet-Menu-Link" title="Lesson 06: Adding Parameters to Commands">
										Lesson 06: Adding Parameters to Commands</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/AdoDotNet/Lesson07.aspx" class="AspNet-Menu-Link" title="Lesson 07: Using Stored Procedures">
										Lesson 07: Using Stored Procedures</a>
								</li>
							</ul>
						</li>
						<li class="AspNet-Menu-WithChildren AspNet-Menu-ChildSelected">
							<span class="AspNet-Menu-NonLink AspNet-Menu-ChildSelected">
								The C# Tutorial</span>
							<ul>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorial.aspx" class="AspNet-Menu-Link" title="Introduction, Contents, and Code Download">
										Introduction</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson01.aspx" class="AspNet-Menu-Link" title="Lesson 01: Getting Started">
										Lesson 01: Getting Started</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson02.aspx" class="AspNet-Menu-Link" title="Lesson 02: Operators, Types, and Variables">
										Lesson 02: Operators, Types, and Variables</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson03.aspx" class="AspNet-Menu-Link" title="Lesson 03: Control Statements - Selection">
										Lesson 03: Control Statements - Selection</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson04.aspx" class="AspNet-Menu-Link" title="Lesson 04: Control Statements - Loops">
										Lesson 04: Control Statements - Loops</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson05.aspx" class="AspNet-Menu-Link" title="Lesson 05: Methods">
										Lesson 05: Methods</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson06.aspx" class="AspNet-Menu-Link" title="Lesson 06: Namespaces">
										Lesson 06: Namespaces</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson07.aspx" class="AspNet-Menu-Link" title="Lesson 07: Introduction to Classes">
										Lesson 07: Introduction to Classes</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson08.aspx" class="AspNet-Menu-Link" title="Lesson 08: Class Inheritance">
										Lesson 08: Class Inheritance</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson09.aspx" class="AspNet-Menu-Link" title="Lesson 09: Polymorphism">
										Lesson 09: Polymorphism</a>
								</li>
								<li class="AspNet-Menu-Leaf AspNet-Menu-Selected">
									<a href="http://www.csharp-station.com/Tutorials/Lesson10.aspx" class="AspNet-Menu-Link AspNet-Menu-Selected" title="Lesson 10: Properties">
										Lesson 10: Properties</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson11.aspx" class="AspNet-Menu-Link" title="Lesson 11: Indexers">
										Lesson 11: Indexers</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson12.aspx" class="AspNet-Menu-Link" title="Lesson 12: Structs">
										Lesson 12: Structs</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson13.aspx" class="AspNet-Menu-Link" title="Lesson 13: Interfaces">
										Lesson 13: Interfaces</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson14.aspx" class="AspNet-Menu-Link" title="Lesson 14: Introduction to Delegates and Events">
										Lesson 14: Introduction to Delegates and Events</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson15.aspx" class="AspNet-Menu-Link" title="Lesson 15: Introduction to Exception Handling">
										Lesson 15: Introduction to Exception Handling</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson16.aspx" class="AspNet-Menu-Link" title="Lesson 16: Using Attributes">
										Lesson 16: Using Attributes</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson17.aspx" class="AspNet-Menu-Link" title="Lesson 17: Enums">
										Lesson 17: Enums</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson18.aspx" class="AspNet-Menu-Link" title="Lesson 18: Overloading Operators">
										Lesson 18: Overloading Operators</a>
								</li>
								<li class="AspNet-Menu-Leaf">
									<a href="http://www.csharp-station.com/Tutorials/Lesson19.aspx" class="AspNet-Menu-Link" title="Lesson 19: Encapsulation">
										Lesson 19: Encapsulation</a>
								</li>
							</ul>
						</li>
					</ul>
				</li>
			</ul>

	</div>
</div>
            </div>
            
        </div>
        <!-- header -->
        <div id="main" class="main">
            <div id="leftSidebar" class="leftSidebar">
                <a id="_ctl0_Skyscraper1_AntsHyperLink" href="http://www.red-gate.com/products/ants_profiler/if_only_we_had_used_ants_profiler_earlier.htm?utm_source=cstation&amp;utm_medium=skyscraper&amp;utm_content=princetonstory1&amp;utm_campaign=antsprofiler" target="_blank"><img id="_ctl0_Skyscraper1_AntsImage" title="Profile your C# applications with Red Gate Ants" src="Properties%20in%20C%23_files/ANTS_120x600.gif" border="0"></a>



            </div>
            <!-- leftSidebar -->
            <div id="rightSidebar" class="rightSidebar">
                

<a href="http://www.mayosoftware.com/">
    <img id="_ctl0_trainingad1_Image1" src="Properties%20in%20C%23_files/mayosoftwarebadge.png" alt="Mayo Software - C# and ASP.NET Development and Training Services" border="0">
</a>
            </div>
            <!-- columnRight -->
            <div id="content" class="content">
                
    <h1>
        The C# Station Tutorial</h1>
    <h6>
        by Joe Mayo, 02/10/01, updated 3/12/03</h6>
    <h3>
        Lesson 10: Properties</h3>
    <p>
        This lesson teaches C# Properties. Our objectives are as follows:
    </p>
    <ul>
        <li>Understand What Properties Are For.</li>
        <li>Implement a Property.</li>
        <li>Create a Read-Only Property.</li>
        <li>Create a Write-Only Property.</li>
    </ul>
    <p>
        Properties provide the opportunity to protect a field in a class by reading and
        writing to it through the property. In other languages, this is often accomplished
        by programs implementing specialized getter and setter methods. C# properties enable
        this type of protection while also letting you access the property just like it
        was a field. To get an appreciation for what properties accomplish, let's take a
        look at how to provide field encapsulation by traditional methods.
    </p>
    <h5>
        Listing 10-1. An Example of traditional Class Field Access: Accessors.cs</h5>
    <p>
        <font color="#0000ff" size="2">using</font><font size="2"> System;<br>
        </font><font color="#0000ff" size="2">
            <br>
            public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyHolder<br>
                {<br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">private</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> someProperty = 0;<br>
                <br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> getSomeProperty()<br>
                &nbsp;&nbsp;&nbsp; {<br>
            </font>&nbsp;&nbsp;&nbsp;<font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;&nbsp; return</font><font size="2"> someProperty;<br>
                &nbsp;&nbsp;&nbsp; }<br>
            </font><font color="#0000ff" size="2">
                <br>
                &nbsp;&nbsp;&nbsp; public</font><font size="2"> </font><font color="#0000ff" size="2">
                    void</font><font size="2"> setSomeProperty(</font><font color="#0000ff" size="2">int</font><font size="2"> propValue)<br>
                        &nbsp;&nbsp;&nbsp; {<br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; someProperty = propValue;<br>
                        &nbsp;&nbsp;&nbsp; }<br>
                    </font><font color="#0000ff" size="2">
                        <br>
                    </font><font size="2">}<br>
                    </font><font color="#0000ff" size="2">
                        <br>
                        public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyTester<br>
                            {<br>
                        </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">static</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> Main(</font><font color="#0000ff" size="2">string</font><font size="2">[]
                    args)<br>
                    &nbsp;&nbsp;&nbsp; {<br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PropertyHolder propHold = </font>
        <font color="#0000ff" size="2">new</font><font size="2"> PropertyHolder();<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; propHold.setSomeProperty(5);<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine("Property Value: {0}",
            propHold.getSomeProperty());<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </font><font color="#0000ff" size="2">return</font><font size="2"> 0;<br>
                &nbsp;&nbsp;&nbsp; }<br>
                } </font>
    </p>
    <p>
        <input name="_ctl0:ContentPlaceHolder1:btnRunAccessors" value="Run Accessors.exe" id="_ctl0_ContentPlaceHolder1_btnRunAccessors" type="submit"></p>
    <p>
    </p>
    <p class="smartConsoleSetupLink">
        <a href="http://www.csharp-station.com/Tutorials/SmartConsoleSetup.aspx" target="_blank">Get Setup Instructions For How to Run
            this Program</a>
    </p>
    <p>
        Listing 10-1 shows the traditional method of accessing class fields.The <em>PropertyHolder</em>
        class has the field we're interested in accessing. It has two methods, <em>getSomeProperty()</em>
        and <em>setSomeProperty()</em>. The <em>getSomeProperty()</em> method returns the
        value of the <em>someProperty</em> field. The <em>setSomeProperty()</em> method
        sets the value of the <em>someProperty</em> field.
    </p>
    <p>
        The <em>PropertyT</em>ester class uses the methods of the <em>PropertyHolder</em>
        class to get the value of the <em>someProperty</em> field in the <em>PropertyHolder</em>
        class. The <em>Main()</em> method instantiates a new <em>PropertyHolder</em> object,
        <em>propHold</em>. Next it sets the <em>someMethod</em> of <em>propHold</em> to
        the value 5 by using the <em>setSomeProperty</em> method. Then the program prints
        out the property value with a <em>Console.WriteLine()</em> method call. The argument
        used to obtain the value of the property is a call to the <em>getSomeProperty()</em>
        method of the <em>propHold</em> object. It prints out "Property Value: 5" to the
        console.
    </p>
    <p>
        This method of accessing information in a field has been good because it supports
        the object-oriented concept of encapsulation. If the implementation of <em>someProperty</em>
        changed from an <em>int</em> type to a <em>byte</em> type, this would still work.
        Now the same thing can be accomplished much smoother with properties.
    </p>
    <h5>
        Listing 10-2. Accessing Class Fields With Properties: Properties.cs</h5>
    <p>
        <font size="2"></font><font color="#0000ff" size="2">using</font><font size="2"> System;<br>
            <br>
        </font><font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyHolder<br>
                {<br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">private</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> someProperty = 0;<br>
                <br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> SomeProperty<br>
                &nbsp;&nbsp;&nbsp; {<br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;
            </font><font color="#0000ff" size="2">get</font><br>
        <font size="2">&nbsp;&nbsp;&nbsp;</font>&nbsp;&nbsp;&nbsp; <font size="2">{<br>
        </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </font><font color="#0000ff" size="2">return</font><font size="2"> someProperty;<br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br>
        </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;
        </font><font color="#0000ff" size="2">set</font><br>
        <font size="2">&nbsp;&nbsp;&nbsp;</font>&nbsp;&nbsp;&nbsp; <font size="2">{<br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; someProperty
            = </font><font color="#0000ff" size="2">value</font><font size="2">;<br>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br>
                &nbsp;&nbsp;&nbsp; }<br>
                }<br>
            </font><font color="#0000ff" size="2">
                <br>
                public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyTester<br>
                    {<br>
                </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">static</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> Main(</font><font color="#0000ff" size="2">string</font><font size="2">[]
                    args)<br>
                    &nbsp;&nbsp;&nbsp; {<br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PropertyHolder propHold = </font>
        <font color="#0000ff" size="2">new</font><font size="2"> PropertyHolder();<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; propHold.SomeProperty = 5;<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine("Property Value: {0}",
            propHold.SomeProperty);<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </font><font color="#0000ff" size="2">return</font><font size="2"> 0;<br>
                &nbsp;&nbsp;&nbsp; }<br>
                }</font></p>
    <p>
        <input name="_ctl0:ContentPlaceHolder1:btnRunProperties" value="Run Properties.exe" id="_ctl0_ContentPlaceHolder1_btnRunProperties" type="submit"></p>
    <p>
    </p>
    <p class="smartConsoleSetupLink">
        <a href="http://www.csharp-station.com/Tutorials/SmartConsoleSetup.aspx" target="_blank">Get Setup Instructions For How to Run
            this Program</a>
    </p>
    <p>
        Listing 10-2 shows how to create and use a property. The <em>PropertyHolder</em>
        class has the <em>SomeProperty</em> property implementation.Notice that the first
        letter of the first word is capitalized. That's the only difference between the
        names of the property <em>SomeProperty</em> and the field <em>someProperty</em>.
        The property has two accessors, <em>get</em> and <em>set</em>.The <em>get</em> accessor
        returns the value of the <em>someProperty</em> field.The <em>set</em> accessor sets
        the value of the <em>someProperty</em> field with the contents of <em>value</em>.
        The <em>value</em> shown in the <em>set</em> accessor is a C# reserved word.
    </p>
    <p>
        The <em>PropertyTester</em> class uses the <em>SomeProperty</em> property in the
        <em>PropertyHolder</em> class. The first line of the <em>Main()</em> method creates
        a <em>PropertyHolder</em> object named <em>propHold</em>. Next the value of the
        <em>someProperty</em> field of the <em>propHold</em> object is set to 5 by using
        the <em>SomeProperty</em> property. It is that simple -- just assign the value to
        the property as if it were a field.
    </p>
    <p>
        After that, the <em>Console.WriteLine()</em> method prints the value of the <em>someProperty</em>
        field of the <em>propHold</em> object. It does this by using the <em>SomeProperty</em>
        property of the <em>propHold</em> object. Again, it is that simple -- just use the
        property as if it were a field itself.
    </p>
    <p>
        Properties can be made read-only. This is accomplished by having only a <em>get</em>
        accessor in the property implementation.
    </p>
    <h5>
        Listing 10-3. Read-Only Property: ReadOnlyProperty.cs</h5>
    <p>
        <font color="#0000ff" size="2">using</font><font size="2"> System;<br>
            <br>
        </font><font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyHolder<br>
                {<br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">private</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> someProperty = 0;<br>
                <br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> PropertyHolder(</font><font color="#0000ff" size="2">int</font><font size="2"> propVal)<br>
                &nbsp;&nbsp;&nbsp; {<br>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; someProperty = propVal;<br>
                &nbsp;&nbsp;&nbsp; }</font><font color="#0000ff" size="2"><br>
                    <br>
                    &nbsp;&nbsp;&nbsp; public</font><font size="2"> </font><font color="#0000ff" size="2">
                        int</font><font size="2"> SomeProperty<br>
                            &nbsp;&nbsp;&nbsp; {<br>
                        </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;
                        </font><font color="#0000ff" size="2">get</font><br>
        <font size="2">&nbsp;&nbsp;&nbsp;</font>&nbsp;&nbsp;&nbsp; <font size="2">{<br>
        </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </font><font color="#0000ff" size="2">return</font><font size="2"> someProperty;<br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br>
            &nbsp;&nbsp;&nbsp; }<br>
            }<br>
            <br>
        </font><font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyTester<br>
                {<br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">static</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> Main(</font><font color="#0000ff" size="2">string</font><font size="2">[]
                    args)<br>
                    &nbsp;&nbsp;&nbsp; {<br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PropertyHolder propHold = </font>
        <font color="#0000ff" size="2">new</font><font size="2"> PropertyHolder(5);<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine("Property Value: {0}",
            propHold.SomeProperty);<br>
            <br>
        </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;
        </font><font color="#0000ff" size="2">return</font><font size="2"> 0;<br>
            &nbsp;&nbsp;&nbsp; }<br>
            }</font></p>
    <p>
        <input name="_ctl0:ContentPlaceHolder1:btnRunRead" value="Run ReadOnlyProperty.exe" id="_ctl0_ContentPlaceHolder1_btnRunRead" type="submit">
    </p>
    <p class="smartConsoleSetupLink">
        <a href="http://www.csharp-station.com/Tutorials/SmartConsoleSetup.aspx" target="_blank">Get Setup Instructions For How to Run
            this Program</a>
    </p>
    <p>
        Listing 10-3 shows how to implement a read-only property.The <em>PropertyHolder</em>
        class has a <em>SomeProperty</em> property that only implements a <em>get</em> accessor.
        It leaves out the <em>set</em> accessor. This particular <em>PropertyHolder</em>
        class has a constructor which accepts an <em>int</em> parameter.
    </p>
    <p>
        The <em>Main()</em> method of the <em>PropertyTester</em> class creates a new <em>PropertyHolder</em>
        object named <em>propHold</em>. The instantiation of the <em>propHold</em> object
        uses the constructor of the <em>PropertyHolder</em> that takes an <em>int</em> parameter.
        In this case, it is set to 5.This initializes the <em>someProperty</em> field of
        the <em>propHold</em> object to 5.
    </p>
    <p>
        Since the <em>SomeProperty</em> property of the <em>PropertyHolder</em> class is
        read-only, there is no other way to set the value of the <em>someProperty</em> field.
        If you inserted <em>propHold.SomeProperty = 7</em> into the listing, the program
        would not compile, because <em>SomeProperty</em> is read-only. When the <em>SomeProperty</em>
        property is used in the <em>Console.WriteLine()</em> method, it works fine. This
        is because it is a read operation which only invokes the <em>get</em> accessor of
        the <em>SomeProperty</em> property.
    </p>
    <h5>
        Listing 10-4. Write-Only Property: WriteOnlyProperty.cs</h5>
    <p>
        <font color="#0000ff" size="2">using</font><font size="2"> System;<br>
            <br>
        </font><font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyHolder<br>
                {<br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">private</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> someProperty = 0;<br>
                <br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> SomeProperty<br>
                &nbsp;&nbsp;&nbsp; {<br>
            </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;
            </font><font color="#0000ff" size="2">set</font><br>
        <font size="2">&nbsp;&nbsp;&nbsp;</font>&nbsp;&nbsp;&nbsp; <font size="2">{<br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; someProperty
            = </font><font color="#0000ff" size="2">value</font><font size="2">;<br>
                <br>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine("someProperty
                is equal to {0}", someProperty);<br>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br>
                &nbsp;&nbsp;&nbsp; }<br>
                }<br>
                <br>
            </font><font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">class</font><font size="2"> PropertyTester<br>
                    {<br>
                </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2"> </font>
        <font color="#0000ff" size="2">public</font><font size="2"> </font><font color="#0000ff" size="2">static</font><font size="2"> </font><font color="#0000ff" size="2">int</font><font size="2"> Main(</font><font color="#0000ff" size="2">string</font><font size="2">[]
                    args)<br>
                    &nbsp;&nbsp;&nbsp; {<br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PropertyHolder propHold = </font>
        <font color="#0000ff" size="2">new</font><font size="2"> PropertyHolder();<br>
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; propHold.SomeProperty = 5;<br>
            <br>
        </font><font color="#0000ff" size="2">&nbsp;&nbsp;&nbsp;</font><font size="2">&nbsp;&nbsp;&nbsp;&nbsp;
        </font><font color="#0000ff" size="2">return</font><font size="2"> 0;<br>
            &nbsp;&nbsp;&nbsp; }<br>
            }</font></p>
    <p>
        <input name="_ctl0:ContentPlaceHolder1:btnRunWrite" value="Run WriteOnlyProperty.exe" id="_ctl0_ContentPlaceHolder1_btnRunWrite" type="submit">
    </p>
    <p class="smartConsoleSetupLink">
        <a href="http://www.csharp-station.com/Tutorials/SmartConsoleSetup.aspx" target="_blank">Get Setup Instructions For How to Run
            this Program</a>
    </p>
    <p>
        Listing 10-4 shows how to create and use a write-only property. This time the <em>get</em>
        accessor is removed from the <em>SomeProperty </em>property of the <em>PropertyHolder</em>
        class. The <em>set</em> accessor has been added, with a bit more logic. It prints
        out the value of the <em>someProperty</em> field after it has been modified.
    </p>
    <p>
        The <em>Main()</em> method of the <em>PropertyTester</em> class instantiates the
        <em>PropertyTester</em> class with a default constructor. Then it uses the <em>SomeProperty</em>
        property of the <em>propHold</em> object to set the <em>someProperty</em> field
        of the <em>propHold</em> object to 5. This invokes the <em>set</em> accessor of
        the <em>propHold</em> object, which sets the value of its <em>someProperty</em>
        field to 5 and then prints "someProperty is equal to 5" to the console.
    </p>
    <p>
        In summary, you now know what properties are for and how they're used.traditional
        methods of encapsulation have relied on separate methods.Properties allow you to
        access objects state as if it was a field.Properties can be made read-only or write-only
        and you know how to implement each type.
    </p>
    <p>
        I invite you to return for <a href="http://www.csharp-station.com/Tutorials/Lesson11.aspx">Lesson 11:&nbsp; Indexers</a>.</p>
    <p>
        
</p><p>
    Your feedback and constructive contributions are welcome.&nbsp; Please feel free
    to contact me for feedback or comments you may have about this lesson.
</p>
<p>
    <a id="_ctl0_ContentPlaceHolder1_TutorialFooter1_hlkFeedback" href="http://www.csharp-station.com/contact.aspx?subject=C%23%20Station%20Tutorial%20Feedback">Feedback</a>
</p>
<p>
    <a id="_ctl0_ContentPlaceHolder1_TutorialFooter1_hlkSupport" href="http://www.csharp-station.com/IWantToSupportThisSite.aspx">I like this site and want to support it!</a>&nbsp;</p>
<p>
    Copyright © 2000-2007 C# Station, All Rights Reserved
</p>

    

            </div>
            <!-- content -->
            <div id="footer" class="footer">
                
<hr>
<div id="footerLinks">
        <a id="_ctl0_Standardpagefooter1_hlkHome" href="http://www.csharp-station.com/default.aspx">Home</a>
        |
        <a id="_ctl0_Standardpagefooter1_hlkArticles" href="http://www.csharp-station.com/Articles.aspx">Articles</a>
        |
        <a id="_ctl0_Standardpagefooter1_hlkBooks" href="http://www.csharp-station.com/Books/BookService.aspx">Books</a>
        |
        <a id="_ctl0_Standardpagefooter1_hlkTools" href="http://www.csharp-station.com/Tools.aspx">Tools</a>
        |
        <a id="_ctl0_Standardpagefooter1_hlkLinks" href="http://www.csharp-station.com/Links.aspx">Links</a>
        |
        <a id="_ctl0_Standardpagefooter1_hlkTutorials" href="http://www.csharp-station.com/Tutorial.aspx">Tutorial</a>
        <br>
        Copyright © 2000 - 2007 C# STATION, ALL RIGHTS RESERVED.
        <br>
        <a id="_ctl0_Standardpagefooter1_hlkLegal" href="http://www.csharp-station.com/Legal.aspx">Legal</a>
        |
        <a id="_ctl0_Standardpagefooter1_HyperLink2" href="http://www.csharp-station.com/Legal.aspx">Copyright</a>
        |
        <a id="_ctl0_Standardpagefooter1_hlkPrivacy" href="http://www.csharp-station.com/Legal.aspx">Privacy</a>
</div>
<p>
    <a id="_ctl0_Standardpagefooter1_hlkPoweredByAspDotNet" href="http://www.asp.net/"><img src="Properties%20in%20C%23_files/pow_by_aspnet2.gif" alt="Powered by ASP.NET v2.0" border="0"></a>
    &nbsp; &nbsp; &nbsp;
    <a id="_ctl0_Standardpagefooter1_hlkMVP" href="https://mvp.support.microsoft.com/profile=B7B6A81C-C018-4CE7-839B-02A3483BBE8C"><img src="Properties%20in%20C%23_files/MVPLogo0106.jpg" alt="Joe Mayo - Visual C# MVP" border="0"></a></p>
            </div>
            <!-- footer -->
        </div>
        <!-- main -->
    
<input name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="/wEWBQK5v/nZBQKZw8OjBQLL1N7hBAK8nbyeAwKim4DOB+R1zNak1ei+9Evwc3wnONJe/ypD" type="hidden">

<script type="text/javascript">
<!--
var __wpmExportWarning='This Web Part Page has been personalized. As a result, one or more Web Part properties may contain confidential information. Make sure the properties contain information that is safe for others to read. After exporting this Web Part, view properties in the Web Part description file (.WebPart) by using a text editor such as Microsoft Notepad.';var __wpmCloseProviderWarning='You are about to close this Web Part.  It is currently providing data to other Web Parts, and these connections will be deleted if this Web Part is closed.  To close this Web Part, click OK.  To keep this Web Part, click Cancel.';var __wpmDeleteWarning='You are about to permanently delete this Web Part.  Are you sure you want to do this?  To delete this Web Part, click OK.  To keep this Web Part, click Cancel.';Sys.Application.initialize();
// -->
</script>
</form>
    <script type="text/javascript" src="Properties%20in%20C%23_files/link-enhancer">
    </script><script src="Properties%20in%20C%23_files/link-enhancer-common.js" type="text/javascript"></script><script type="text/javascript" src="Properties%20in%20C%23_files/po.html" charset="utf-8"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-utilities-12468.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-events-9331.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-simplePopover-5085.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-staticPopover-26406.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-popoverPane-35459.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-dynUpdate-18995.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-multiPanePopover-33447.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-panes-56568.js" type="text/javascript"></script>
<script src="Properties%20in%20C%23_files/n2CoreLibs-explorer-38488.js" type="text/javascript"></script>


    <noscript>
        <img src="http://www.assoc-amazon.com/s/noscript?tag=cstati" alt="" />
    </noscript>
<div class="animatedBox" id="goN2UAnimatedBox"></div></body></html>