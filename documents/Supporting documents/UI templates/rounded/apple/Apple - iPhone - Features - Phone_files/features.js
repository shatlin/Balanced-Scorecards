// Fade swapper
var FadeSwap = Class.create();
Object.extend(Object.extend(FadeSwap.prototype, AC.ContentSwap.prototype), {
	cs1IsAnimating: false,
	cs2IsAnimating: false,
	lastSelectorIndex: false,

	initialize: function(selectors, contents, wrapperPanel, displayPanel, controllerPanel, eventStr) {
		this.title = document.title;
		this.eventStr = eventStr;

		// swapper variables
		this.selectorList = selectors;
		this.contentList = contents;

		// front row variables
		this.wrapperPanel = wrapperPanel;
		this.displayPanel = displayPanel;
		this.controllerPanel = controllerPanel;

		for (var i=0; i<this.contentList.length; i++) {
			var item = this.contentList[i];
			item.style.display = 'none';

			this.contentList[i].name = this.selectorList[i].innerHTML;

			// set all the initial attributes
			var movieInfo = item.getElementsByClassName('movie')[0] || false;
			if (movieInfo) {
				Element.addClassName(movieInfo, 'loading');

				var movieLink = item.getElementsByClassName('movielink')[0];
				var movieUrl = movieLink.href;
				movieLink.href = '#'+item.id.replace('-AnchorFix', '');
				var height = (Element.hasClassName(movieInfo, 'tall')) ? 416 : 360;
				var className = (Element.hasClassName(movieInfo, 'tall')) ? 'tall' : '';

				this.contentList[i].movieInfo = {
					movieUrl: movieUrl,
					posterFrame: movieLink.target,
					endState: item.getElementsByClassName('endstate')[0],
					height: height,
					className: className
				}
			}
			movieInfo = null;
		}
		
		this.setMouseover();
	},

	setMouseover: function() {
		this.timeout = window.setTimeout(this.checkUrl.bind(this, document.location.hash), 200);

		for(var i=this.selectorList.length-1, selector; selector = this.selectorList[i]; i--) {
			Event.observe(selector, this.eventStr, this.swapContent.bindAsEventListener(this, i), false);
		}
	},
	
	checkUrl: function(hash) {
		if (hash != document.location.hash) {
			var hash = document.location.hash.toString();
			hash = hash.substring(1, hash.length);

			for (var i=0; i<this.contentList.length; i++) {
				var id = this.contentList[i].id.replace('-AnchorFix', '');
				if (hash == id) var selectorIndex = i;
			}
			if (selectorIndex) this.swapContent(null, selectorIndex);
		}

		this.timeout = window.setTimeout(this.checkUrl.bind(this, document.location.hash), 200);
	},

	swapContent: function(evt, selectorIndex) {
		var selector = this.selectorList[selectorIndex];
		var content = this.contentList[selectorIndex];
		
		// set the document.title to make click tracking a breeze
		document.title = this.title+' - '+content.name;

		// track this click
		if (evt) this.trackClick(selectorIndex);

		// and if we aren't already animating
		if (this.cs1IsAnimating == false && this.cs2IsAnimating == false) {

			this.hideMovie(selectorIndex);

			// set the first anim flag
			this.cs1IsAnimating = true;
			this.cs2IsAnimating = true;
			
			// set the active class
			var li = (Element.up(selector, 'li')) ? (Element.up(selector, 'li')) : selector;
			if (!Element.hasClassName(li, 'active')) Element.addClassName(li, 'active');

			// if this is the first one
			if (!this.lastSelectorIndex && typeof(this.lastSelectorIndex) == 'boolean') {
				// just do the appear
				this.afterFade(selectorIndex);

			// if we didn't just click on the same one
			} else if (this.lastSelectorIndex != selectorIndex) {
				// set some more temporary vars
				var lastSelector = this.selectorList[this.lastSelectorIndex];
				var lastContent = this.contentList[this.lastSelectorIndex];

				// swap the active classes
				var li = (Element.up(lastSelector, 'li')) ? (Element.up(lastSelector, 'li')) : lastSelector;
				if (Element.hasClassName(li, 'active')) Element.removeClassName(li, 'active');
		
				// do the set the swap/effect
				if (AC.Detector.isiPhone()) {
					lastContent.style.display = 'none';
					this.afterFade(selectorIndex);
				} else {
					new Effect.Fade(lastContent, { duration:.25, queue:{position:'end', scope:'cs1'},
						afterFinish:this.afterFade.bind(this, selectorIndex)
					});
				}

			////// otherwise ...
			} else {
				this.resetFlag('cs1IsAnimating');
				this.resetFlag('cs2IsAnimating');
			}

			// set the last content index now that we're done doing everything
			this.lastSelectorIndex = selectorIndex;
		}
	},
	
	resetFlag: function(flagName) {
		if(flagName == 'cs1IsAnimating') this.cs1IsAnimating = false;
		if(flagName == 'cs2IsAnimating') this.cs2IsAnimating = false;
	},

	afterFade: function(selectorIndex) {
		this.resetFlag('cs1IsAnimating');

		if (AC.Detector.isiPhone()) {
			this.contentList[selectorIndex].style.display = 'block';
			this.afterAppear(selectorIndex);
		} else {
			// appear after the fade
			new Effect.Appear(this.contentList[selectorIndex], { duration:.25, queue:{position:'end', scope:'cs2'},
				afterFinish:this.afterAppear.bind(this, selectorIndex)
			});
		}
	},

	afterAppear: function(selectorIndex) {
		// fix the serious QT display issues in FF if we have an inline style of opacity:0.999999;
		Element.setOpacity(this.contentList[selectorIndex], '');

		this.showMovie(selectorIndex);
	},

	hideMovie: function(selectorIndex, force) {
		if (this.movieController) {
			if (this.movieController.isPlaying()) this.movieController.Stop();
			this.movieController.detachFromMovie();
			this.movieController = false;
		}

		if (!AC.Detector.isiPhone() || !this.contentList[selectorIndex].movieInfo) {
			// reset the containers
			this.displayPanel.style.display = 'none';
			this.displayPanel.innerHTML = '';
			this.displayPanel.style.display = '';

			Element.removeClassName(this.wrapperPanel, 'active');
			Element.removeClassName(this.wrapperPanel, 'tall');
			Element.removeClassName(this.wrapperPanel, 'endstate');
		}
	},

	showMovie: function(selectorIndex) {
		var movieInfo =  this.contentList[selectorIndex].movieInfo || {};

		if (movieInfo.movieUrl) {
			Element.addClassName(this.wrapperPanel, 'active');
			Element.addClassName(this.wrapperPanel, movieInfo.className);

			var movieUrl = movieInfo.movieUrl;
			var posterFrame = movieInfo.posterFrame;
			
			this.displayPanel.innerHTML = '';
			var movie = AC.Quicktime.packageMovie('qtobject', movieUrl, {
				width: 640,
				height: movieInfo.height,
				posterFrame: posterFrame,
				autoplay: true,
				controller: false,
				cache: true,
				showlogo: false,
				bgcolor: '#000000'
			});
			this.displayPanel.appendChild(movie);

			// controller
			if (!AC.Detector.isiPhone() && !AC.Detector.isOpera()) {
				this.movieController = new AC.QuicktimeController(),
				this.movieController.render(this.controllerPanel);
				this.movieController.attachToMovie(movie, { 
					onMoviePlayable: this.movieController.monitorMovie.bind(this.movieController),
					onMovieFinished: this.showEndFrame.bind(this, selectorIndex)
				});
			}

			// for IE				
			movie = null;
		}

		this.resetFlag('cs2IsAnimating');
	},

	showEndFrame: function(selectorIndex) {

		// assuming the user may have jogged to/past the end prevent them from jogging back into movie once controller is hidden
		this.movieController.hardPaused = true;

		// clean up what's left of the movie
		this.hideMovie(selectorIndex);

		// append the end state div
		var endState = this.contentList[selectorIndex].movieInfo.endState;
		endState.style.display = 'block';

		// replay
		var replayButton = Element.getElementsByClassName(endState, 'replay')[0];
		replayButton.onclick = function(selectorIndex) {
			endState.style.display = '';
			this.showMovie(selectorIndex);
			return false;
		}.bind(this, selectorIndex, endState);

	},

	trackClick: function(selectorIndex) {
		var url = this.selectorList[selectorIndex].href;
		var title = this.title+' - '+this.selectorList[selectorIndex].innerHTML;
		
		// click tracking
		AC.Tracking.trackPage({
			pageName: title,
			prop4: url,
			prop6: s.getQueryParam('cp')+': '+title,
			pageURL: url,
			referrer: s.fl(s.wd.location ? s.wd.location : '', 255)
		});
	}
});





// Anchor Fix
var AnchorFix = Class.create();
AnchorFix.prototype = {
	AnchorLinks: [],

	initialize: function(triggers, items, swapper) {
		this.parent = triggers[0].up();

		this.items = items;
		this.swapper = swapper;
		
		this.getAnchorLinks();
		this.fixItemIds();
	},

	getAnchorLinks: function() {
		// get every link on the page and see if it's an anchor link
		var allLinks = $$('#main a');
		for (var i=0; i<allLinks.length; i++) {
			var link = allLinks[i];
			if (link.href.match(/#/) && !Element.hasClassName(link, 'replay')) {
				this.fixAnchorLink(link);
			}
		}
	},

	doesContentExist: function(id) {
		// if the javascript can find the id on the page
		var status = false;
		for (var i=0; i<this.items.length; i++) {
			if (id == this.items[i].id || id == this.items[i].originalId) {
				status = {index:i};
			}
		}
		return status;
	},

	fixAnchorLink: function(link) {
		var id = link.href.match(/#(.*)/)[1];
		
		// if we already don't have the event
	 	if (link.up().up() != this.parent) {

	 		// if we have something to switch to
			var doesContentExist = this.doesContentExist(id);
			if (doesContentExist) {

				// add the swap effect
				var selectorIndex = doesContentExist.index;
				Event.observe(link, 'click', this.swapper.swapContent.bindAsEventListener(this.swapper, selectorIndex), false);
			}
		}
	},

	fixItemIds: function() {
		for (var i=0; i<this.items.length; i++) {
			this.items[i].originalId = this.items[i].id;
			this.items[i].id += '-AnchorFix';
		}
	}
}





// local stuff
Event.observe(window, 'load', function() {
	// do some CSS magic for no javascript version
	Element.addClassName('main', 'hasjs');

	// some DOM stuff
	var triggers = $$('#sidenav li a');
	var contents = $$('#main .swapcontent');

	// all the important stuff
	if (triggers.length>0 && contents.length>0) {
		var swapper = new FadeSwap(triggers, contents, $('quicktimewrap'), $('quicktime'), 'qtcontroller', 'click');

		// fix the anchor links for Safari
		// and make anchor links fade and swap instead of browser default
		var anchors = new AnchorFix(triggers, contents, swapper);
		
		// find the default
		var id = 0;
		if (document.location.hash) {
			var initial = document.location.hash;
			initial = initial.match(/#(.*)/)[1];
			if (anchors.doesContentExist(initial)) id = anchors.doesContentExist(initial).index;
		}

		// swap to the default
		swapper.swapContent(null, id);
	}
});
