var geoMap={US:{code:"",noResults:"No Shortcut found. Try a full search of apple.com.",viewAll:"View all search results",searchText:"Search"},AU:{code:"au",searchText:"Search"},NZ:{code:"nz",searchText:"Search"},CA_EN:{code:"ca",directory:"/ca",searchText:"Search"},CA_FR:{code:"ca",directory:"/ca/fr",viewAll:"Afficher tous les résultats",searchText:"Recherche"},DE:{code:"de",viewAll:"Alle Suchergebnisse",searchText:"Suchen"},UK:{code:"uk",searchText:"Search"},FR:{code:"fr",viewAll:"Afficher tous les résultats",searchText:"Rechercher"},CH_DE:{code:"ce",viewAll:"Alle Suchergebnisse",searchText:"Suchen"},CH_FR:{code:"cr",viewAll:"Afficher tous les résultats",searchText:"Rechercher"},IE:null,JP:{code:"jp",noResults:"ショートカットは見つかりませんでした。検索はこちら。",viewAll:"すべての検索結果を見る",searchText:"Search"},IT:{code:"it",viewAll:"Mostra tutti i risultati",searchText:"Cerca"},ES:{code:"es",viewAll:"Ver todos los resultados de búsqueda",searchText:"Buscar"},NL:{code:"nl",viewAll:"Toon alle zoekresultaten",searchText:"Zoek"},BE_FR:{code:"bf",viewAll:"Afficher tous les résultats",searchText:"Rechercher"},BE_NL:{code:"bl",viewAll:"Toon alle zoekresultaten",searchText:"Zoek"},TW:null,LA:{code:"la",searchText:"Search"},KR:{code:"kr",noResults:"일치하는 검색결과가 없습니다. 다시 검색하기.",viewAll:"검색 결과 전체 보기.",searchText:"Search"},SE:{code:"se",noResults:"Ingen genväg hittades. Prova att fulltextsöka på apple.com.",viewAll:"Visa alla sökresultat",searchText:"Sök"},DK:{code:"dk",noResults:"Ingen genvej fundet. Prøv at søge på hele apple.com.",viewAll:"Vis alle søgeresultater",searchText:"Søg"},FI:{code:"fi",noResults:"Ei oikotietä. Etsi koko apple.com.",viewAll:"Katso hakutulokset",searchText:"Etsi"},NO:{code:"no",noResults:"Fant ingen snarvei. Søk på hele apple.com.",viewAll:"Vis alle søkeresultater",searchText:"Søk"},BR:{code:"br",searchText:"Search"},ZA:{code:"za",searchText:"Search"},CN:null,HK:null,RU:{code:"ru",noResults:"Ссылок нет. Попробуйте расширенный поиск apple.com",viewAll:"Показать все результаты поиска",searchText:"Поиск"},PT:{code:"pt",noResults:"Nenhum resultado. Tente pesquisar em apple.com.",viewAll:"Ver todos os resultados de pesquisa",searchText:"Procurar"},PL:{code:"pl",noResults:"Fraza nie została odnaleziona. Użyj apple.com.",viewAll:"Przeglądaj wszystkie wyniki",searchText:"Szukaj"},PO:null,TR:null,UA:null,RO:null,CZ:null,HU:null,BG:null,HR:null,GR:null,IS:null};var enhanceSearch=function(B){var A=function(C){var D=document.getElementById(C);D.parentNode.removeChild(D)};document.getElementById("g-search").setAttribute("action",B);document.getElementById("g-search").setAttribute("method","GET");A("search-oe");A("search-access");A("search-site");A("search-lr")};function loadShortcuts(){decorateGlobalSearchInput();if(typeof (searchCountry)=="undefined"){searchCountry="us"}if(geoMap[searchCountry.toUpperCase()].directory){var D=geoMap[searchCountry.toUpperCase()].directory}else{if(searchCountry!="us"){var D="/"+searchCountry.replace(/_/,"")}else{D=""}}var C={"global":"http://www.apple.com"+D+"/search/","downloads":"http://www.apple.com"+D+"/search/downloads/","iphone":"http://www.apple.com"+D+"/search/iphone/","ipoditunes":"http://www.apple.com"+D+"/search/ipoditunes/","mac":"http://www.apple.com"+D+"/search/mac/","store":"http://www.apple.com"+D+"/search/store/","support":"http://www.apple.com"+D+"/search/support/"};var B=C[searchSection]||"http://www.apple.com/search/";enhanceSearch(B);var A=navigator.userAgent.match(/AppleWebKit/i)&&navigator.userAgent.match(/Mobile/i);if(!A&&(typeof (deactivateSearchShortcuts)=="undefined"||!deactivateSearchShortcuts)){SearchShortcut.load()}}function shortcutsPageLoader(B){var A=window.onload;if(typeof window.onload!="function"){window.onload=B}else{window.onload=function(){A();B()}}}shortcutsPageLoader(loadShortcuts);var SearchShortcut={baseUrl:"http://www.apple.com/global/nav/scripts/shortcuts.php",minimumCharactersForSearch:0,entryDelay:150,currentRequest:false,descriptionCharacters:90,isIe:false,init:function(){this.fullSearchUrl=document.getElementById("globalsearch").getElementsByTagName("form")[0].getAttribute("action");this.noResults=geoMap["US"].noResults;this.viewAll=geoMap["US"].viewAll;if(typeof (searchCountry)!="undefined"&&searchCountry){this.noResults=geoMap[searchCountry.toUpperCase()].noResults||this.noResults;this.viewAll=geoMap[searchCountry.toUpperCase()].viewAll||this.viewAll}this.html={results:document.getElementById("sp-results").getElementsByTagName("div")[0],input:document.getElementById("sp-searchtext")};if(navigator.userAgent.toLowerCase().indexOf("msie 6.")!=-1){document.getElementById("sp-results").style.left="171px";this.isIe=true}this.pausedControllers=[]},track:function(D,A){if(typeof (s_gi)=="undefined"||!s_gi){return }var C="appleglobal";var E="appleussearch";var B=null;if(typeof (searchCountry)!="undefined"&&searchCountry&&searchCountry!="US"){B=geoMap[searchCountry.toUpperCase()].code}if(B){C="apple"+B+"global";E="apple"+B+"search"}if(typeof (s_account)!="undefined"&&s_account.indexOf("appleussearch")==-1){s=s_gi(s_account+","+E)}else{s=s_gi(C+","+E)}s.prop4="";s.g_prop4="";s.prop6="";s.g_prop6="";s.pageName="";s.g_pageName="";s.pageURL="";s.g_pageURL="";s.g_channel="";s.linkTrackVars="eVar2,eVar4,prop7,prop10";s.eVar2="WWW-sc: "+D.toLowerCase();s.prop7="WWW-sc: "+D.toLowerCase();s.eVar4=A;s.prop10=A;s.tl(this,"o","Shortcut Search")},go:function(A){SearchShortcut.track(SearchShortcut.searchText,A);document.location=A},search:function(C){var A=this.baseUrl+"?q="+encodeURIComponent(C);if(typeof (searchSection)!="undefined"&&searchSection){A+="&section="+searchSection}if(typeof (searchCountry)!="undefined"&&searchCountry){A+="&geo="+searchCountry.toLowerCase()}this.spin();A+="&transport=js";var B=document.getElementsByTagName("head")[0];script=document.createElement("script");script.id="xdShortcutContainer";script.type="text/javascript";script.src=A;B.appendChild(script);SearchShortcut.scriptLoadTest()},scriptLoadTest:function(){var A=0;var B=window.setInterval(function(){A++;if(typeof (shortcutXml)!="undefined"){window.clearInterval(B)}else{if(A>20){window.clearInterval(B);document.getElementById("sp-search-spinner").style.display="none"}}},50)},loadXmlToDoc:function(B){var A;if(window.ActiveXObject){A=new ActiveXObject("Microsoft.XMLDOM");A.async="false";A.loadXML(B)}else{var C=new DOMParser();A=C.parseFromString(B,"text/xml")}if(!this.html||!this.html.results){this.init()}document.getElementById("sp-search-spinner").style.display="none";this.term=A.getElementsByTagName("term")[0].firstChild.nodeValue;this.xml=A.getElementsByTagName("search_results")[0];this.parseResults(this.xml);if(this.results){this.results.length>0?this.renderResults():this.renderNoResults()}},spin:function(){document.getElementById("sp-search-spinner").style.display="block"},parseResults:function(D){var C=D.getElementsByTagName("error");if(C.length>0){SearchShortcut.hideResults();return }else{var F=D.getElementsByTagName("match");this.results=new Array();for(var E=0;E<(F.length);E++){var A=F[E];var B={title:A.getAttribute("title"),url:A.getAttribute("url"),desc:A.getAttribute("copy"),category:A.getAttribute("category"),priority:A.getAttribute("priority"),image:A.getAttribute("image")};B.url=decodeURIComponent(B.url);this.results.push(B)}}},renderNoResults:function(){var D=this.noResults;this.html.results.innerHTML="";var B=document.createElement("ul");B.className="sp-results";listResult=document.createElement("li");listResult.className="firstCat resultCat";B.appendChild(listResult);listResult=document.createElement("li");listResult.id="sp-result-none";listResult.className="viewall";var A=document.createElement("div");A.className="hoverbox";var C=document.createElement("a");C.href=this.fullSearchUrl+"?q="+encodeURIComponent(this.term);C.innerHTML=D;listResult.appendChild(A);listResult.appendChild(C);listResult.url=this.fullSearchUrl+"?q="+encodeURIComponent(this.term);listResult.num=this.results.length;listResult.onclick=function(){SearchShortcut.go(this.url)};listResult.onmouseover=function(){SearchShortcut.itemSelected=true};listResult.onmouseout=function(){SearchShortcut.itemSelected=false};B.appendChild(listResult);this.html.results.appendChild(B);document.getElementById("globalsearch").className="active"},hideAllQuicktimeMovies:function(){if(typeof (AC)!="undefined"&&typeof (AC.Quicktime)!="undefined"&&typeof (AC.Quicktime.controllers)!="undefined"){function H(S){var T=curtop=0;if(S.offsetParent){T=S.offsetLeft;curtop=S.offsetTop;while(S=S.offsetParent){T+=S.offsetLeft;curtop+=S.offsetTop}}return[T,curtop]}function P(U,Z,d,h,T,Y,b,g){var X=U+d;var e=Z+h;var W=T+b;var c=Y+g;var V=Math.max(U,T);var a=Math.max(Z,Y);var f=Math.min(X,W);var S=Math.min(e,c);return f>V&&S>a}var A=AC.Quicktime.controllers;var N=$("sp-results");var K={width:328,height:448};var O=H(N);var E=O[0]-328;var D=O[1];var C=G+K.width;var B=F+K.height;for(var M=A.length-1;M>=0;M--){var I=A[M].movie;var L=Element.getDimensions(I);var R=H(I);var G=R[0];var F=R[1];if(P(G,F,L.width,L.height,E,D,K.width,K.height)){this.pausedControllers.push(A[M]);A[M].Stop();A[M].movie.style.visibility="hidden"}}}else{var J=document.getElementsByTagName("object");for(M=0;M<J.length;M++){if(typeof (J[M].Stop)!="undefined"){J[M].Stop()}try{if(typeof (J[M].getElementsByTagName("embed")[0].Stop)!="undefined"){J[M].getElementsByTagName("embed")[0].Stop()}}catch(Q){}J[M].style.visibility="hidden"}}},showAllQuicktimeMovies:function(){if(typeof (AC)!="undefined"&&typeof (AC.Quicktime)!="undefined"&&typeof (AC.Quicktime.controllers)!="undefined"){for(var B=this.pausedControllers.length-1;B>=0;B--){this.pausedControllers[B].movie.style.visibility="visible";if(navigator.userAgent.match(/Firefox/i)){setTimeout(this.pausedControllers[B].Play,100)}else{this.pausedControllers[B].Play()}}this.pausedControllers=[]}else{var A=document.getElementsByTagName("object");for(B=0;B<A.length;B++){A[B].style.visibility="visible";if(typeof (A[B].Play)!="undefined"){A[B].Play()}try{if(typeof (A[B].getElementsByTagName("embed")[0].Play)!="undefined"){A[B].getElementsByTagName("embed")[0].Play()}}catch(C){}}}},startFlashFixTimer:function(){var B=0;var A=setInterval(function(){SearchShortcut.flashDomRender();B++;if(B>50){clearInterval(A)}},10)},border:5,flashDomFix:function(){document.getElementById("sp-results").firstChild.firstChild.style.border="5px none red";document.getElementById("globalsearch").onmousemove=function(){SearchShortcut.flashDomRender()}},flashDomRender:function(){SearchShortcut.border%2==0?SearchShortcut.border++:SearchShortcut.border--;var A=document.getElementById("sp-results").firstChild.firstChild;if(A){A.style.border=SearchShortcut.border+"px none red"}},itemSelected:false,renderResults:function(){this.html.results.innerHTML="";var J=document.createElement("ul");J.className="sp-results";var L={};for(var H=0;H<this.results.length;H++){var Q=this.results[H];var P=unescape(Q.desc);var E="";if(P.length>this.descriptionCharacters){P=P.substring(0,P.indexOf(" ",this.descriptionCharacters-11))+"&hellip;";E=unescape(Q.desc)}var D=unescape(Q.title);if(D.length>39){D=D.substring(0,D.indexOf(" ",30))+"&hellip;"}var G=document.createElement("li");G.id="sp-result-"+H;G.className="category-"+unescape(Q.category).toLowerCase().replace(/\s+/g,"-");var C=document.createElement("div");C.className="hoverbox";var F=document.createElement("img");F.src=Q.image;F.title=E;var O=document.createElement("span");O.className="text";var I=document.createElement("h4");var N=document.createElement("a");var B=document.createElement("p");N.href=decodeURIComponent(Q.url);N.title=E;N.onclick=function(){SearchShortcut.go(decodeURIComponent(Q.url))};N.innerHTML=D;B.innerHTML=P;B.title=E;I.appendChild(N);O.appendChild(I);O.appendChild(B);G.appendChild(C);G.appendChild(F);G.appendChild(O);G.url=Q.url;G.num=H;G.onmouseover=function(){SearchShortcut.itemSelected=true;SearchShortcut.highlight(this)};G.onmouseup=function(){SearchShortcut.itemSelected=true;SearchShortcut.go(this.url)};G.onmouseout=function(){SearchShortcut.itemSelected=false;SearchShortcut.unhighlight(this)};G.priority=parseInt(Q.priority);if(!L[Q.category]){L[Q.category]=new Array()}L[Q.category].push(G)}var K="firstCat resultCat";for(var M in L){if(!L.hasOwnProperty(M)){continue}G=document.createElement("li");G.className=K;G.innerHTML=unescape(M);K="resultCat";J.appendChild(G);for(var A=0;A<L[M].length;A++){J.appendChild(L[M][A])}}G=document.createElement("li");G.id="sp-result-"+this.results.length;G.className="viewall";var C=document.createElement("div");C.className="hoverbox";var N=document.createElement("a");N.href=this.fullSearchUrl+"?q="+encodeURIComponent(this.term);N.innerHTML=this.viewAll;G.appendChild(C);G.appendChild(N);G.url=this.fullSearchUrl+"?q="+encodeURIComponent(this.term);G.num=this.results.length;G.onclick=function(){SearchShortcut.go(this.url)};G.onmouseover=function(){SearchShortcut.itemSelected=true};G.onmouseout=function(){SearchShortcut.itemSelected=false};document.getElementById("globalsearch").className="active";J.appendChild(G);this.html.results.appendChild(J);this.hideAllQuicktimeMovies();if(typeof (flashOnPage)!="undefined"&&flashOnPage){this.flashDomFix();this.startFlashFixTimer()}},startKeystrokeTimer:function(){if(this.timeoutId){window.clearTimeout(this.timeoutId)}this.timeoutId=window.setTimeout("SearchShortcut.commitKeystroke()",this.entryDelay)},commitKeystroke:function(){this.search(this.searchText)},hideResults:function(A,B){if(!this.html){this.init()}this.selected=null;document.getElementById("globalsearch").className="";this.html.results.innerHTML="";this.showAllQuicktimeMovies()},highlight:function(A){A.className="hoverli"},keyHighlight:function(A){if(this.selected){this.selected.className=""}this.selected=A;A.className="hoverli"},unhighlight:function(A){A.className=""},load:function(){var A=document.createElement("img");A.src="http://images.apple.com/global/nav/images/spinner.gif";A.width="11";A.height="11";A.border="0";A.alt="*";A.id="sp-search-spinner";A.style.display="none";document.getElementById("globalsearch").appendChild(A);document.getElementById("g-search").onsubmit=function(B){return false};if(navigator.userAgent.match(/AppleWebKit/i)){document.getElementById("sp-searchtext").onkeydown=function(B){var C=typeof (event)!="undefined"?event["keyCode"]:B.keyCode;if(!B){B=event}if(C==13&&!B.altKey){if(B.target.value.length===0){return false}if(SearchShortcut.selected){SearchShortcut.go(SearchShortcut.selected.url)}else{SearchShortcut.hideResults();document.getElementById("g-search").submit()}}}}document.getElementById("sp-searchtext").onkeyup=function(B){var D=typeof (event)!="undefined"?event["keyCode"]:B.keyCode;if(!B){B=event}if(D==40&&SearchShortcut.results){try{B.preventDefault();B.stopPropagation()}catch(E){}if(SearchShortcut.selected&&(SearchShortcut.results.length>SearchShortcut.selected.num+1)){SearchShortcut.keyHighlight(document.getElementById("sp-result-"+(SearchShortcut.selected.num+1)))}if(!SearchShortcut.selected&&SearchShortcut.results.length>0){SearchShortcut.keyHighlight(document.getElementById("sp-result-0"))}SearchShortcut.flashDomRender()}else{if(D==38&&SearchShortcut.results){try{B.preventDefault();B.stopPropagation()}catch(E){}if(SearchShortcut.selected&&SearchShortcut.selected.num>0){SearchShortcut.keyHighlight(document.getElementById("sp-result-"+(SearchShortcut.selected.num-1)))}SearchShortcut.flashDomRender()}else{if(D==27){SearchShortcut.hideResults();document.getElementById("sp-searchtext").value=""}else{SearchShortcut.selected=false;var C=document.getElementById("sp-searchtext").value;C=C.replace(/[%\^\?\!\*\/<>\$]/ig,"");C=C.replace(/^\s+/g,"").replace(/\s+$/g,"");if(C.length<1&&SearchShortcut.html){SearchShortcut.html.results.innerHTML="";document.getElementById("sp-search-spinner").style.display="none";SearchShortcut.hideResults()}else{if(C.length>SearchShortcut.minimumCharactersForSearch){SearchShortcut.searchText=C;SearchShortcut.startKeystrokeTimer()}}}}}}}};function decorateGlobalSearchInput(){var L=document.getElementById("sp-searchtext");var E=null;var D=0;var I="Search";if(typeof (searchCountry)=="undefined"){searchCountry="us"}if(geoMap[searchCountry.toUpperCase()].searchText){I=geoMap[searchCountry.toUpperCase()].searchText}var H="";if(navigator.userAgent.match(/AppleWebKit/i)){L.setAttribute("type","search");if(!L.getAttribute("results")){L.setAttribute("results",D)}if(null!=I){L.setAttribute("placeholder",I);L.setAttribute("autosave",H)}L.onblur=function(){if(!SearchShortcut.itemSelected){SearchShortcut.hideResults()}}}else{L.setAttribute("autocomplete","off");E=document.createElement("input");L.parentNode.replaceChild(E,L);var B=document.createElement("span");B.className="left";var J=document.createElement("span");J.className="right";var G=document.createElement("div");G.className="reset";var A=document.createElement("div");A.className="search-wrapper";var F=L.value==I;var C=L.value.length==0;if(F||C){L.value=I;A.className+=" blurred empty"}A.appendChild(B);A.appendChild(L);A.appendChild(J);A.appendChild(G);L.onfocus=function(){var M=A.className.indexOf("blurred")>-1;if(L.value==I&&M){L.value=""}A.className=A.className.replace("blurred","")};L.onblur=function(){if(!SearchShortcut.itemSelected){SearchShortcut.hideResults()}if(L.value==""){A.className+=" empty";L.value=I}A.className+=" blurred"};L.onkeydown=function(M){var O=typeof (event)!="undefined"?event["keyCode"]:M.keyCode;if(!M){M=event}if(O==13&&!M.altKey){var N=null;if(M.target){N=M.target}else{if(M.srcElement){N=M.srcElement}}if(N.value.length===0){return false}if(SearchShortcut.selected){SearchShortcut.go(SearchShortcut.selected.url)}else{SearchShortcut.hideResults();document.getElementById("g-search").submit()}return }if(L.value.length>=0){A.className=A.className.replace("empty","")}K()};var K=function(){return(function(M){var N=false;if(!M){M=window.event}if(M.type=="keydown"){if(M.keyCode!=27){return }else{N=true}}L.blur();L.value="";A.className+=" empty";L.focus()})};G.onmousedown=K();if(E){E.parentNode.replaceChild(A,E)}}}