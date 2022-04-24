
		
		function pausemillis(millis) 
		{
			date = new Date();
			var curDate = null;

			do { var curDate = new Date(); } 
			while(curDate-date < millis);
		} 

		function toggleLayer(whichLayer)
		{	
		//	if(navigator.userAgent.indexOf("Firefox") == -1)
		//	{
				var style2 = document.getElementById(whichLayer).style;
				if(style2.display == "none")
				{
					style2.display = "block";
					document.getElementById("tableDiv").style.display = "block";
				}
				else if(style2.display == "block")
				{	
		//			setTimeout("actualHide(mEvent)", 500);
					style2.display = "block";
					document.getElementById("tableDiv").style.display = "block";
				}	
		//	}
		}
		function showTable()
		{				
		 	document.getElementById("tableDiv").style.display = "block";
		}
		
		function showHideMap(mEvent) {
			if (!isMouseOverDiv(mEvent)) {
				document.getElementById("tableDiv").style.display = "none";
				document.getElementById("commentForm").style.display = "none";
			}
		}
		
		function isMouseOverDiv(mEvent) {
			var oElem;
			var oTmp;
			var bInDiv = false;
			if (mEvent.srcElement) {
				oElem = mEvent.srcElement;
			} else if (mEvent.target) {
				oElem = mEvent.target;
			}
//			alert("Mouse over: " + oElem.nodeName + "\n id:" + oElem.id);
			if (oElem.id == "tableDiv")
				return true;

			oTmp = oElem.parentNode;
			while (oTmp.nodeName.toLowerCase() != "body")
			{
				if (oTmp.id)
				{
					if (oTmp.id == "tableDiv") bInDiv = true;
				}
				oTmp = oTmp.parentNode;
			}
//			alert(bInDiv);
			return bInDiv;
		}
		
		function hideTable(mEvent)
		{
			//Fix for flicker in Firefox
			//problem is caused by Firefox interpreting mouse going into ul/li as a mouse out
			//for the div, therefore calling this hide function.
			//We check to see if any of the parent of the current element being pointed to
			//is the div with id="tableDiv". If so we ignore the hide command.
			
			var x = mEvent.srcElement ? mEvent.srcElement.id : mEvent.target.id;
			var y = mEvent.srcElement ? mEvent.srcElement.tagName : mEvent.target.tagName;
			//alert(x+ "," + y);
			
			var oElem;
			var oTmp;
			var bInDiv = false;
			if (mEvent.srcElement) {
				oElem = mEvent.srcElement;
			} else if (mEvent.target) {
				oElem = mEvent.target;
			}
			
			oTmp = oElem;
			while (oTmp.nodeName.toLowerCase() != "body")
			{
				if (oTmp.id)
				{
					//if (oTmp.id == "tableDiv" && oElem.id != "tableDiv") bInDiv = true;
					if (oTmp.id == "tableDiv") bInDiv = true;
				}
				oTmp = oTmp.parentNode;
			}
			
			if (!bInDiv) {
				document.getElementById("tableDiv").style.display = "none";
				document.getElementById("commentForm").style.display = "none";
			}
				
		}
		
		function actualHide(mEvent){
			if (!isMouseOverDiv(mEvent)) {
				document.getElementById("tableDiv").style.display = "none";
				document.getElementById("commentForm").style.display = "none";
			}
		}
		
		/*function showTable1()
		{
			if(navigator.userAgent.indexOf("Firefox") != -1)
			{
				showTable();
			}
		}
		
		function hideTable1()
		{
			hideTable();
		}*/

		
			 
		
