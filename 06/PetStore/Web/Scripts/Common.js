$(document).ready(function() {
	// IMPORTANT: Fill in your client key
	var clientKey = "js-m69r7a9gJtYfeklTPmzDJ4XyULDH3Tg1jXLXj4BNCG7eR82tdXwR8YFB8SNjsRzO";
	var cache = {};
	var container = $("#customerpage");
	var errorDiv = container.find("div.text-error");

	/** Handle successful response */
	function handleResp(data) {
		// Check for error
		if (data.error_msg)
			errorDiv.text(data.error_msg);
		else if ("city" in data) {
			// Set city and state
			container.find("#MainContent_tb_city").val(data.city);
			container.find("#MainContent_tb_state").val(data.state);
		}
	}
	// Set up event handlers
	container.find("#MainContent_tb_zipcode").on("keyup change", function () {
		// Get zip code
		debugger;
		var zipcode = $(this).val().substring(0, 5);
		if (zipcode.length == 5 && /^[0-9]+$/.test(zipcode)) {
			// Clear error
			errorDiv.empty();

			// Check cache
			if (zipcode in cache) {
				handleResp(cache[zipcode]);
			}
			else {
				// Build url
				var url = "https://www.zipcodeapi.com/rest/" + clientKey + "/info.json/" + zipcode + "/radians";

				// Make AJAX request
				$.ajax({
					"url": url,
					"dataType": "json"
				}).done(function (data) {
					handleResp(data);

					// Store in cache
					cache[zipcode] = data;
				}).fail(function (data) {
					if (data.responseText && (json = $.parseJSON(data.responseText))) {
						// Store in cache
						cache[zipcode] = json;

						// Check for error
						if (json.error_msg)
							errorDiv.text(json.error_msg);
					}
					else
						errorDiv.text('Request failed.');
				});
			}
		}
	}).trigger("change");
});