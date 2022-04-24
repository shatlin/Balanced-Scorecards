<!--
// one-liner to bust frames
// if (window != top) top.location.href = location.href;
//document.write('xx');
//top.scrollTo(0,0);

/*
This little block allows internet explorer
to create a bookmark of any page
*/
var url = document.location;
var title = 'BUZGate&#8482; - ' + document.title;
// alert('the url is ' + url);
// alert('the title is ' + title);
function makeLink(){
  if(document.all) {
    window.external.AddFavorite(url,title);
  }
  else {
    //alert("We are developing a Sidebar for Gecko-based browsers such as Mozilla.\nClose this message, and press Ctrl + D to add this page to your bookmarks.");
    addSidebar();
  }
}

// add a sidebar for mozilla users
function addSidebar()
{
  if ((typeof window.sidebar == "object") && (typeof window.sidebar.addPanel == "function"))
  {
    window.sidebar.addPanel ("BUZGate", "/referral.php?to=http://www.buzgate.org/nh/sitemap.html","");
  }
  else
  {
    var rv = window.confirm ("This feature is only available for free browsers such as Mozilla. \nVisit the Mozilla.org website?");
    if (rv)
      document.location.href = "/referral.php?to=http://www.mozilla.org/";
  }
}

function SelectIt(e)
{
  if (e.options[e.selectedIndex].value != "none"){
  location = e.options[e.selectedIndex].value + '.html'}
}

function hideThis (elem) {
  elem.style.display='none';
}

function showThis (elem) {
  elem.style.display='block';
}


// -->
