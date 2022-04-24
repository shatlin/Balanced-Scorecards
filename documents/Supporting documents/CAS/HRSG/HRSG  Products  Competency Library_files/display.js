// Function call for pop-up windows

function pop_up(url,name,params) {
	open(url,name,"toolbar=0," + params);
	return;
	}

//This function controls the drop down menu structure and the plus-minus rotation

function toggle(num) {
	obj=document.getElementById(num);
	visible=(obj.style.display!="none");
	key=document.getElementById("x" + num);
	
	if (visible) {
		obj.style.display="none";
		key.innerHTML="<img src='http://www.hrsg.ca/images/compact.gif' width='15' height='15' hspace='0' vspace='0' border='0'> ";
		}
	else {
		obj.style.display="block";
		key.innerHTML="<img src='http://www.hrsg.ca/images/compact_open.gif' width='15' height='15' hspace='0' vspace='0' border='0'> ";
   		}
	}
