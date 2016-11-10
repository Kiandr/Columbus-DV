"use strict";
// This is a
var orderEntryAjax = {
	call: function (method, data, successMethod) {
		var url = sg.utls.url.buildUrl("DV", "DataVisualization", method);
		sg.utls.ajaxPost(url, data, successMethod);
	}
};