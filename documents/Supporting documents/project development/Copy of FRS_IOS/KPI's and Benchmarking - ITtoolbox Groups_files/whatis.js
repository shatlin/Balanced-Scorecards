var setSummary;

var path = "http://images.ittoolbox.com/header/header_";

images = new Array();
images[0]="http://images.ittoolbox.com/header/Groupsup.gif"
images[1]="http://images.ittoolbox.com/header/Groupsdown.gif"
images[2]="http://images.ittoolbox.com/header/Groupsnobar.gif"
images[3]="http://images.ittoolbox.com/header/Blogsup.gif"
images[4]="http://images.ittoolbox.com/header/Blogsdown.gif"
images[5]="http://images.ittoolbox.com/header/Blogsnobar.gif"
images[6]="http://images.ittoolbox.com/header/Wikiup.gif"
images[7]="http://images.ittoolbox.com/header/Wikidown.gif"
images[8]="http://images.ittoolbox.com/header/Wikinobar.gif"
images[9]="http://images.ittoolbox.com/header/KBup.gif"
images[10]="http://images.ittoolbox.com/header/KBdown.gif"
images[11]="http://images.ittoolbox.com/header/KBnobar.gif"		 		 		 		 		 		 		 		 		 		 		 

var summary=new Array()
	summary['groups']="Ask and answer questions among skilled peers.";
	summary['blogs']="Blog or comment on real IT issues and trends.";
	summary['wiki']="Create and edit definitions, FAQs, and HOWTOs.";
	summary['kb']="Groups, blogs, wiki and more bundled by topic.";			
	
var pseudoLink=new Array()
	pseudoLink['groups']="http://groups.ittoolbox.com";	
	pseudoLink['blogs']="http://blogs.ittoolbox.com";	
	pseudoLink['wiki']="http://wiki.ittoolbox.com";	
	pseudoLink['kb']="http://www.ittoolbox.com";			
	
var defaultState=new Array()
	defaultState[0]="Groupsdown.gif";
	defaultState[1]="Blogsdown.gif";
	defaultState[2]="Wikinobar.gif";
	defaultState[3]="KBup.gif";			
	
var elementID=new Array()
	elementID[0]="groups";
	elementID[1]="blogs";
	elementID[2]="wiki";	
	elementID[3]="kb";					
	
function swapIn(mainID, mainImg, altID, altImg)	{
	if(setSummary!="on")	{
		document.getElementById(mainID).src=path + mainImg;
		document.getElementById(altID).src=path + altImg;
		document.getElementById("kb").src=path + "KBdown.gif";
		if(mainID == "wiki")	{
			document.getElementById("kb").src=path + "KBnobar.gif";
		}	else {
			document.getElementById("kb").src=path + "KBdown.gif";
		}	
		document.getElementById('summary').innerHTML=summary[mainID];	
	}
}

function swapOut()	{
	if(setSummary!="on")	{
		for (i=0; i < elementID.length; i++){
			document.getElementById(elementID[i]).src=path + defaultState[i];
		}
	document.getElementById('summary').innerHTML=summary['kb'];	
	}
}
		
function gotoLink(urlID,strKB)	{
	var pLink;
	setSummary="on";
	document.getElementById('summary').innerHTML=summary[urlID];
	if (strKB != "") {
		pLink = pseudoLink[urlID] + "?r=" + strKB;
	}
	else {
		pLink = pseudoLink[urlID];
	}
	
	window.location=pLink;
}
