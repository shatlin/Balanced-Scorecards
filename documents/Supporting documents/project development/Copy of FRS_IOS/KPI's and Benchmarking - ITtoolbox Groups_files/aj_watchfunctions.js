var docheight,docwidth,scroll_top,scroll_left,ie,standardbody


function aj_BookmarkAction(pActionType,pEntityId,pMessageId) {
	var ajaxUrl;
	var runAjax=false
	
	//alert( pActionType +' '+pEntityId+' '+pMessageId);
	if(typeof(pActionType)!='undefined'){
	if (pEntityId == '0' || pEntityId == '') {	//user is not recognized. So, show message and send user back.
		tempPop(3);
		return;
	}
	
    if (pActionType < 0) {
		aj_BookmarkAddedAlert(3); // not recognized - output message but no ajax action sent to server
		return;
    } else if (parseInt(pActionType) == 2) {
           if(typeof(watchUrl)!='undefined'){
           if(typeof(pEntityId)!='undefined') {
            if (pEntityId>0) {
		ajaxUrl="/ajax/aj_watchactions.asp?bmid=" + pEntityId + "&ptype=" + pActionType;
		runAjax=true
		}
		}
		}
	}else if (pActionType==1) {
	                if(typeof(watchUrl)!='undefined'){
           if(typeof(pMessageId)!='undefined') {
	        if (pMessageId>0) {
		ajaxUrl="/ajax/aj_watchactions.asp?msid=" + pMessageId + "&ueid=" + pEntityId + "&ptype=" + pActionType + "&rurl=" + parentUrlForWatch;
		runAjax=true
		//alert(ajaxUrl);
		}
		}
		}
	}    
	if (runAjax==true) { 
	dojo.io.bind({
		url: ajaxUrl,
		load: function(type, data, evt){aj_BookmarkActionResponse(data);  },
		error: function(type, error){ alert("error"); },
		mimetype: "text/plain"
	});
	}
	}
	//alert('done');
}

var BookmarkTransport

function aj_BookmarkActionResponse(pData) {
	var returnText,bookmarkButton
    // if (BookmarkTransport.readyState==4 || BookmarkTransport.readyState=="complete") {
	returnText = pData // BookmarkTransport.responseText
	if (returnText != "fail") {
		aj_BookmarkAddedAlert(returnText)
		if (parseInt(returnText)==2) {
			bookmarkButton="KBgroups_watchButton.gif"
			buildBookmarkLink(1,curUserEntityId,watchParentId,buttonLocation + bookmarkButton)
		} else {
			bookmarkButton="KBgroups_unwatchButton.gif"
			buildBookmarkLink(2,returnText,'0',buttonLocation + bookmarkButton)    
		}
		// setTimeout("document.getElementById('watchActionLink').innerHTML='<img class=KBgroups_button src=" + buttonLocation + bookmarkButton + " border=0 />';",100)
   } else {
		alert(returnText)
		status="Bookmarking failure"
	}
}

function buildBookmarkLink(actionId,pId1,pId2,imgSrc){
    var newImg = document.createElement('IMG');
    newImg.setAttribute('src', imgSrc);
    /// newImg.className="KBgroups_button"
    newImg.border=0
	//alert(actionId+' '+pId1+' '+pId2+' '+imgSrc);
    if (parseInt(actionId)==1) {
		//newImg.setAttribute('width',151)
    } else {
		//newImg.setAttribute('width',151)
    }
   // newImg.setAttribute('height',24)
    newImg.id="anotherimage"
    var nLink = document.createElement("a");
		nLink.appendChild(newImg)
        nLink.href = "#"
		nLink.id="watchActionLink"
		nLink.onclick=function(){ 
				aj_BookmarkAction(actionId,pId1,pId2);	
			} 
	var linkParent=document.getElementById("bookmarkButtonContainer")
	linkParent.innerHTML=""
	linkParent.appendChild(nLink)
	
	var setImg=document.getElementById("anotherimage")
	setImg.style.display="none"
	setImg.style.display="inline"	    
}
    
function aj_BookmarkAddedAlert(BookmarkReturn) {
    // alert("Bookmark Action Successful: " + BookmarkReturn)
    tempPop(BookmarkReturn)
}

function getBookmarkText(pRepCode){
	// 1-added, 2-removed, 3-not recognized, 4-error/failure
	var arrayText=new Array("You are now watching this thread. <a href='" + watchUrl + "'>Click here</a> to view your watched threads.","You are no longer watching this thread. <a href='" + watchUrl + "'>Click here</a> to view your watched threads.","To start watching this thread, please <a href='" + strUserManagementUrl + "signin.asp?r=" + selfUrl + "'>Sign in</a> or <a href='" + strUserManagementUrl + "connect/'>Register</a> for an ITtoolbox account. Once you are signed in, please click the <i>Watch this Thread</i> button on this page again.")
	var aTitles = new Array("Watch Added", "Watch Removed", "Please Register" );
	var responseText=arrayText[pRepCode-1]
	var titleText = aTitles[pRepCode-1];
	var tempText = "<table border=0 cellspacing=0 cellpadding=0 width=490><tr><td style='font: bold 16px arial; padding-top:10px; padding-left:20px'>" + titleText + "</td>"
	tempText= tempText + "<td align=right><a href='javascript:void(0);' onClick=closeMe('BookmarkBox'); title='Close Watch Box'><img src='http://images.ittoolbox.com/KB/groups/KBgroups_watchCloseButton.gif' border=0 style='margin-right:15px; margin-top:8px'></A>"
	tempText= tempText + "</tr><tr>"
	tempText= tempText + "<td colspan=2 class=KBgroups_watchInner>" + responseText
	tempText= tempText + "<br/>"
	tempText= tempText + "<div style='margin-top:10px; text-align:right;'><a href=\"javascript:closeMe('BookmarkBox')\">Close</a></div></td></tr>"
	tempText= tempText + "</table>"
	return tempText
}

var BookmarkBox
function tempPop(returnText) {
    BookmarkBox=createWindow()
    document.body.appendChild(BookmarkBox)
    setSize(BookmarkBox,490,163)
	centerMe(BookmarkBox)
	var responseIndex=(parseInt(returnText)>3) ? 1 : returnText;
	BookmarkBox.innerHTML=getBookmarkText(responseIndex)
}

function setSize(wnObj, w, h){ 
	wnObj.style.width=parseInt(w) + "px"
	wnObj.style.height=parseInt(h) + "px"
}

function centerMe(wnObj){ 
	getWindowData()
	wnObj.style.left=scroll_left+(docwidth-wnObj.offsetWidth)/2+"px" 
	wnObj.style.top=scroll_top+(docheight-wnObj.offsetHeight)/2+"px" 
}

function howFarX(destinationObj) {
return parseInt(scroll_left+(docwidth-destinationObj.offsetWidth)/2)
}

function howFarY(destinationObj) {
    getWindowData()
    return parseInt((docheight-destinationObj.offsetHeight)/2)
}
function closeMe(obj) {
    //document.getElementById(obj).style.display="none"
    var sucbox=document.getElementById(obj)
    if (sucbox) {
    document.body.removeChild(sucbox)
    suchbox=null
    }
}

function createWindow(){
	var domwindow=document.createElement("div") 
	domwindow.id="BookmarkBox"
	domwindow.className="KBgroups_watchBox"
    return domwindow
}

function getWindowData(){ //get window data
	var ie=document.all && !window.opera
	var domclientWidth=document.documentElement && parseInt(document.documentElement.clientWidth) || 100000 //Preliminary doc width in non IE browsers
	standardbody=(document.compatMode=="CSS1Compat")? document.documentElement : document.body //create reference to common "body" across doctypes
	scroll_top=(ie)? standardbody.scrollTop : window.pageYOffset
	scroll_left=(ie)? standardbody.scrollLeft : window.pageXOffset
	docwidth=(ie)? standardbody.clientWidth : (/Safari/i.test(navigator.userAgent))? window.innerWidth : Math.min(domclientWidth, window.innerWidth-16)
	docheight=(ie)? standardbody.clientHeight: window.innerHeight
}


function URLencode(sStr) {
    return escape(sStr)
       .replace(/\+/g, '%2B')
          .replace(/\"/g,'%22')
             .replace(/\'/g, '%27')
				.replace(/\//g, '%2F');
  }


