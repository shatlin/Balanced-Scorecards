if (typeof(AC) == "undefined") { AC = {}; }
if (typeof(AC.Tracking) == "undefined") {AC.Tracking = {};}

AC.Tracking.tagLinksWithin = function(container, key, value, test) {
	
	$(container).observe('mousedown', function(evt) {
		
		var link = Event.element(evt);

		if (!link) {
			return;
		}

		while (link.nodeName != 'A' && link.nodeName != 'BODY') {
			link = link.parentNode;
		}
		
		if (link.href && test(link)) {
			AC.Tracking.tagLink(link, key, value);
		}
		
		link = null;
	})
	
};

AC.Tracking.tagLink = function(link, key, value) {
	
	var href = link.getAttribute('href');
	
	if (href.match(/\?/)) {
		var params = href.toQueryParams();
		params[key] = value;
		href = href.split(/\?/)[0] + '?' + $H(params).toQueryString();
	} else {
		href += '?' + key + '=' + value;
	}
	
	link.setAttribute('href', href);
};

AC.Tracking.track = function(trackingMethod, properties, options) {

	if (typeof(s_gi) == 'undefined' || !s_gi) {
		return;
	}

	options = options || {};

	//use existing tracking account if available, or use one from the options
	if (typeof(s_account) != 'undefined') {
		s = s_gi(s_account)
	} else if (options.s_account){
		s = s_gi(options.s_account);
	} else {
		return;
	}

	if (trackingMethod == s.tl) {
		
		var linkTrackVars = ''
		
		for (var key in properties) {
			linkTrackVars += key + ',';
		}
		linkTrackVars = linkTrackVars.replace(/,$/, '');
		
		s.linkTrackVars = linkTrackVars;
	} else {
		s.linkTrackVars = '';
	}

	//clear properties set by default within a page
	s.prop4 = "";
	s.g_prop4 = "";
	s.prop6 = "";
	s.g_prop6 = "";
	s.pageName = "";
	s.g_pageName = "";
	s.pageURL = "";
	s.g_pageURL = "";
	s.g_channel = "";
	
	var sanitize = function(value) {
	    if (typeof(value) == "string") {
	        return value.replace(/[\'\"\“\”\‘\’]/g, '');
	    } else {
	        return value;
	    }
	}

	for (var key in properties) {

		s[key] = sanitize(properties[key]);

		if (key == 'events') {
			s.linkTrackEvents = sanitize(properties[key]);
		}
	}

	if (trackingMethod == s.t) {
		void(s.t());
	} else {
		s.tl(options.obj, options.linkType, sanitize(options.title));
	}
	
	for (var key in properties) {
		s[key] = '';
		
		if (key == 'events') {
			s.linkTrackEvents = 'None';
		}
	}

};

AC.Tracking.trackClick = function(properties, obj, linkType, title, options) {
	
	var options = {
		obj: obj,
		linkType: linkType,
		title: title
	};
	
	AC.Tracking.track(s.tl, properties, options);
}

AC.Tracking.trackPage = function(properties, options) {
	AC.Tracking.track(s.t, properties, options);
}

