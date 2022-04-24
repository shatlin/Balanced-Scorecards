
myid = i;
mypage = escape(location.href);
myref = escape(document.referrer);
myip = escape(location.hostaddress);



if (myref=="")
    {
     myref="None";
    }
if (mypage=="")
    {
    mypage="Unavailable";
    }
var linkreefer = "http://t4.trackalyzer.com/trackalyze.asp?r=" + myref + "&p=" + mypage + "&i=" + myid;
document.write ("<img src='" + linkreefer + "'>");



function Trackalyzer (myid, page)
{
	var currentpage = (location.href);
	var mypage = escape(location.href);
	var myref = escape(document.referrer);
	var myip = escape(location.hostaddress);
	var forward = false;
if (page!=null)
	{
	mypage=page;
	forward=true;
	};
if (myref=="")
    {
     myref="None";
    };
if (mypage=="")
    {
    mypage="Unavailable";
    };
var linkreefer = "http://t4.trackalyzer.com/trackalyze.asp?i=" + myid + "&r=" + myref + "&p=" + mypage + "&f=" + forward;
document.write ("<img src='" + linkreefer + "'>");

if (forward==true)
	{
	window.location = (currentpage);
	window.open(mypage)
	};
}