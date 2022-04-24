    var blogTransport

function processBlog() {
 var pUrl=document.getElementById("sourceUrl").value
  var pTitle=document.getElementById("ttl").value
    var pWord=document.getElementById("blogPassword").value
     var pUser=document.getElementById("blogUser").value
     var pType=document.getElementById("blogType").value
         var pBodyBlog=document.getElementById("s").value
    pBodyBlog=URLencode(pBodyBlog)
     var pRem="checked"
     if (pType=="itjournal") {
        document.getElementById("submitIT").click()
     } else {
    var txtUrl="/common/mod_proctoblogs.asp?pOp=pSubmit&pWord=" + pWord + "&pRem=" + pRem + "&pType=" + pType + "&pUser=" + pUser + "&pTitle=" + pTitle + "&pUrl=" + watchUrl + "&pBody=" + pBodyBlog
    if (navigator.userAgent.indexOf("MSIE")>=0) {
        txtUrl=cutTo(txtUrl,2000)
    } else {
        txtUrl=cutTo(txtUrl,3000)
    }
    blogTransport=GetXmlHObject(parseBlogResponse)
    blogTransport.open("GET", txtUrl , true)
    blogTransport.send(null)
}
}
function parseBlogResponse() {

if (blogTransport.readyState==4 || blogTransport.readyState=="complete") {
var rt=blogTransport.responseText
toggleShareTabs("responseOutputTab")
document.getElementById("shareResponseText").innerHTML="<div id=blogReturnOutputText class=med><br>" + rt + "</div><BR><BR><BR><BR><BR><BR><BR><BR><BR><BR><BR><BR><BR>"
checkForFit()
}
}

var emailTransport
function emailMessage() {
  var pTitle=document.getElementById("ttl").value
     var pUser=document.getElementById("senderUserName").value
      var pTitle=document.getElementById("ttl").value
      
      var personalText=document.getElementById("shareMessageText").value
    personalText=URLencode(personalText)
     var pUserEmail=document.getElementById("senderUserEmail").value
     var precEmail=document.getElementById("receiverEmails").value
    var pBody=document.getElementById("emailFormatedBody").value // changed hidden field id to emailFormatedBody - line 318 of mod_sharebox.asp
    pBody=URLencode(pBody)
     if ((!validateEmail(pUserEmail)) || (!validateEmail(precEmail.split(",")[0]))) {
        alert("Please check the email addresses to make sure they are not missing.\nAlso, please make sure to use a valid email format.\n\nValid email example: myEmailAddy@myCompany.com")
     } else {
	var txtUrl="/common/sendtofriend_sharebox.asp?uname=" + pUser + "&uemail=" + pUserEmail + "&recemail=" + precEmail + "&gname=" + strGroupName + "&perstext=" + personalText + "&wurl=" + selfUrl + "&pt=" + pTitle + "&sText=" + pBody
    if (navigator.userAgent.indexOf("MSIE")>=0) {
        txtUrl=cutTo(txtUrl,2000)
    } else {
        txtUrl=cutTo(txtUrl,3000)
    }
        emailTransport=GetXmlHObject(replyEmailResponse)
        emailTransport.open("GET", txtUrl , true)
        emailTransport.send(null)
}
}


function replyEmailResponse() {

if (emailTransport.readyState==4 || emailTransport.readyState=="complete") {
document.getElementById("receiverEmails").value=""
document.getElementById("shareMessageText").value=""
var rt=emailTransport.responseText
toggleShareTabs("responseOutputTab")
document.getElementById("shareResponseText").innerHTML="<div id=emailResponseText>" + rt + "<BR><BR><BR><BR><BR><BR><BR><BR><BR><BR><BR><BR><BR></div>"
checkForFit()
}
}
function toggleShareTabs(onId) {
	var tabLinks=new Array();
	tabLinks[0]="shareLinksSectionLink"
	tabLinks[1]="emailSection5Link"
	tabLinks[2]="blogThisBoxLink"
    var i
	for (i=0;i<tabLinks.length; i++) {
		document.getElementById(tabLinks[i]).className="sb_tabDown"
	}
         
    var pBox=document.getElementById("tabsSection")
    var ii=pBox.childNodes.length
    var cNode
    for (i=0;i<ii;i++) {
            if (pBox.childNodes[i]) {
                cNode=pBox.childNodes[i]
                    if (cNode.tagName=="DIV") {
                        if (cNode.id==onId) {
                            cNode.style.display="block"
                             if (document.getElementById(cNode.id + "Link")) {
                             document.getElementById(cNode.id + "Link").className="sb_tabUp"
                             if (onId=="blogThisBox"){
                                 checkBlogToggle()
                             }
                             }
                         } else {
                
                cNode.style.display="none"              
                         }
                        }
                     }
                }
               
                checkForFit()
            }
			
function reInsertObject(objId,targetParentId) {
    curContainerStorage=targetParentId
    if (document.getElementById(objId)) {
        var tPar=document.getElementById(targetParentId)
        var tObj=document.getElementById(objId)
        tPar.appendChild(tObj)
     checkForFit()
    }
}
var curContainerStorage

function checkForFit(locId) {

    var linkObj=document.getElementById(curContainerStorage)
    if (curContainerStorage){
    var boxObj=document.getElementById("shareContainer")
    var linkTop=linkObj.offsetTop
    var boxH=boxObj.offsetHeight
    
   var winH
   var docT=document.body.style.top
   if (document.all) {
    winH=window.screen.availHeight
    scrollT=window.document.body.scrollTop-300
     }else{
   scrollT=window.document.body.scrollTop-400
   winH=window.innerHeight
   }
    var relBoxTop=linkTop-scrollT
    var requiredVertical=boxH+40
    var availableVertical=(scrollT+winH)-(linkTop)
    var boxBottom=boxH+linkTop-scrollT
    var pageBottom=scrollT+winH
    var targetBottom=linkTop+boxH+20
    centerMe(boxObj)

}
}
function checkBlogToggle() {
 var pType=document.getElementById("blogType").value
 var blogHeading=document.getElementById("blogDestinationText")
 blogHeading.innerHTML="Blog-to-" + prettyBlogNames[pType]
    if (pType=="itjournal") {
            setDisplayF("none")
            if (uSignedIn=="True") {
                displayBlogFields()
           } else {
                displayLoginMessage()
            }
    } else {
        setDisplayF("")
        displayBlogFields()
    }
    

}
var prettyBlogNames=new Array()
prettyBlogNames["typepad"]="TypePad"
prettyBlogNames["livejournal"]="Live Journal"
prettyBlogNames["wordpress"]="Wordpress"
prettyBlogNames["blogger"]="Blogger"
prettyBlogNames["itjournal"]="ITtoolbox Journal"



function displayBlogFields() {
    var blogTArea=document.getElementById("blogMessageCell")
    var loginArea=document.getElementById("loginMessageCell")
    var titleArea=document.getElementById("blogTitleCell")
    var pButton=document.getElementById("processButton1")
    pButton.style.display=""
    titleArea.style.display=""
    blogTArea.style.display=""
    loginArea.style.display="none"
    checkForFit()
}
function displayLoginMessage() {
    var blogTArea=document.getElementById("blogMessageCell")
    var loginArea=document.getElementById("loginMessageCell")
    var titleArea=document.getElementById("blogTitleCell")
    var pButton=document.getElementById("processButton1")
    pButton.style.display="none"
    titleArea.style.display="none"
    blogTArea.style.display="none"
    loginArea.style.display=""
    checkForFit()
    
}
function setDisplayF(displayString) {
if (document.getElementById("valFieldsCell")) {
    document.getElementById("valFieldsCell").style.display=displayString
}
checkForFit()
}
function GetXmlHObject(handler){
var objXmlHttpShare=null

if (navigator.userAgent.indexOf("Opera")>=0)
{
alert("This doesn\'t work in Opera")
return
}
if (navigator.userAgent.indexOf("MSIE")>=0)
{
var strName="MSXML2.XMLHTTP"
if (navigator.appVersion.indexOf("MSIE 5.5")>=0)
{
strName="Microsoft.XMLHTTP"
}
try
{
objXmlHttpShare=new ActiveXObject(strName)
objXmlHttpShare.onreadystatechange=handler
return objXmlHttpShare
}
catch(e)
{
alert("Error. Scripting for ActiveX might be disabled  errors: " + e)

return
}
}
if (navigator.userAgent.indexOf("Mozilla")>=0)
{
objXmlHttpShare=new XMLHttpRequest()
objXmlHttpShare.onload=handler
objXmlHttpShare.onerror=handler
return objXmlHttpShare
}
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
    
function cutTo(pStr,pSize) {
    var resultText="" + pStr
    if (parseInt(resultText.length)>parseInt(pSize)) {
        resultText=resultText.substring(0,pSize)
    }
      return resultText  
}
