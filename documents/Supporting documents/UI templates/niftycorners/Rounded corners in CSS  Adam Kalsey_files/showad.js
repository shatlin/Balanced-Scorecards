var komliad_base="http://ads.pubmatic.com/AdServer";
var komliad_js_base="http://ads.pubmatic.com/AdServer";
var komliad_init=new function() {
	if (typeof window.komliad_init_done=='undefined') {
		window.komliad_init_done=0;
	}
}
function getTimeStamp() {
	var _currentTime = new Date();
	var _strTime = _currentTime.getFullYear() +""+ _currentTime.getMonth() +""+ _currentTime.getDate();
	_strTime = _strTime + "" + _currentTime.getHours() + "" + _currentTime.getMinutes() +""+ _currentTime.getSeconds();
	return _strTime;
}
function getColorsQueryString() {
	var _page_bg_color="";
	var _link_color="";
	var _text_color="";
	try {
		if (typeof document.body.style.backgroundColor!='undefined') {
			if (document.body.style.backgroundColor.length!=0) {
				_page_bg_color=document.body.style.backgroundColor;
			} else {
				_page_bg_color=document.bgColor;
			}
		} else {
			_page_bg_color=document.bgColor;
		}
		if (typeof document.body.style.color!='undefined') {
			if (document.body.style.color.length!=0) {
				_text_color=document.body.style.color;
			} else {
				_text_color=document.fgColor;
			}
		} else {
			_text_color=document.fgColor;
		}
		_link_color=document.linkColor;
	} catch (err) {
		_page_bg_color=document.bgColor;
		_text_color=document.fgColor;
		_link_color=document.linkColor;
	}
	var queryStr="";
	queryStr+="kbgColor="+_page_bg_color.replace(/#/,"");
	queryStr+="&ktextColor="+_text_color.replace(/#/,"");
	queryStr+="&klinkColor="+_link_color.replace(/#/,"");
	return queryStr;
}
function showAdsFunction() {
	if (typeof window.kadCounter=='undefined') {
		window.kadCounter=0;
	}
	window.kadCounter+=1;
	var frameName="komli_ads_frame"+window.kadCounter+pubId+siteId;
	var pageUrl=document.URL;pageUrl=pageUrl.split("?",1);
	var id=pageUrl.toString().replace(/\//g,"");
	id=id.replace(/\./g,"_");
	id=id.replace(/\:/g,"_");
	id=id.replace(/\\/g,"_");
	id=id.replace(/#/g,"_");
	frameName=id+frameName;
	var srclink=komliad_base+'/AdServerServlet?operId=1&pubId='+pubId;
	var irno = Math.random();
	srclink=srclink+'&siteId='+siteId;
	srclink=srclink+'&frameName='+frameName;
	srclink=srclink+'&adId='+kadId;
	srclink=srclink+'&kadwidth='+kadwidth;
	srclink=srclink+'&kadheight='+kadheight;
	srclink=srclink+'&'+getColorsQueryString();
	srclink=srclink+'&kltstamp='+getTimeStamp();
	srclink=srclink+'&pageURL='+pageUrl;
	srclink=srclink+'&ranreq='+irno;
	var frameSrc='<iframe name="'+frameName+'"';
	frameSrc+=' frameborder="0" allowtransparency="true" hspace="0" vspace="0"';
	frameSrc+=' marginheight="0" marginwidth="0" scrolling="no"';
	frameSrc+=' width="'+kadwidth+'"';
	frameSrc+=' height="'+kadheight+'"';
	frameSrc+=' src="'+srclink+'"';
	frameSrc+='>';
	frameSrc+='</iframe>';
	document.write(frameSrc);
}
function regClickTracker() {
	if (typeof(window.ktrackreg)=='undefined') {
		window.ktrackreg=1;
		document.write('<script type="text/javascript" src="'+komliad_js_base+'/js/adtrack.js"> </script>');
	}
}
var regShowAdsFunction=new function() {
	if (typeof(pubId)=='undefined') {
		return;
	}
	if (typeof(siteId)=='undefined') {
		return;
	}
	if (typeof(kadId)=='undefined') {
		return;
	}
	if (typeof(kadwidth)=='undefined') {
		return;
	} 
	if (typeof(kadheight)=='undefined') {
		return;
	}
	showAdsFunction();
	regClickTracker();
}
