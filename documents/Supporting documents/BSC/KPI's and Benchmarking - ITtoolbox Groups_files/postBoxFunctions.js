	// ********************** POST BOX FUNCTIONS *************************

var activeContainerID = 0;

function getPostBox(containerId,newClass) {
	var oldContainerName=""
	var pBox=document.getElementById("postBox")
	var coAll
	var tempTextAreaClass
	var tempReplyBoxClass
	var tempNewClass=newClass
	coAll=document.getElementById("collapseAllLink")
	var exAll
	exAll=document.getElementById("expandAllLink")
	
	//Toggle visibility of Post reply links all through
	var replyCount=document.getElementById("replyCount").value;
	if (replyCount){
		for (var i = 1; i <= replyCount; i++) {
			if ( (i+2) == containerId ){
				document.getElementById('replyLinkSection' + (i+2)).style.display = 'none';
			} else {
				document.getElementById('replyLinkSection' + (i+2)).style.display = 'block';
			}	
		}
	}		
	
    var container=""
    var jump=""
    if (parseInt(containerId)<0) {
		container="topReplySection"
    } else {
		container= "replyPlacementCell" + containerId;
		activeContainerID = containerId;
    }
	//if (toggleState==0 && parseInt(containerId)>=0) {
	//	toggleAll()
	//}
	if (parseInt(curReplyIndex)!=parseInt(containerId)) {
	
	    var boxContainer=document.getElementById(container)
	    if (boxContainer && pBox) {
	boxContainer.style.display="block"
	// boxContainer.innerHTML="&nbsp;"
	boxContainer.appendChild(pBox)
	pBox.style.display="none"
	pBox.style.display="block"
	var lastContainer=document.getElementById("replyPlacementCell" + curReplyIndex)
	if (curReplyIndex<0) {
	        oldContainerName="topReplySection"
	 } else {
	        oldContainerName="replyPlacementCell" + curReplyIndex
	 }
	 var lastContainer=document.getElementById(oldContainerName)
	if (lastContainer) {
	lastContainer.style.display="none"
	}
	curReplyIndex=containerId   
	    tempNewClass=""
	    }
	    }

       tempReplyBoxClass="KBgroups_replyBox_Off"
       tempTextAreaClass="KBgroups_textarea_Off"
	   tempNewClass=""

        if (pBox) {
	  pBox.className=tempReplyBoxClass
    }
    var textAreaField=document.getElementById("postBody")
    if (textAreaField) {
        textAreaField.className=tempTextAreaClass
    }
    var objName=(parseInt(containerId)<0) ? "topReplyPoint":"replyPlacementCell" + containerId
        var pBox2=document.getElementById(objName)
        if (pBox2) {
            ///alert(findPos(pBox2)[1] + "---" + howFarY(pBox2))
            window.scroll(0,findPos(pBox2)[1]-howFarY(pBox2))
           
                   // if (pBox2.scrollIntoView(false)) {
               //  pBox2.scrollIntoView(false)
                   // }

              }  
}
var toggleState=0
var displayValue="block"
var replyDisplayValue="none"
var toggleLinkText="Expand All"
var curReplyIndex=-1
var curMoveIncrement=0

function findPos(obj) {
	var curleft = curtop = 0;
	if (obj.offsetParent) {
		curleft = obj.offsetLeft
		curtop = obj.offsetTop
		while (obj = obj.offsetParent) {
			curleft += obj.offsetLeft
			curtop += obj.offsetTop
		}
	}
	return [curleft,curtop];
}

// form validation

function cFc(fld,cCount) {
    if (fld) {
        if (parseInt(fld.value.length)>=parseInt(cCount)) {
            return true
        } else {
           return false
        }
        }
    return false
    }
    
    
     function validateEmail(txt){

 var tfld =txt
var email = /^[^@]+@[^@.]+\.[^@]*\w\w$/ ;

 var checkStr=tfld.toString()
 if (!email.test(tfld)) {
 return false;
} else {
 return true;
}
}


function finalValidate() {	
    var returnValue=true
    var sErrorText = "";
    // var pSub=document.getElementById("postSubject")
    var pEml=document.getElementById("postEmail")
    var pBody=document.getElementById("postBody")
    // var pGN=document.getElementById("postGroupName")
   // document.getElementById("emailTip").innerHTML=(validateEmail(pEml.value) && cFc(pEml,5)) ? "&nbsp;":"Valid Email Required";
    // document.getElementById("bodyTip").innerHTML=(cFc(pBody,1)) ? "&nbsp;": "Body text required";
   ///  document.getElementById("subjectTip").innerHTML=(cFc(pSub,1)) ? "&nbsp;": "Question subject required";

    if (!validateEmail(pEml.value)){
		returnValue = false;
		sErrorText = '- Please provide your valid e-mail address.\n';
	}
	
	if ( !cFc(pBody,1) ) {
        returnValue = false;
		sErrorText += '- Please type in your reply.';
    }
    
    if (!returnValue){
		alert('Required fields are missing in your post:\n--------------------------------------------------\n\n' + sErrorText + '\n');
	} else {
		//Paste the actual message body in here.
		var strReply;		
		var messageContainer = document.getElementById('reply_' + activeContainerID);
		var originalMessageContainer = document.getElementById("OriginalMessage");		
		if ( messageContainer && originalMessageContainer ){
			strReply = messageContainer.innerHTML;
			strReply = strReply.replace(/[\r|\n]/g,"");
			strReply = strReply.replace(/<BR[\/]?>/gi,"\n");
			strReply = strReply.replace(/<\/?SPAN[^>]*>/gi,"");
			strReply = strReply.replace(/<\/?A[^>]*>/gi,"");			
			originalMessageContainer.value = "\n\n-----Original Message-----\n" + strReply;
		}	
	}
    
   return returnValue;
}