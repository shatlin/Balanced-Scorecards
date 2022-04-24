var siteid = '1';
var file='http://www.indiawebdevelopers.com/stylusstats/script.aspx';
f='' + escape(document.referrer);
if (navigator.appName=='Netscape'){b='NS';}
if (navigator.appName=='Microsoft Internet Explorer'){b='MSIE';}
if (navigator.appVersion.indexOf('MSIE 3')>0) {b='MSIE';}
w=screen.width; h=screen.height;
v=navigator.appName;
if (v != 'Netscape') {c=screen.colorDepth;}
else {c=screen.pixelDepth;}
info='w=' + w + '&h=' + h + '&c=' + c + '&r=' + f + '&s=' + siteid;
document.write('<img src="' + file + '?'+info+ '">');
