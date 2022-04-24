var addEvent;
if (document.addEventListener) {
	addEvent = function(element, type, handler) {
		element.addEventListener(type, handler, null);
	}
}
else if (document.attachEvent) {
	addEvent = function(element, type, handler) {
	element.attachEvent("on" + type, handler);
	}
}
else {
	addEvent = new Function; // not supported
}

function get_target(e) {
	if (window.event && window.event.srcElement)
		return window.event.srcElement ;
	if (e && e.target)
		return e.target ;
	if (!el)
		return false ;
}

function climb_dom(e, tag_type) {
	while (e.nodeName.toLowerCase() != tag_type && e.nodeName.toLowerCase() != 'html') e = e.parentNode ;
	return (e.nodeName.toLowerCase() == 'html') ? null : e ;
}

function classContains(myObject,myClassName) {
	if (!myObject.className) {
		return false ;
	}
	return (myObject.className.indexOf(myClassName) == -1) ? false : true ;
}

function stripClass(myObject,myClassName) {
	var cnPos = myObject.className.indexOf(myClassName) ;
	if (cnPos != -1) {
		myObject.className = myObject.className.replace(/\s?hovering\s?/gi,"") ;
	}
}

function addClass(myObject,myClassName) {
	if (!myObject.className) {
		return false ;
	}
	var existingClasses = myObject.className.split(" ") ;
	var foundCN = false ;
	for (iCN in existingClasses) {
		if (Trim(existingClasses[iCN]) == myClassName) {
			foundCN = true ;
		}
	}
	if (!foundCN) {
		myObject.className += " " + myClassName ;
	}
}

function Trim(TRIM_VALUE){
	if(TRIM_VALUE.length < 1){
		return"";
	}
	TRIM_VALUE = RTrim(TRIM_VALUE);
	TRIM_VALUE = LTrim(TRIM_VALUE);
	if(TRIM_VALUE==""){
		return "";
	}
	else{
		return TRIM_VALUE;
	}
}

function RTrim(VALUE){
	var w_space = String.fromCharCode(32);
	var v_length = VALUE.length;
	var strTemp = "";
	if(v_length < 0){
		return"";
	}
	var iTemp = v_length -1;
	
	while(iTemp > -1){
		if(VALUE.charAt(iTemp) == w_space){
		}
		else{
			strTemp = VALUE.substring(0,iTemp +1);
			break;
		}
		iTemp = iTemp-1;
	}
	return strTemp;
}

function LTrim(VALUE){
	var w_space = String.fromCharCode(32);
	if(v_length < 1){
		return "";
	}
	var v_length = VALUE.length;
	var strTemp = "";
	
	var iTemp = 0;
	
	while(iTemp < v_length){
	if(VALUE.charAt(iTemp) == w_space){
	}
	else{
		strTemp = VALUE.substring(iTemp,v_length);
		break;
	}
		iTemp = iTemp + 1;
	} //End While
	return strTemp;
}



function getInternetExplorerVersion()
// Returns the version of Internet Explorer or a -1
// (indicating the use of another browser).
{
  var rv = -1; // Return value assumes failure
  if (navigator.appName == 'Microsoft Internet Explorer')
  {
    var ua = navigator.userAgent;
    var re  = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
    if (re.exec(ua) != null)
      rv = parseFloat( RegExp.$1 );
  }
  return rv;
}

function getPath() {
	return window.location.href.substring(0, window.location.href.lastIndexOf("/")) ;
}

function replaceH1() {
	var headerImg = readMeta('header-image') ;
	if (!headerImg) return false ;
	// If present, set classname and replace contents with special image
	var myH1 = document.getElementsByTagName('h1')[0] ;
	if (!myH1) return ;
	myH1.style.backgroundImage = 'url('+getPath()+'/images/h1/' + headerImg + ')' ;
	myH1.style.backgroundPosition = 'top left' ;
	myH1.style.backgroundRepeat = 'no-repeat' ;
	myH1.style.textIndent = '-999em' ;
	//IE 7 needs a width for its H1 - let's give it one.
	var IEversion=getInternetExplorerVersion();
	if(IEversion>6){
		myH1.style.width= '16em' ;
	}
}

function readMeta(metaName) {
	if (!document.getElementsByTagName) return false ;
	var allMetas = document.getElementsByTagName('meta') ;
	for (var m=0; m<allMetas.length; m++) {
		if (allMetas[m].name.toLowerCase() == metaName.toLowerCase()) {
			if (allMetas[m].content) {
				// IE, Opera and Mozilla
				return allMetas[m].content ;
			}
			else if ( (allMetas[m].attributes[1].value.indexOf('.gif')>=0) || (allMetas[m].attributes[1].value.indexOf('.jp')>=0) )  {
				return allMetas[m].attributes[1].value ;
			}
			else {
				return allMetas[m].attributes[0].value ;
			}
		}
	}
	return false ;
}

function setupAuthor() {
	// Read author from HTML
	var author = readMeta('author') ;
	if (!author) return ;
	// If present, create a new box and insert into document
	var newAuthorBox = document.createElement('div') ;
	var newAuthorBoxInner = document.createElement('div') ;
	newAuthorBox.className = 'info-box' ;
	var newAuthorName = document.createTextNode(author) ;
	newAuthorBoxInner.className = 'author' ;
	newAuthorBoxInner.appendChild(newAuthorName) ;
	newAuthorBox.appendChild(newAuthorBoxInner) ;
	document.getElementById('insert').appendChild(newAuthorBox) ;
}

function setupDate() {
	// Read date from HTML
	var docDate = readMeta('date') ;
	if (!docDate) return ;
	var newDateBox = document.createElement('div') ;
	var newDateText = document.createTextNode('Article published ' + docDate) ;
	newDateBox.appendChild(newDateText) ;
	document.getElementById('insert').appendChild(newDateBox) ;
}

function setupSections2() {
	// NOT CURRENTLY USED
	var sections = readMeta('sections') ;
	if (!sections) return ;
	var splitSections = sections.split(',') ;
	// Create new ul
	newSectionList = document.createElement('ul') ;
	newSectionList.className = 'cross-links' ;
	
	for (s=0; s<splitSections.length; s++) {
		// Create new <li>
		var newSectionItem = document.createElement('li') ;
		newSectionItem.className = 's-' + splitSections[s] ;
		// Create new <a> inside it
		var newSectionItemLink = document.createElement('a') ;
		newSectionItemLink.href = splitSections[s] + '.cfm' ;
		switch (splitSections[s]) {
			case "basics" :
				newSectionText = "Basics" ;
				break ;
			case "recommendations" :
				newSectionText = "Recommended" ;
				break ;
			case "process" :
				newSectionText = "Design process" ;
				break ;
			case "opinion" :
				newSectionText = "Opinion" ;
				break ;
			case "business" :
				newSectionText = "Business" ;
				break ;
			case "goal-oriented-design" :
				newSectionText = 'Goal-oriented design' ;
				break ;
			case "graphic-design" :
				newSectionText = 'Graphic design' ;
				break ;
			case "ia" :
				newSectionText = "Site architecture" ;
				break ;
			case "accessibility" :
				newSectionText = "Accessibility" ;
				break ;
			case "usability" :
				newSectionText = 'Usability' ;
				break ;
			case "copywriting" :
				newSectionText = "Copywriting" ;
				break ;
			case "production" :
				newSectionText = "Production" ;
				break ;
			case "html" :
				newSectionText = "HTML" ;
				break ;
			case "css" :
				newSectionText = "CSS" ;
				break ;
			case "js" :
				newSectionText = "Javascript / DHTML" ;
				break ;
			default :
				newSectionText = '' ;
				break ;
		}
		
		if (newSectionText.length) {
			var newSectionTextNode = document.createTextNode(newSectionText) ;
			newSectionItemLink.appendChild(newSectionTextNode) ;
			newSectionItem.appendChild(newSectionItemLink) ;
			newSectionList.appendChild(newSectionItem) ;
		}

	}
	document.getElementById('insert').appendChild(newSectionList) ;
}

function setupSections() {
	// Does page include Sections metatag?
	var sections = readMeta('sections') ;
	if (!sections) return ;
	// If so, set relevant side nav items "on"
	var splitSections = sections.split(',') ;
	var myNav = document.getElementById('navSections').getElementsByTagName('li') ;
	
	for (var iSection in splitSections) {
		for (var iListItem=0; iListItem<myNav.length; iListItem++) {
			if (classContains(myNav[iListItem], 's-' + splitSections[iSection])) {
				addClass (myNav[iListItem], "on") ;
			}
		}
	}
}

window.onload = function() {
	replaceH1() ;
	setupDate() ;
	setupSections() ;
}