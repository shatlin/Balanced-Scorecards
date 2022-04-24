var ImgShow = Class.create();
  ImgShow.prototype = {
    initialize: function(element, options) {
      this.element = $(element);
      this.options = Object.extend(options);
      this.images = document.getElementsByClassName(this.options.className, this.element);

      this.prepareimages();
      this.registerCallback();
    },

    prepareimages: function() {
      this.currentimage = this.images.first();
      //this.element.style.position = 'relative';
      this.element.style.height = this.images.max(function(image) {
        var visible = Element.visible(image), height;
        Element.setStyle(image, {position: 'absolute', width: '100%', left: '0px'});
        if (!visible) Element.show(image);
        height = Element.getHeight(image);
        if (!visible) Element.hide(image);
        return height;
      }).toString() + 'px';
    },

    nextimage: function() {
      return this.images[(this.images.indexOf(this.currentimage) + 1) % this.images.length];
    },

    registerCallback: function() {
      window.setTimeout(this.tick.bind(this), this.options.duration * 1000);
    },

    tick: function() {
      var currentimage = this.currentimage, nextimage = this.nextimage();

      new Effect.Parallel([
        new Effect.Fade(currentimage, {sync: true}),
        new Effect.Appear(nextimage, {sync: true})
      ], {
        duration: 5,
        afterFinish: (function(effect) {
          this.currentimage = nextimage;
          this.registerCallback();
        }).bind(this)
      })
    }
  }
  
  
  
  
  function showE(e,effect){
	if ($(e).style.display == 'none'){
		switch(effect){
			case "apear":
				new Effect.Appear(e);
			break;
			case "slide":
				new Effect.SlideDown(e);
			break;
		}	
	}
	return(false);
}
	
function hideE(e,effect){
	if ($(e).style.display != 'none'){
		switch(effect){
			case "apear":
				new Effect.Fade(e);
			break;
			case "slide":
				new Effect.SlideUp(e);
			break;
		}	
	}
	return(false);
}
function showHideE(eId,ePid,titleDisplay,titleNoDisplayT,effect){
	if ($(eId).style.display == 'none'){
		showE(eId,effect);
		$(ePid).innerHTML = titleNoDisplayT;
	}else{
		hideE(eId,effect);
		$(ePid).innerHTML = titleDisplay;	
	}
	return(false);
}