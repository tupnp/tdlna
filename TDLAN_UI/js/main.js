//Initialize function
var init = function () {
	// TODO:: Do your initialization job
	console.log("init() called");

	// add eventListener for tizenhwkey
	document.addEventListener('tizenhwkey', function(e) {
		if(e.keyName == "back") {
			try {
				tizen.application.getCurrentApplication().exit();
			} catch (error) {
				console.error("getCurrentApplication(): " + error.message);
			}
		}
	});
};

$(document).bind( 'pageinit', init );

function click_box(){
	alert("test");
	$( ".checked-value" ).text( $( "#checkbox-1" ).prop( "checked" ) );
}

function serverClick() {
	window.location.href = "server.html";
}
function settingClick(){
	window.location.href = "setting.html";
}
