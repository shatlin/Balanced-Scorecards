// (C) TamilMixer JS
function BMMix()
{
	if (document.all)
	window.external.AddFavorite("http://www.tamilmixer.com", "TamilMixer.com - Crazy Tamil MP3 Database: The Powerful Tamil Musical Media Resource Provides Quality MP3 Streaming, MP3 Downloads, Music Video Downloads, Video Clip, Ringtone, Lyric, Other Song, Video, Chat, Online Flash Games, Radio and more..");
	else if (window.sidebar)
	window.sidebar.addPanel("TamilMixer.com - Crazy Tamil MP3 Database: The Powerful Tamil Musical Media Resource Provides Quality MP3 Streaming, MP3 Downloads, Music Video Downloads, Video Clip, Ringtone, Lyric, Other Song, Video, Chat, Online Flash Games, Radio and more..", "http://www.tamilmixer.com", "")
}
function radio(mylink, windowname)
{
	if (! window.focus)return true;
	var href;
	if (typeof(mylink) == 'string')
	   href=mylink;
	else
	   href=mylink.href;
	window.open(href, windowname, 'width=350,height=182,scrollbars=no');
return false;
}
function addsmile(smile) 
{
	document.cmnt.comments.value += smile;
}
function addsmile2(smile) 
{
	document.mixerchat.msgbox.value += smile;
}
function addsmile3(smile) 
{
	document.tmxbox.msg.value += smile;
}
function addsmile4(smile) 
{
	document.cmntrep.replybox.value += smile;
}
function TamilMixList(myname, w, h, scroll) 
{
	var winl = (screen.width - w) / 2;
	var wint = (screen.height - h) / 2;
	var rad_val = document.favorites.favorites.value;
	winprops = 'height='+h+',width='+w+',top='+wint+',left='+winl+',scrollbars=no,resizable=no,status=no,toolbar=no,menubar=no,location=no,directories=no';
	win = window.open("MixPlayer.php?favorites=" + rad_val , myname, winprops)
	if (parseInt(navigator.appVersion) >= 4) 
	{ 
		win.window.focus(); 
	}
}
function TamilMixPlay(myname, w, h, scroll) 
{
	var winl = (screen.width - w) / 2;
	var wint = (screen.height - h) / 2;
	var rad_val = myname;
	winprops = 'height='+h+',width='+w+',top='+wint+',left='+winl+',scrollbars=no,resizable=no,status=no,toolbar=no,menubar=no,location=no,directories=no';
	win = window.open("MixPlayer.php?song=" + rad_val , myname, winprops)
	if (parseInt(navigator.appVersion) >= 4) 
	{ 
		win.window.focus(); 
	}
}
function TamilMixPlayClip(myname) 
{
	var w=300;
	var h=350;
	var winl = (screen.width - w) / 2;
	var wint = (screen.height - h) / 2;
	var rad_val = myname;
	winprops = 'height='+h+',width='+w+',top='+wint+',left='+winl+',scrollbars=no,resizable=no,status=no,toolbar=no,menubar=no,location=no,directories=no';
	win = window.open("MixPlayer.php?clip=" + rad_val , myname, winprops)
	if (parseInt(navigator.appVersion) >= 4) 
	{ 
		win.window.focus(); 
	}
}
function RateUp(album) 
{
	var winl = (screen.width - 200) / 2;
	var wint = (screen.height - 260) / 2;
	winprops = 'height='+260+',width='+200+',top='+wint+',left='+winl+',scrollbars=no,resizable=no,status=no,toolbar=no,menubar=no,location=no,directories=no';
	win = window.open("rate.php?alb="+album, "Rate", winprops);
	if (parseInt(navigator.appVersion) >= 4)
	{ 
		win.window.focus(); 
	}
}
function TamilMixAlbum(myname, w, h, scroll)
{
	var winl = (screen.width - w) / 2;
	var wint = (screen.height - h) / 2;
	var rad_val = document.album.album.value;
	winprops = 'height='+h+',width='+w+',top='+wint+',left='+winl+',scrollbars=no,resizable=no,status=no,toolbar=no,menubar=no,location=no,directories=no';
	win = window.open("MixPlayer.php?album=" + rad_val , myname, winprops);
	if (parseInt(navigator.appVersion) >= 4) 
	{ 
		win.window.focus(); 
	}
}
function SortPix()
{
	location=document.pix.sortnow.options[document.pix.sortnow.selectedIndex].value;
}
function mixchatpm(mylink, FPM, TPM)
{
	if (! window.focus)return true;
	var winl = (screen.width - 350) / 2;
	var wint = (screen.height - 182) / 2;
	var href;
	if (typeof(mylink) == 'string')
	   href=mylink;
	else
	   href=mylink.href;
	window.open(href, windowname, 'width=350,height=182,top='+wint+',left='+winl+',scrollbars=no');
return false;
}
function popup(mylink, windowname)
{
	if (! window.focus)return true;
	var winl = (screen.width - 350) / 2;
	var wint = (screen.height - 182) / 2;
	var href;
	if (typeof(mylink) == 'string')
	   href=mylink;
	else
	   href=mylink.href;
	window.open(href, windowname, 'width=350,height=182,top='+wint+',left='+winl+',scrollbars=no');
return false;
}
function radioup(URL) 
{
	eval("TamilMixer" + "RemoteRadio" + " = window.open(URL, '" + "RemoteRadio" + "', 'toolbar=0,scrollbars=0,location=0,statusbar=0,menubar=0,resizable=0,width=350,height=150,left = 426,top = 332');");
}
function MixBoxes(MixBox)
{
	if (document.getElementById)
	{
		var TMixer = document.getElementById(MixBox).style;
		TMixer.display = TMixer.display? "":"block";
	}
	else if (document.all)
	{
		var TMixer = document.all[MixBox].style;
		TMixer.display = TMixer.display? "":"block";
	}
	else if (document.layers)
	{
		var TMixer = document.layers[MixBox].style;
		TMixer.display = TMixer.display? "":"block";
	}
}
function advsearch(mixgroup)
{
	var qsearch = mixgroup.q.value;
	var qtab = mixgroup.tab.value;
	var qopt = mixgroup.zop.value;
	qtab = escape(qtab);
	qsearch = escape(qsearch);
	qopt = escape(zop);
	window.location = window.location + "?tab=" + qtab + "&q=" + qsearch + "&zop=" + zop;
}
function tmxfillBox2(box2,tmxCateBox) 
{
	for (i=0; i<mixCateBox.length; i++) 
	{
		if (mixCateBox[i]['tmxCateBox']==tmxCateBox) 
		{
			var tmxSubCateBox=mixCateBox[i]['tmxSubCateBox'];
		}
	}
	if(tmxSubCateBox.length <= 1)
	{
		   var x=document.createElement('option');
		   var y=document.createTextNode('- Main -');
		   x.appendChild(y);
		   box2.appendChild(x);
	}else{
			for (i=0; i<tmxSubCateBox.length; i++) 
			{
			   var x=document.createElement('option');
			   var y=document.createTextNode(tmxSubCateBox[i]);
			   x.appendChild(y);
			   box2.appendChild(x);
			}
		   var x=document.createElement('option');
		   var y=document.createTextNode('- Main -');
		   x.appendChild(y);
		   box2.appendChild(x);
	}
}
function MixBoxes(MixBox)
{
	if (document.getElementById)
	{
		var TMixer = document.getElementById(MixBox).style;
		TMixer.display = TMixer.display? "":"block";
	}
	else if (document.all)
	{
		var TMixer = document.all[MixBox].style;
		TMixer.display = TMixer.display? "":"block";
	}
	else if (document.layers)
	{
		var TMixer = document.layers[MixBox].style;
		TMixer.display = TMixer.display? "":"block";
	}
}
function tmxActivateBox(box1,box2) 
{
	var tmxCateBox=document.getElementById(box1);
	var tmxsubCate=document.getElementById(box2);

	for (i=0; i<mixCateBox.length; i++) 
	{
	   var x=document.createElement('option');
	   var y=document.createTextNode(mixCateBox[i]['tmxCateBox']);

		if (window.attachEvent) { //ie
			x.setAttribute('value',y.nodeValue);
		}
		x.appendChild(y);
		tmxCateBox.appendChild(x);
	}
	tmxCateBox.onchange=function() 
	{
		 if(this.value!="") 
		 {
			  var list=document.getElementById(box2);
			  while (list.childNodes[0]) 
				{
					list.removeChild(list.childNodes[0])
				}
			tmxfillBox2(tmxsubCate,this.value);
		  }
	 }
 tmxfillBox2(tmxsubCate,tmxCateBox.value);
}
function printNow(url, wiz, hiz) 
{
	var winl = (screen.width - wiz) / 2;
	var wint = (screen.height - hiz) / 2;
	newwindow=window.open(url,'name', 'width='+wiz+',height='+hiz+',top='+wint+',left='+winl+',scrollbars=yes');
	if (window.focus) {newwindow.focus()}
return false;
}
function cWords(w,x) 
{
	var y=w.value;
	var r = 0;
	a=y.replace(/\s/g,' ');
	a=a.split(' ');
	for (z=0; z<a.length; z++) 
	{
		if (a[z].length > 0) r++;
	}
	x.value=r;
}